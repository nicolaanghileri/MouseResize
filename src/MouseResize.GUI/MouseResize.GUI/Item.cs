using MouseResize.GUI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace MouseResize.GUI
{
    public partial class Item : Form
    {
        GUIForm parentGui;

        public Item(GUIForm boh)
        {
            InitializeComponent();
            parentGui = boh;
        }

        private void Item_Load(object sender, EventArgs e)
        {
            foreach (KeyboardKey key in (KeyboardKey[])Enum.GetValues(typeof(KeyboardKey)))
            {
                cbKey.Items.Add(key.ToString());
            }

            foreach (MouseKey key in (MouseKey[])Enum.GetValues(typeof(MouseKey)))
            {
                cbMouse.Items.Add(key.ToString());
            }
        }

        readonly GUIForm gui;
        private void button1_Click(object sender, EventArgs e)
        {
            string listItem = tbProgram.Text + " " + cbKey.Text + " " + cbMouse.Text;
            parentGui.addItemToListBox(listItem);
        }

        private void bClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        
    }
}
