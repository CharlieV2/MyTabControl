using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DELME_CustomTabControl
{
    public partial class Tabs_tab3 : UserControl
    {
        public Tabs_tab3()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TimeLab.Text = DateTime.Now.ToString("h:mm:ss tt");
        }
    }
}
