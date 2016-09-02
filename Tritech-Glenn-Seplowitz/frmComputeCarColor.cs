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
            string carColor = String.Empty;
            string message = String.Empty;
            int numberDays = 0;

            // first validate the day entry
            // if an error was found then display it
            message = Common.ValidateDaysEntry(txtDays, out numberDays);
            if (message != string.Empty)
            {
                MessageBox.Show(message, "Problem", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtDays.Focus();
            }
            else
            {
                // if all goes well then get the car color
                carColor = ComputeCarColor.DeterimeCarColor(numberDays);
            }
        }
    }
}
