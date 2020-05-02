using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace ScreenEditor.DataBase
{
    public class PropertiesManager
    {
        public string Type { get; set; }

        public void From(Control control)
        {
            var thisType = this.GetType();
            var controlType = control.GetType();
            this.Type = controlType.FullName;

            foreach (PropertyInfo property in thisType.GetProperties())
            {
                if (property.Name != "Type")
                {
                    PropertyInfo controlProperty = controlType.GetProperty(property.Name);
                    object newValue = controlProperty.GetValue(control);
                    try
                    {
                        property.SetValue(this, newValue);
                    }
                    catch (Exception)
                    {

                    }
                }
            }
        }

        public void To(ref Control control)
        {
            var originType = this.GetType();
            var destinyType = control.GetType();

            foreach (PropertyInfo property in originType.GetProperties())
            {
                if (property.Name != "Type")
                {
                    PropertyInfo controlProperty = destinyType.GetProperty(property.Name);
                    object newValue = property.GetValue(this);
                    if(controlProperty.SetMethod != null)
                        controlProperty.SetValue(control, newValue);
                }
            }
        }
    }
}
