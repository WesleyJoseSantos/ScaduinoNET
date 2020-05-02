using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FastColoredTextBoxNS;
using System.Threading;
using Newtonsoft.Json;
using ScreenEditor.DataBase;

namespace ScreenEditor.Controllers
{
    public class ScreenEditorRealTimeParser
    {
        private List<string> parserList = new List<string>();
        private ScreenEditor screen;
        private UInt16 currentActionIdx = 0;
        private bool undoOrRedo = false;

        public ScreenEditorRealTimeParser(ScreenEditor screen)
        {
            this.screen = screen;
            this.screen.ControlHandled += new EventHandler(Screen_ControlHandled);
            parserList.Clear();
            currentActionIdx = 0;
            ParseScreen();
        }

        public void Undo()
        {
            undoOrRedo = true;
            if (currentActionIdx > 0)
            {
                currentActionIdx--;
                screen.ScreenData = JsonConvert.DeserializeObject<ScreenData>(parserList[currentActionIdx]);
                screen.ReloadFromDataBase();
            }
            undoOrRedo = false;
        }

        public void Redo()
        {
            undoOrRedo = true;
            if (currentActionIdx < parserList.Count - 1)
            {
                currentActionIdx++;
                screen.ScreenData = JsonConvert.DeserializeObject<ScreenData>(parserList[currentActionIdx]);
                screen.ReloadFromDataBase();
            }
            undoOrRedo = false;
        }

        private void Screen_ControlHandled(object sender, EventArgs e)
        {
            if (undoOrRedo) return;
            ThreadPool.QueueUserWorkItem(
                (o) => ParseScreen()
            );
        }

        private void ParseScreen()
        {
            screen.UpdateDataBase();
            parserList.Add(JsonConvert.SerializeObject(screen.ScreenData));
            currentActionIdx++;
        }        

    }
}
