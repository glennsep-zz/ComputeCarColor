using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tritech_Glenn_Seplowitz
{
    public class ComputeCarColor
    {
        #region Attributes

        // define the colors in a list
        protected List<string> carColors = new List<string> { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black" };

        #endregion


        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public ComputeCarColor() { }

        #endregion

        #region Methods

        public static string DeterimeCarColor(int days)
        {
            // declare variables
            string carColor = string.Empty;                                         // the car color 
            DateTime mondayStartingDate = DateTime.Now;                             // determine Monday's date by using today's date

            // get monday's date from today's date as our starting point
            if (mondayStartingDate.DayOfWeek.ToString() != "Monday")
            {
                // find monday!
                for (int day = mondayStartingDate.Day; day >=0; day--)
                {
                    if (mondayStartingDate.AddDays(day).DayOfWeek.ToString() == "Monday")
                    {
                        mondayStartingDate = mondayStartingDate.AddDays(days);
                    }
                }

            }


            // return the car color
            return carColor;
        }

        #endregion

        #region Properties

        /// <summary>
        /// List of car colors
        /// </summary>
        public List<string> CarColors
        {
            get { return carColors; }
        }

        #endregion
    }
}
