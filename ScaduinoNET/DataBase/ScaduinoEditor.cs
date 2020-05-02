using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using ScreenEditor;
using ScreenEditor.DataBase;

namespace ScaduinoNET.DataBase
{
    class ScaduinoEditor
    {
        public ScreenEditor.ScreenEditor CurrentScreenEditor { get; set; }
        public Control SelectedNewComponent { get; set; }
        public Cursor Cursor { get; set; }

        public Control CreateNewControl()
        {
            ControlData control = new ControlData(Program.Scaduino.Editor.SelectedNewComponent);
            return control.CreateControl(Program.Scaduino.Editor.SelectedNewComponent.GetType());
        }
    }
}
