using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tritech_Glenn_Seplowitz
{
    public partial class frmComputeCarColor : Form
    {
        /// <summary>
        /// Default Constructor
        /// </summary>
        public frmComputeCarColor()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        // get the color of the car
        private void btnComputeColor_Click(object sender, EventArgs e)
        {
            // declare variables
            DateTime futureDate;
            string carColor = String.Empty;
            string message = String.Empty;
            int numberDays = 0;

            try
            {
                // first validate the day entry
                // if an error was found then display it
                message = Common.ValidateDaysEntry(txtDays, out numberDays);
                if (message != String.Empty)
                {
                    MessageBox.Show(message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    // if all goes well then get the car color
                    carColor = ComputeCarColor.color_of_the_day(numberDays);

                    // get the date in the future based on number of days and start date of Monday.  we could have gotten this from the 
                    // "color_of_the_day" function by using an out parameter modifier, but this goes against the requirements
                    // and forces the user of the function to pass in a date when they may not want to.
                    // so it is done separately.
                    futureDate = ComputeCarColor.GetFutureDate(ComputeCarColor.FindMonday(DateTime.Now), numberDays);

                    // display the car color
                    lblCarColor.Text = "The future car color for " + futureDate.ToLongDateString() + " is: ";
                    lblComputedCarColor.Text = carColor;
                    lblComputedCarColor.BackColor = SystemColors.Control;

                    switch (carColor)
                    {
                        case "Red":
                            lblComputedCarColor.ForeColor = Color.Red;
                            break;

                        case "Orange":
                            lblComputedCarColor.ForeColor = Color.Orange;
                            break;

                        case "Yellow":
                            lblComputedCarColor.ForeColor = Color.Yellow;
                            lblComputedCarColor.BackColor = Color.Black;
                            break;

                        case "Green":
                            lblComputedCarColor.ForeColor = Color.Green;
                            break;

                        case "Blue":
                            lblComputedCarColor.ForeColor = Color.Blue;
                            break;

                        case "Purple":
                            lblComputedCarColor.ForeColor = Color.Purple;
                            break;

                        case "Black":
                        case "No Color":
                            lblComputedCarColor.ForeColor = Color.Black;
                            break;

                        default:
                            lblComputedCarColor.ForeColor = Color.Red;
                            break;
                    }
                }

                // select text and set focus to future days text box
                txtDays.SelectionStart = 0;
                txtDays.SelectionLength = txtDays.Text.Length;
                txtDays.Focus();
            }
            catch (Exception ex)
            {
                Common.HandleError(ex);
            }
        }

        /// <summary>
        /// routines to run when form loads
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmComputeCarColor_Load(object sender, EventArgs e)
        {
            try
            {
                // declare variables
                DateTime startingDate = DateTime.Now;

                // get monday's date from today's date
                startingDate = ComputeCarColor.FindMonday(startingDate);

                // set the text in the starting point
                if (DateTime.Now.DayOfWeek.ToString() == "Monday")
                {
                    lblStartPoint.Text = "Today is " + startingDate.ToLongDateString() + " and the car color is currently: ";
                }
                else
                {
                    lblStartPoint.Text = "Assume today is " + startingDate.ToLongDateString() + " and the car color is currently: ";
                }
            }
            catch (Exception ex)
            {
                Common.HandleError(ex);
            }
        }
    }
}
