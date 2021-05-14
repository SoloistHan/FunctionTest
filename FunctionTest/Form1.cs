using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace FunctionTest
{
    public partial class Form1 : Form
    {
        List<List<int>> TTest = new List<List<int>>();
        List<int> OP = new List<int>();
        ArrayList QQQ = new ArrayList();
        public Form1()
        {
            InitializeComponent();
            TabControl_Main.SelectedIndex = 1;
            if (TabControl_Main.SelectedTab.Name == tabPage_Rename.Name)
                Button_Start.Text = "Rename";
            else if (TabControl_Main.SelectedTab.Name == tabPage_Replace.Name)
                Button_Start.Text = "Replace";


            TextBox_RPsource.Text = @"D:\Soloist\Document\Optimus測台\LogFiles\ElectraGenLC__2021-04-27 05-28-05.csv";
            TextBox_OriSymbol.Text = ",";
            TextBox_NewSymbol.Text = "\r";
            
            //Rename.RenameFile(@"D:\wallpaper\20201125~20201128金門", @"D:\wallpaper\20201125~20201128金門\Test", "20201125~1128金門", ".jpg");            
        }       

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (TabControl_Main.SelectedTab.Name == tabPage_Rename.Name)
                Rename.RenameFile(TextBox_SourceFolder.Text, TextBox_TargetFolder.Text, TextBox_NewName.Text, TextBox_Extension.Text);
            else if (TabControl_Main.SelectedTab.Name == tabPage_Replace.Name)
                Replace.ReplaceFile(TextBox_RPsource.Text, TextBox_OriSymbol.Text, TextBox_NewSymbol.Text, RichTextBox_Display , TextBox_RPtarget.Text);
        }       

        private void TabControl_Main_Selected(object sender, TabControlEventArgs e)
        {
            if (TabControl_Main.SelectedTab.Name == tabPage_Rename.Name)
                Button_Start.Text = "Rename";
            else if (TabControl_Main.SelectedTab.Name == tabPage_Replace.Name)
                Button_Start.Text = "Replace";
        }
    }
}
