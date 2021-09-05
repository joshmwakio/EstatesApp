using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Binifu_Checkbox
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // bunifuPages1.SelectTab(1);
            this.ActiveControl = bunifuTextBox1;
            int numberOfManagers = flowLayoutPanel1.Controls.Count;
          
       
        }

        private void genBunifuLabel4_Click(object sender, EventArgs e)
        {
           
            bunifuTransition1.HideSync(panel4, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            panel4.Location = new Point(genBunifuLabel4.Location.X, panel4.Location.Y);
            bunifuTransition1.ShowSync(panel4, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            bunifuPages1.SelectTab(0);
        }

        private void accbunifuLabel5_Click(object sender, EventArgs e)
        {
            
            bunifuTransition1.HideSync(panel4, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            panel4.Location = new Point(accbunifuLabel5.Location.X, panel4.Location.Y);
            bunifuTransition1.ShowSync(panel4, false, Bunifu.UI.WinForms.BunifuAnimatorNS.Animation.Transparent);
            bunifuPages1.SelectTab(1);
        }

        private void bunifuVScrollBar1_Scroll(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
          //  flowLayoutPanel1.VerticalScroll.Value = e.Value;
        }

        private void bunifuVScrollBar1_Scroll_1(object sender, Bunifu.UI.WinForms.BunifuVScrollBar.ScrollEventArgs e)
        {
         //  flowLayoutPanel1.VerticalScroll.Value = e.Value;
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            flowLayoutPanel1.VerticalScroll.Value = e.NewValue;
        }

        private void newsbunifuCheckBox6_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            //get initial state check
            var news1state = news1BunifuCheckBox7.CheckState;
            var news2state = news2BunifuCheckBox8.CheckState;
            var news3state = news3BunifuCheckBox.CheckState;
            if (e.Checked)
            {
                news1BunifuCheckBox7.Enabled = true;
                news2BunifuCheckBox8.Enabled = true;
                news3BunifuCheckBox.Enabled = true;
             
                //apply the initial state
                news1BunifuCheckBox7.CheckState =news1state;
                news2BunifuCheckBox8.CheckState = news2state; 
                news3BunifuCheckBox.CheckState = news3state;
          
            }
            else
            {
                news1BunifuCheckBox7.Enabled = false;
                news2BunifuCheckBox8.Enabled = false;
                news3BunifuCheckBox.Enabled = false;
                news1BunifuCheckBox7.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
                news2BunifuCheckBox8.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
                news3BunifuCheckBox.CheckState = Bunifu.UI.WinForms.BunifuCheckBox.CheckStates.Unchecked;
           
            }
        }

        private void bunifuCheckBox11_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            //get initial state
            var inv1state = investment1BunifuCheckBox.CheckState;
            var inv2state = investment2BunifuCheckBox13.CheckState;

            if (e.Checked)
            {
                investment1BunifuCheckBox.Enabled = true;
                investment2BunifuCheckBox13.Enabled = true;
                investment1BunifuCheckBox.CheckState = inv1state;
                investment2BunifuCheckBox13.CheckState = inv2state;

            }
            else
            {
                investment1BunifuCheckBox.Enabled = false;
                investment2BunifuCheckBox13.Enabled = false;
                investment1BunifuCheckBox.CheckState = inv1state;
                investment2BunifuCheckBox13.CheckState = inv2state;
            }
        }

        private void bunifuCheckBox16_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            var job1status = job1BunifuCheckBox15.CheckState;
            var job2status = job2BunifuCheckBox17.CheckState;
            var job3status = job3BunifuCheckBox18.CheckState;
            if (e.Checked)
            {
                job1BunifuCheckBox15.Enabled = true;
                job2BunifuCheckBox17.Enabled = true;
                job3BunifuCheckBox18.Enabled = true;
                job1BunifuCheckBox15.CheckState = job1status;
                job2BunifuCheckBox17.CheckState = job2status;
                job3BunifuCheckBox18.CheckState= job3status;
            }
            else
            {
                job1BunifuCheckBox15.Enabled = false;
                job2BunifuCheckBox17.Enabled = false;
                job3BunifuCheckBox18.Enabled = false;
                job1BunifuCheckBox15.CheckState =job1status;
                job2BunifuCheckBox17.CheckState =job2status;
                job3BunifuCheckBox18.CheckState =job3status;
            }
        }
    }
}
