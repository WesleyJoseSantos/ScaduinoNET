using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MetroFramework.Controls;

namespace ScaduinoNET.ScaduinoWindows.Main
{
    public partial class MainToolBar : UserControl
    {
        public MainToolBar()
        {
            InitializeComponent();
            TabControl.SelectedIndex = 0;
        }

        private void TileProjectNew_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Dialogs.NewProject();
        }

        private void TileProjectOpen_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Dialogs.OpenProject();
        }

        private void TileProjectSave_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Project.Save();
        }

        private void TileProjectSaveAll_Click(object sender, EventArgs e)
        {

        }

        private void TileProjectSaveAs_Click(object sender, EventArgs e)
        {

        }

        private void TileProjectSaveClose_Click(object sender, EventArgs e)
        {

        }

        private void TileDisplayHome_Click(object sender, EventArgs e)
        {

        }

        private void TileDisplayExpand_Click(object sender, EventArgs e)
        {

        }

        private void TileDisplayExplorer_Click(object sender, EventArgs e)
        {

        }

        private void TileDisplayConsole_Click(object sender, EventArgs e)
        {

        }

        private void TileDisplayOutput_Click(object sender, EventArgs e)
        {

        }

        private void DisplayMonitor_Click(object sender, EventArgs e)
        {

        }

        private void TileDisplaySettings_Click(object sender, EventArgs e)
        {

        }

        private void TileToolsUndo_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.Parser.Undo();
        }

        private void TileToolsRedo_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.Parser.Redo();
        }

        private void TileToolsCut_Click(object sender, EventArgs e)
        {

        }

        private void TileToolsCopy_Click(object sender, EventArgs e)
        {

        }

        private void TileToolsPast_Click(object sender, EventArgs e)
        {

        }

        private void TileToolsDelete_Click(object sender, EventArgs e)
        {

        }

        private void TileDesignCursor_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.SelectedNewComponent = null;
            Program.Scaduino.Editor.Cursor = Cursors.Default;
        }

        private void TileDesignNewScreen_Click(object sender, EventArgs e)
        {
            new PoupUps.NewScreen().Show();
        }

        private void TileDesignButton_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.SelectedNewComponent = new MetroButton();
            Program.Scaduino.Editor.SelectedNewComponent.Text = "New Button";
            Program.Scaduino.Editor.Cursor = Cursors.UpArrow ;
        }

        private void TileDesignCheckBox_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.SelectedNewComponent = new MetroCheckBox();
            Program.Scaduino.Editor.SelectedNewComponent.Text = "New CheckBox";
            Program.Scaduino.Editor.Cursor = Cursors.UpArrow;
        }

        private void TileDesignToogle_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.SelectedNewComponent = new MetroToggle();
            Program.Scaduino.Editor.SelectedNewComponent.Text = "New Toogle";
            Program.Scaduino.Editor.Cursor = Cursors.UpArrow;
        }

        private void TileDesignTrackBar_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.SelectedNewComponent = new MetroTrackBar();
            Program.Scaduino.Editor.SelectedNewComponent.Text = "New TrackBar";
            Program.Scaduino.Editor.Cursor = Cursors.UpArrow;
        }

        private void TileDesignBarGraph_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.SelectedNewComponent = new MetroProgressBar();
            Program.Scaduino.Editor.SelectedNewComponent.Text = "New BarGraph";
            Program.Scaduino.Editor.Cursor = Cursors.UpArrow;
        }
        private void TileDesignTextBox_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.SelectedNewComponent = new TextBox();
            Program.Scaduino.Editor.SelectedNewComponent.Text = "New TextBox";
            Program.Scaduino.Editor.Cursor = Cursors.UpArrow;
        }

        private void TileDesignChart_Click(object sender, EventArgs e)
        {
            //Program.Scaduino.Editor.SelectedNewComponent = new G();
            //Program.Scaduino.Editor.SelectedNewComponent.Text = "New BarGraph";
            //Program.Scaduino.Editor.Cursor = Cursors.UpArrow;
        }

        private void TileLayoutLeft_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AlignLeft();
        }

        private void TileLayoutCenterY_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AlignCenterY();
        }

        private void TileLayoutCenterRight_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AlignRight();
        }

        private void TileLayoutCenterTop_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AlignTop();
        }

        private void TileLayoutCenterX_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.CenterX();
        }

        private void TileLayoutCenterBotton_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AlignBotton();
        }

        private void TileLayoutAdjustWidth_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AdjustWidth();
        }

        private void TileLayoutAdjustHeight_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AdjustHeight();
        }

        private void TileLayoutAdjustSize_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AdjustSize();
        }

        private void MetroLayoutDistanceX_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AdjustDistanceX();
        }

        private void MetroLayoutDistanceY_Click(object sender, EventArgs e)
        {
            Program.Scaduino.Editor.CurrentScreenEditor.LayoutTool.AdjustDistanceY();
        }
    }
}
