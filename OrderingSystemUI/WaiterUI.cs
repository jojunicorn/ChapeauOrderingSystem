using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace OrderingSystemUI
{
    public partial class WaiterUI : Form
    {
        public WaiterUI()
        {
            InitializeComponent();
        }

        private void WaiterUI_Load(object sender, EventArgs e)
        {
            //Disables tabs in tabcontrol
            tabControl.Appearance = TabAppearance.FlatButtons;
            tabControl.ItemSize = new Size(0, 1);
            tabControl.SizeMode = TabSizeMode.Fixed;
        }
    }
}
