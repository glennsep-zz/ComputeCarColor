using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tritech_Glenn_Seplowitz
{
    public class Common
    {
        #region Methods

        public static string ValidateDaysEntry(TextBox txtDays, out int numberOfDays)
        {
            // declare variables
            StringBuilder message = new StringBuilder();
            string carColor = string.Empty;
            string daysAsText = txtDays.Text;

            // first let's do some validation
            // make sure something was entered
            if (daysAsText.Trim().Length == 0)
            {
                message.Append("Must enter number of days." + Environment.NewLine);
                txtDays.Text = string.Empty;
            }

            // check if the days entered is a number
            int numberDays;
            bool isNumeric = int.TryParse(daysAsText, out numberDays);
            if (!isNumeric)
            {
                message.Append("Must enter a numeric value and it must be an integer." + Environment.NewLine);
            }

            // check if a negative number was entered
            if (isNumeric && numberDays < 0)
            {
                message.Append("Cannot enter a negative number.");
            }

            // return any error message
            numberOfDays = numberDays;
            return message.ToString();
        }

        #endregion
    }
}
