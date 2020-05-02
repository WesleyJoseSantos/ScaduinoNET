using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ScaduinoNET.DataBase
{
    class ScaduinoDirectories
    {
        public string AppData { get => string.Format("{0}\\Scaduino\\AppData.json", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData)); }

        public ScaduinoDirectories()
        {
            string dir = string.Format("{0}\\Scaduino\\", Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData));
            if (!Directory.Exists(dir))
                Directory.CreateDirectory(dir);
        }
    }
}
