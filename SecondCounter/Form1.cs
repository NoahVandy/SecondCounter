//This is my own work
//Noah Vandervelden



using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SecondCounter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_convert_Click(object sender, EventArgs e)
        {
            try
            {
                //get number of seconds entered and convert it to an int
                String input = txtbx_input.Text;
                int seconds = int.Parse(input);
                //format the seconds entered into days hours and minutes
                if(seconds >= 86400)
                {
                    int days = (seconds / 86400);
                    int remainingHours = ((seconds % 86400) / 3600);
                    int remainingMinutes = ((seconds % 86400) % 3600) / 60;
                    int remainingSeconds = ((seconds % 86400) % 3600) % 60;

                    txtbx_output.Text = days.ToString() + " days " + remainingHours.ToString() + " hours " +  remainingMinutes.ToString() +" minutes " + remainingSeconds.ToString() + " seconds";
                }
                else if (seconds >= 3600)
                {
                    int hours = (seconds / 3600);
                    int remainingMinutes = (seconds % 3600) / 60;
                    txtbx_output.Text = hours.ToString() + " hours " + remainingMinutes.ToString() + " minutes";
                }
                else if (seconds >= 60)
                {
                    int minutes = (seconds / 60);
                    int remainingSeconds = (seconds % 60);
                    txtbx_output.Text = minutes.ToString() + " minutes " + remainingSeconds.ToString() + " seconds"; ;
                }
            }
            catch
            {

            }
        }
    }
}
