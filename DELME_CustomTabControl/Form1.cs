using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DELME_CustomTabControl
{
    public partial class Form1 : Form
    {
        Tabs_tab1 tab1 = new Tabs_tab1();
        Tabs_tab2 tab2 = new Tabs_tab2();
        Tabs_tab3 tab3 = new Tabs_tab3();

        public Form1()
        {
            InitializeComponent();
            InitializeTabs();
        }

        public void InitializeTabs()
        {
            tab1.Location = new Point(1, 1);
            panel1.Controls.Add(tab1);

            tab2.Visible = false;
            tab2.Location = new Point(1, 1);
            panel1.Controls.Add(tab2);

            tab3.Visible = false;
            tab3.Location = new Point(1, 1);
            panel1.Controls.Add(tab3);
        }


        private void DisableAll()
        {
            Tools1.BackColor = Color.FromArgb(255, 201, 201, 201);
            Tools2.BackColor = Color.FromArgb(255, 201, 201, 201);
            ClockTab.BackColor = Color.FromArgb(255, 201, 201, 201);

            tab1.Visible = false;
            tab2.Visible = false;
            tab3.Visible = false;
        }
        


        #region Tab Select
        private void Tools1_Click(object sender, EventArgs e)
        {
            DisableAll();
            Tools1.BackColor = Color.FromArgb(255, 123, 165, 240);
            tab1.Visible = true;
        }

        private void Tools2_Click(object sender, EventArgs e)
        {
            DisableAll();
            Tools2.BackColor = Color.FromArgb(255, 123, 165, 240);
            tab2.Visible = true;
        }

        private void ClockTab_Click(object sender, EventArgs e)
        {
            DisableAll();
            ClockTab.BackColor = Color.FromArgb(255, 123, 165, 240);
            tab3.Visible = true;
        }

        #endregion
    }
}
