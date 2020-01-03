using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DELME_CustomTabControl.Properties;

namespace DELME_CustomTabControl
{
    public partial class Form1 : Form
    {
        Button CurrentTabSender;
        bool OpenedComboBox = true;

        Tabs_tab1 tab1 = new Tabs_tab1();
        Tabs_tab2 tab2 = new Tabs_tab2();
        Tabs_tab3 tab3 = new Tabs_tab3();

        public Form1()
        {
            InitializeComponent();
            InitializeTabs();

            CurrentTabSender = Tools1;
            Transform(CurrentTabSender);
        }

        public void InitializeTabs()
        {
            tab1.Location = new Point(1, 1);
            TabInfoPanel.Controls.Add(tab1);

            tab2.Visible = false;
            tab2.Location = new Point(1, 1);
            TabInfoPanel.Controls.Add(tab2);

            tab3.Visible = false;
            tab3.Location = new Point(1, 1);
            TabInfoPanel.Controls.Add(tab3);
        }


        // Вспомогательные функции
        #region Help functions
        private void DisableAll()
        {
            // reset color
            (CurrentTabSender as Button).BackColor = Color.FromArgb(255, 201, 201, 201);

            // reset transform
            CurrentTabSender.Height = CurrentTabSender.Height - 2;
            CurrentTabSender.Width = CurrentTabSender.Width - 4;
            CurrentTabSender.Location = new Point(CurrentTabSender.Location.X + 2, CurrentTabSender.Location.Y + 2);

            //reset tab panel
            tab1.Visible = false;
            tab2.Visible = false;
            tab3.Visible = false;
        }

        private void Transform(object sender)
        {
            CurrentTabSender = (sender as Button);
            CurrentTabSender.BringToFront();
            CurrentTabSender.Height = CurrentTabSender.Height + 2;
            CurrentTabSender.Width = CurrentTabSender.Width + 4;
            CurrentTabSender.Location = new Point(CurrentTabSender.Location.X - 2, CurrentTabSender.Location.Y - 2);
        }
        #endregion

        // Сворачивание TabControl (293px - default height)
        private void ComboBoxBut_Click(object sender, EventArgs e)
        {
            int SpeedAnimation = 10; // less num = slower animation (default = 10)

            if (OpenedComboBox)
            {
                DisableAll();

                Tools1.Enabled = false;
                Tools2.Enabled = false;
                ClockTab.Enabled = false;


                ComboBoxBut.Image = Properties.Resources.ArrowDown;

                while (TabInfoPanel.Height > 3)
                {
                    TabInfoPanel.Height -= SpeedAnimation;
                    Application.DoEvents();
                }

                TabInfoPanel.Height = 3;
            }
            else
            {
                Transform(Tools1);
                Tools1_Click(Tools1, null);

                Tools1.Enabled = true;
                Tools2.Enabled = true;
                ClockTab.Enabled = true;


                ComboBoxBut.Image = Properties.Resources.ArrowUp;

                while (TabInfoPanel.Height < 293)
                {
                    TabInfoPanel.Height += SpeedAnimation;
                    Application.DoEvents();
                }

                TabInfoPanel.Height = 293;
            }

            OpenedComboBox = !OpenedComboBox;
        }


        // Выбор вкладки
        #region Tab Select
        private void Tools1_Click(object sender, EventArgs e)
        {
            DisableAll();
            Tools1.BackColor = Color.FromArgb(255, 123, 165, 240);
            tab1.Visible = true;

            Transform(sender);
        }

        private void Tools2_Click(object sender, EventArgs e)
        {
            DisableAll();
            Tools2.BackColor = Color.FromArgb(255, 123, 165, 240);
            tab2.Visible = true;

            Transform(sender);
        }

        private void ClockTab_Click(object sender, EventArgs e)
        {
            DisableAll();
            ClockTab.BackColor = Color.FromArgb(255, 123, 165, 240);
            tab3.Visible = true;

            Transform(sender);
        }
        #endregion
    }
}
