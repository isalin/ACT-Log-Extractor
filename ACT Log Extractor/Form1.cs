using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACT_Log_Extractor
{
    public partial class MainForm : Form
    {
        LogParser log;

        public MainForm()
        {
            InitializeComponent();
            log = new LogParser(this);
        }

        private void button_refresh_Click(object sender, EventArgs e)
        {
            log.refresh(this);
        }

        private void button_exportText_Click(object sender, EventArgs e)
        {
            if (boxesChecked())
            {
                log.parse("filepath", this, false);
            }
            else
            {
                MessageBox.Show("Nothing has been selected for export.", "Error");
            }
        }

        private bool boxesChecked()
        {
            if ((checkBox_alliance.Checked || checkBox_freeCompany.Checked || checkBox_linkshell1.Checked || checkBox_linkshell2.Checked || checkBox_linkshell3.Checked || checkBox_linkshell4.Checked || checkBox_linkshell5.Checked || checkBox_linkshell6.Checked || checkBox_linkshell7.Checked || checkBox_linkshell8.Checked || checkBox_party.Checked || checkBox_say.Checked || checkBox_shout.Checked || checkBox_tell.Checked || checkBox_yell.Checked))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private void checkBox_tell_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_tell.Checked == true)
            {
                DialogResult result = MessageBox.Show("Are you sure you want to export tells?", "Warning", MessageBoxButtons.YesNo);
                if (result == DialogResult.No)
                {
                    checkBox_tell.Checked = false;
                }
            }
        }

        private void button_exportHTML_Click(object sender, EventArgs e)
        {
            if (boxesChecked())
            {
                log.parse("filepath", this, true);
            }
            else
            {
                MessageBox.Show("Nothing has been selected for export.", "Error");
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void checkBox_conversations_CheckedChanged(object sender, EventArgs e)
        {
            numericUpDown_secondsBeforeBreak.Enabled = !numericUpDown_secondsBeforeBreak.Enabled;
        }
    }
}
