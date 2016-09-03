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
        protected static List<string> carColors = new List<string> { "Red", "Orange", "Yellow", "Green", "Blue", "Purple", "Black" };

        #endregion


        #region Constructors

        /// <summary>
        /// default constructor
        /// </summary>
        public ComputeCarColor() { }

        #endregion

        #region Methods

        public static string DeterimeCarColor(int futureDays, out DateTime futureDateOut)
        {
            // declare variables
            string carColor = string.Empty;                                         // the car color 
            DateTime startingDate = DateTime.Now;                                   // determine Monday's date by using today's date
            DateTime futureDate;                                                    // the date in the future
            int numberOfWeeks = 0;                                                  // the number of weeks between start and future dates
            int daysLost = 0;                                                       // the number of days lost in the future weeks
            int daysWithoutWeekend = 0;                                             // the future day without including the weekends
            int futureDayDivisibleBy7 = 0;                                          // the future day without including the weekend that is divible by 7
            int carColorIndex = 0;                                                  // the index to locate car color from list of car colors

            // get monday's date from today's date as our starting point
            if (startingDate.DayOfWeek.ToString() != "Monday")
            {
                // find monday!
                startingDate = FindMonday(startingDate);
            }

            // now add the number of days in the future to the monday date
            futureDate = startingDate.AddDays(futureDays);

            // check if the future date falls on a saturday or sunday.
            // if it does then return "No Color"
            if (futureDate.DayOfWeek.ToString() == "Saturday" || futureDate.DayOfWeek.ToString() == "Sunday")
            {
                carColor = "No Color";
            }
            else
            {
                // compute the future color
                // if the day in the future is 4 or less then just return from the list
                if (futureDays <= 4)
                {
                    carColor = carColors[futureDays];
                }
                else
                {
                    // first compute number of weeks from future date to starting date
                    numberOfWeeks = Convert.ToInt32(futureDays / 7);

                    // compute the days lost (meaning we want to count all the weekend days from the number of weeks)
                    daysLost = numberOfWeeks * 2;

                    // compute future days without including weekends (using daysLost)
                    daysWithoutWeekend = futureDays - daysLost;

                    // now using the future days without including weekends find the first number divisible by 7
                    // we are finding the day that start with a red car
                    if (daysWithoutWeekend % 7 == 0)
                    {
                        futureDayDivisibleBy7 = daysWithoutWeekend;
                    }
                    else
                    {
                        futureDayDivisibleBy7 = daysWithoutWeekend - (daysWithoutWeekend % 7);
                    }

                    // now subtract the future day without weekends that is divible by 7 (red car) from take the future days without weekend
                    // this will give us the correct index in the list of car colors
                    carColorIndex = daysWithoutWeekend - futureDayDivisibleBy7;

                    // get the car color
                    carColor = carColors[carColorIndex];
                }
            }

            // return the car color
            futureDateOut = futureDate;
            return carColor;
        }

        public static DateTime FindMonday(DateTime startingDate)
        {
            // declare variables
            int dayOfWeek = 0;                                                      // the day of the week as an integer

            // find monday!
            // get the current day of the week
            dayOfWeek = (int)startingDate.DayOfWeek;
            startingDate = startingDate.AddDays(dayOfWeek == 0 ? -6 : -1 * (dayOfWeek - 1));

            // return the date the starts on Monday
            return startingDate;
        }

        #endregion

        #region Properties

        /// <summary>
        /// List of car colors
        /// </summary>
        public static List<string> CarColors
        {
            get { return carColors; }
        }

        #endregion
    }
}
