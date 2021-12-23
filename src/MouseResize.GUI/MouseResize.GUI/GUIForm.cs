using MouseResize.GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MouseResize.GUI
{
    public partial class GUIForm : Form
    {

        public GUIForm()
        {
            InitializeComponent();
        }
        

        public void addItemToListBox(string value)
        {
            ListBox blacklist = lbBlacklist;
            blacklist.Items.Add(value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (KeyboardKey key in (KeyboardKey[]) Enum.GetValues(typeof(KeyboardKey)))
            {
                cbKeyMove.Items.Add(key.ToString());
                cbKeyResize.Items.Add(key.ToString());
            }

            foreach (MouseKey key in (MouseKey[])Enum.GetValues(typeof(MouseKey)))
            {
                cbMouseMove.Items.Add(key.ToString());
                cbMouseResize.Items.Add(key.ToString());
            }
        }

        private void bAdd_Click(object sender, EventArgs e)
        {
            Item f2 = new Item(this);
            f2.ShowDialog();
        }

        private void bDelete_Click(object sender, EventArgs e)
        {
            ListBox blacklist = lbBlacklist;
            blacklist.Items.Remove(blacklist.SelectedItem);
        }

        //sets default values
        private void bReset_Click(object sender, EventArgs e)
        {
            cbKeyMove.Text = "LControl";
            cbMouseMove.Text = "RButton";

            cbMouseResize.Text = "LButton";
            cbKeyResize.Text = "LControl";
        }

        private void bApply_Click(object sender, EventArgs e)
        {
            //Using class IniFile to create or override ini file
            var MyIni = new IniFile("config.ini");

            //Readed values
            MyIni.Write("ResizeKeyboard", cbKeyResize.Text, "Keys");
            MyIni.Write("ResizeMouse", cbMouseResize.Text, "Keys");
            MyIni.Write("ShiftKeyboard", cbMouseResize.Text, "Keys");
            MyIni.Write("ShiftMouse", cbMouseResize.Text, "Keys");

            //defaults
            if (cbKeyResize.Text.Length == 0)
            {
                MyIni.Write("ResizeKeyboard", "LControl", "Keys");
            }
            if (cbMouseResize.Text.Length == 0)
            {
                MyIni.Write("ResizeMouse", "LButton", "Keys");
            }
            if (cbKeyMove.Text.Length == 0)
            {
                MyIni.Write("ShiftKeyboard", "LControl", "Keys");
            }
            if (cbMouseMove.Text.Length == 0)
            {
                MyIni.Write("ShiftMouse", "RButton", "Keys");
            }

            int count = 0;
            foreach(var item in lbBlacklist.Items)
            {
                MyIni.Write(count.ToString(), item.ToString(), "Programs");
                count++;
            }

        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }



        //Useless Clicks
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void cbKeyboard_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
