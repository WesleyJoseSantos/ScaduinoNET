using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;
using ScreenEditor.DataBase;

namespace Communication
{
    public partial class ScaduinoBus : Communication
    {
        public char EndChar { get; set; }

        public char SeparatorChar { get; set; }
        
        public SerialPort Serial {
            get => Serial;
            set {
                Serial = value;
                Serial.DataReceived += new SerialDataReceivedEventHandler(SerialPort_DataRecieved);
            }
        }

        public ScaduinoBus()
        {
            InitializeComponent();
            SeparatorChar = ',';
            EndChar = '\n';
            DeviceId = 0;
            Tags = new List<ScreenEditor.DataBase.ControlTag>();
        }

        public ScaduinoBus(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        public override void connect()
        {
            base.connect();
            Serial.Open();
            sendData();
        }

        private void sendData()
        {
            foreach (ControlTag tag in Tags)
            {
                Serial.Write(tag.Value);
                if (Tags.Last() != tag)
                {
                    Serial.Write(SeparatorChar.ToString());
                }
            }
            Serial.Write(EndChar.ToString());
        }

        private void processData(String data)
        {
            List<string> elements = data.Split(SeparatorChar).ToList<string>();
            for (int i = 0; i < elements.Count; i++)
            {
                string element = elements[i];
                if (element == EndChar.ToString()) break;
                switch (Tags[i].Type)
                {
                    case ControlTag.ControlTagType.Boolean:
                        Tags[i].Value = element == "true" || element == "1";
                        break;
                    case ControlTag.ControlTagType.Integer:
                        Tags[i].Value = int.Parse(element);
                        break;
                    case ControlTag.ControlTagType.Float:
                        Tags[i].Value = float.Parse(element);
                        break;
                    case ControlTag.ControlTagType.String:
                        Tags[i].Value = element;
                        break;
                    default:
                        break;
                }
            }
            sendData();
        }

        private void SerialPort_DataRecieved(object sender, SerialDataReceivedEventArgs e)
        {
            processData(Serial.ReadTo(EndChar.ToString()));
        }
    }
}
