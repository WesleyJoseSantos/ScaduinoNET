using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using ScaduinoNET.ScaduinoWindows.Main;
using ScaduinoNET.ScaduinoWindows;

namespace ScaduinoNET.DataBase
{
    class ScaduinoApp
    {
        public ScaduinoSettings Settings { get; set; }
        public ScaduinoDirectories Directories { get; set; }
        public ScaduinoEditor Editor { get; set; }
        public ScaduinoProject Project { get; set; }
        public ScaduinoForms Forms { get; set; }
        public ScaduinoDialogs Dialogs { get; set; }

        public ScaduinoApp()
        {
            Settings = new ScaduinoSettings();
            Directories = new ScaduinoDirectories();
            Editor = new ScaduinoEditor();
            Forms = new ScaduinoForms();
            Dialogs = new ScaduinoDialogs();
            Project = new ScaduinoProject();
        }

        public void LoadData()
        {
            try
            {
                string json = File.ReadAllText(this.Directories.AppData);
                this.Settings = JsonConvert.DeserializeObject<ScaduinoSettings>(json);
            }
            catch (Exception)
            {

            }
        }

        public void SaveData()
        {
            string json = JsonConvert.SerializeObject(this.Settings);
            File.WriteAllText(this.Directories.AppData, json);
        }

    }

    public class ScaduinoForms
    {
        private readonly MainMDI mainMDI = new MainMDI();

        public MainMDI MainMDI { get => mainMDI;}
    }
}
