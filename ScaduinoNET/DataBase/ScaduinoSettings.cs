using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaduinoNET.DataBase
{
    class ScaduinoSettings
    {
        public ScaduinoSettingsInterface Interface { get; set; }
        public ScaduinoSettingsHistory History { get; set; }

        public ScaduinoSettings()
        {
            Interface = new ScaduinoSettingsInterface();
            History = new ScaduinoSettingsHistory();
        }
    }

    class ScaduinoSettingsInterface
    {
        public int ContainerMainSplitterDistance { get; set; }
        public int ContainerWorkspaceSplitterDistance { get; set; }

        public ScaduinoSettingsInterface()
        {
            ContainerMainSplitterDistance = 190;
            ContainerWorkspaceSplitterDistance = 380;
        }
    }

    class ScaduinoSettingsHistory
    {
        public List<ScaduinoProjectProperties> RecentProjects { get; set; }
        public string RecentProjectsDirectory { get; set; }

        public ScaduinoSettingsHistory()
        {
            RecentProjects = new List<ScaduinoProjectProperties>();
            RecentProjectsDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        }
    }
}
