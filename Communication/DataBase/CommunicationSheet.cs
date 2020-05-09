using ScreenEditor.DataBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Communication.DataBase
{
    class CommunicationSheet
    {
        string Description { set; get; }
        string Address { get; set; }
        string Header { get; set; }
        List<ControlTag> Tags { get; set; }
    }
}
