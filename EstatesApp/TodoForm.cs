using Bunifu.UI.WinForms;
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
    public partial class TodoForm : Form
    {
        public TodoForm()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            //Loop the panels in the FlowLayoutPanel
            foreach (Panel panel in flowLayoutPanel1.Controls)
            {
                //Loop each control in the panel
                foreach (var ctrl in panel.Controls)
                {
                    /*check whether a control is a Bunifu Checkbox and assign 
                        * each with a CheckStateChanged event
                        */
                    if (ctrl is BunifuCheckBox)
                    {
                        /*get the control and explicity convert it to a BunifuCheckbox type
                            * by casting it
                        */
                        BunifuCheckBox bunifuCheckbox = (BunifuCheckBox)ctrl;
                        //assign Bunifu checkbox a `CheckStateChanged` event
                        bunifuCheckbox.CheckStateChanged += BunifuCheckbox_CheckStateChanged;
                    }

                }

            }
        }

private void BunifuCheckbox_CheckStateChanged(object sender, BunifuCheckBox.CheckedChangedEventArgs e)
{
    try
    {
        //reference the Bunifu Checkbox object that has raised this event
        BunifuCheckBox c = (BunifuCheckBox)sender;
        //check the status of the checkbox
        if (e.CheckState == BunifuCheckBox.CheckStates.Checked)
        {
            /*add one value to Bunifu ProgressBar and display the checked task
                * in a Bunifu Snackbar
                */
            bunifuProgressBar1.Value+=1;
            //the second parameter in the Show method gets the text associated with the selected checkbox
            bunifuSnackbar1.Show(this, String.Format("Task '{0}' is now checked",c.BindingControl.Text), BunifuSnackbar.MessageTypes.Success, 2100,null,BunifuSnackbar.Positions.BottomCenter);
            tasksBunifuLabel.Text = String.Format("{0} out of 7 tasks are complete...", bunifuProgressBar1.Value);
        }
        else
        {
            /*subtract one value to Bunifu ProgressBar and display the unchecked task
            * in a Bunifu Snackbar
            */
            bunifuProgressBar1.Value-=1;
            tasksBunifuLabel.Text = String.Format("{0} out of 7 tasks are complete...", bunifuProgressBar1.Value);
            //the second parameter in the Show method gets the text associated with the selected checkbox
            bunifuSnackbar1.Show(this, String.Format("Task '{0}' is now unchecked", c.BindingControl.Text), BunifuSnackbar.MessageTypes.Success, 2100, null, BunifuSnackbar.Positions.BottomCenter);
        }

    }
    catch (Exception exception)
    {
        Console.WriteLine(exception.Message);
    }

    }

}
}
