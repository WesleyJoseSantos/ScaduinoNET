using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ScreenEditor.DataBase;
using CommonControls;
using Newtonsoft.Json;
using System.IO;

namespace ScaduinoNET.ScaduinoWindows.Editors
{
    public partial class ProjectTagsEditor : FileEditor
    {
        private readonly string[] types =
        {
            "Boolean",
            "Integer",
            "Float",
            "String",
            "ScaduinoData"
        };

        public ProjectTagsEditor()
        {
            InitializeComponent();
            Extensions = new string[] {"tgs"};
            
        }

        public override void LoadFile()
        {
            string data = File.ReadAllText(FilePath);
            var tags = JsonConvert.DeserializeObject<List<ControlTag>>(data);
            if (tags == null) return;
            gridTags.Rows.Clear();
            foreach (ControlTag tag in tags)
            {
                string[] row = { tag.Name, tag.Type.ToString(), tag.Description, tag.Value };
                if((int)tag.Type != -1)
                {
                    gridTags.Rows.Add(row);
                }
            }
        }

        public override void SaveFile()
        {
            var tags = new List<ControlTag>();
            System.Collections.IList list = gridTags.Rows;
            for (int i = 0; i < list.Count-1; i++)
            {
                DataGridViewRow item = (DataGridViewRow)list[i];
                var tag = new ControlTag();
                dynamic type = item.Cells[1].Value as string;
                type = types.ToList().IndexOf(type);
                type = type == -1 ? 0 : type;
                type = (ControlTag.ControlTagType)type;

                tag.Name = item.Cells[0].Value as string ?? "";
                tag.Type = type;
                tag.Description = item.Cells[2].Value as string ?? "";
                tag.Value = item.Cells[3].Value;

                tags.Add(tag);
            }
            string data = JsonConvert.SerializeObject(tags, Formatting.Indented);
            File.WriteAllText(FilePath, data);
        }

        public override bool FileChanged()
        {
            return (false);
        }

        private void gridTags_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if(e.ColumnIndex == 3)
            {
                int rowIdx = e.RowIndex;
                if (e.RowIndex == -1) return;
                dynamic type = gridTags.Rows[rowIdx].Cells[1].Value;
                type = types.ToList().IndexOf(type);
                type = type == -1 ? 0 : type;
                ControlTag.ControlTagType vType = (ControlTag.ControlTagType)type;
                string value = gridTags.Rows[rowIdx].Cells[3].Value.ToString();
                switch (vType)
                {
                    case ControlTag.ControlTagType.Boolean:
                        if (value != "true" && value != "false")
                            gridTags.Rows[rowIdx].Cells[3].Value = "false";
                        break;
                    case ControlTag.ControlTagType.Integer:
                        bool isInteger = int.TryParse(value, out int outInt);
                        if (!isInteger) gridTags.Rows[rowIdx].Cells[3].Value = 0;
                        break;
                    case ControlTag.ControlTagType.Float:
                        bool isFloat = float.TryParse(value, out float outFloat);
                        if (!isFloat) gridTags.Rows[rowIdx].Cells[3].Value = 0;
                        break;
                    default:
                        break;
                }
            }
        }
    }

}
