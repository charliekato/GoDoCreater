using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GoDoCreater
{
    public partial class MainMenu : Form
    {
        public MainMenu(string title)
        {
            InitializeComponent();
            this.Text = title;
        }

        private void checkBoxScenario3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonExe_Click(object sender, EventArgs e)
        {
            GlobalV.Strategy1 = checkBoxStrategy1.Checked;
            GlobalV.Strategy2 = checkBoxStrategy2.Checked;
            GoDogen.PrepareGO();
            if (checkBoxScenario1.Checked)
                GoDogen.Scenario1();

            if (!checkBoxScenario2.Checked)
                MessageBox.Show("シナリオ1(レーン寄せ)終了");
            else
                GoDogen.Scenario2();

            if (!checkBoxScenario3.Checked)
                MessageBox.Show("シナリオ2");
            else
                GoDogen.Scenario3();
        }

        private void buttonQuit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
