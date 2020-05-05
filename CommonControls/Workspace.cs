using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CommonControls;
using System.IO;

namespace ScaduinoNET.ScaduinoWindows.Main
{
    public partial class Workspace : UserControl
    {
        private readonly List<FileEditor> openedEditors = new List<FileEditor>();

        public Workspace()
        {
            InitializeComponent();
        }

        public void Save()
        {
            var file = GetFileEditor(TabPage.SelectedTab);
            if (file != null)
                file.SaveFile();
        }

        public void SaveAll()
        {
            foreach (TabPage tab in TabPage.TabPages)
            {
                GetFileEditor(tab).SaveFile();
            }
        }

        public void SaveClose()
        {
            var file = GetFileEditor(TabPage.SelectedTab);
            if (file != null)
                file.SaveFile();
            if(TabPage.TabPages.Count > 0)
                TabPage.TabPages.Remove(TabPage.SelectedTab);
        }

        public bool CreateTab(string name, FileEditor content, string path)
        {
            bool ret = false;
            var tabPage = GetTab(name);
            if(tabPage == null)
            {
                tabPage = new TabPage(name)
                {
                    ToolTipText = path
                };
                tabPage.Controls.Add(content);
                openedEditors.Add(content);
                content.Dock = DockStyle.Fill;
                TabPage.TabPages.Add(tabPage);
                ret = true;
            }
            TabPage.SelectedTab = tabPage;
            return (ret);
        }

        public void CloseAllTabs()
        {
            TabPage.TabPages.Clear();
        }

        private TabPage GetTab(string name)
        {
            foreach (TabPage tabPage in TabPage.TabPages)
            {
                if(tabPage.Text == name)
                {
                    return (tabPage);
                }
            }
            return null;
        }

        private void TabPage_CloseButtonClicked(object sender, VisualStudioTabControl.CloseButtonClickedEventArgs e)
        {
            FileEditor fileEditor = GetFileEditor(e.TabPage);
            if (fileEditor == null) return;
            if (fileEditor.FileChanged())
            {
                var result = MessageBox.Show("Save Modifications?", "Save", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    fileEditor.SaveFile();
                }
                if(result == DialogResult.Cancel)
                {
                    return;
                }
            }
            openedEditors.Remove(fileEditor);
            TabPage.TabPages.Remove(e.TabPage);
        }

        private FileEditor GetFileEditor(TabPage tabPage)
        {
            FileEditor fileEditor = null;
            if (TabPage.TabPages.Count == 0) return null;
            foreach (var control in tabPage.Controls)
            {
                if (control.GetType().BaseType.FullName == typeof(FileEditor).FullName)
                    fileEditor = (FileEditor)control;
            }
            return fileEditor;
        }
    }
}
