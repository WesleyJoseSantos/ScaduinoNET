using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;
using MetroFramework.Controls;
using MetroFramework.Interfaces;

namespace ScreenEditor.DataBase
{
    public class ControlData
    {
        public ControlProperties Properties { get; set; }

        public ControlData()
        {
            Properties = new ControlProperties();
        }

        public ControlData(Control control)
        {
            Properties = new ControlProperties();
            Properties.From(control);
        }

        public Control CreateControl(Type type)
        {
            Assembly assembly = type.Assembly;
            Control control = (Control)assembly.CreateInstance(this.Properties.Type);

            Properties.To(ref control);

            return (control);
        }

    }

    public class ControlTag
    {
        public enum ControlTagType
        {
            Boolean,
            Integer,
            Float,
            String,
            ScaduinoData
        }

        public string Name { get; set; }
        public ControlTagType Type { get; set; }
        public string Description { get; set; }
        public dynamic Value { get; set; }
    }

    public class ControlProperties : PropertiesManager
    {
        public Size Size { get; set; }
        public string AccessibleDescription { get; set; }
        public Point Location { get; set; }
        public string Text { get; set; }
        public Color BackColor { get; set; }
        public Color ForeColor { get; set; }
        public ControlTag Tag { get; set; }
    }
}
