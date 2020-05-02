using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.Drawing;
using System.Reflection;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ScreenEditor.DataBase
{
    public class ScreenData
    {
        public string Path { get; set; }
        public ScreenPropreties Properties { get; set; }
        public List<ControlData> Controls { get; set; }

        public ScreenData()
        {
            Properties = new ScreenPropreties();
            Controls = new List<ControlData>();
        }

        public void Save()
        {
            File.WriteAllText(Path, JsonConvert.SerializeObject(this, Formatting.Indented));
        }

    }

    public class ScreenPropreties : PropertiesManager
    {
        public string Name { get; set; }
        public string AccessibleDescription { get; set; }
        public Size Size { get; set; }
        //public Point Location { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }

        public ScreenPropreties()
        {
            Type = typeof(ScreenData).FullName;
        }

        public void To(ref ScreenEditor screenEditor)
        {
            var originType = this.GetType();
            var destinyType = screenEditor.GetType();

            foreach (PropertyInfo property in originType.GetProperties())
            {
                if (property.Name != "Type")
                {
                    PropertyInfo controlProperty = destinyType.GetProperty(property.Name);
                    object newValue = property.GetValue(this);
                    controlProperty.SetValue(screenEditor, newValue);
                }
            }
        }
    }
}
