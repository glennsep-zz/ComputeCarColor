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

        /// <summary>
        /// This will compute the car color given the number of days in the future from the start date falling on Monday
        /// </summary>
        /// <param name="futureDays"></param>
        /// <returns></returns>
        public static string color_of_the_day(int futureDays)
        {
            // declare variables
            string carColor = String.Empty;                                         // the car color 
            DateTime startingDate = DateTime.Now;                                   // determine Monday's date by using today's date
            DateTime futureDate;                                                    // the date in the future
            int numberOfWeeks = 0;                                                  // the number of weeks between zero and future days
            int daysWithWeekends = 0;                                               // the number of days having weekends
            int futureDaysWithoutWeekend = 0;                                       // the future day without including the weekends
            int futureDaysWithoutWeekendForRedColor = 0;                            // the future day without including the weekend that determines where the red color is
            int carColorIndex = 0;                                                  // the index to locate car color from list of car colors

            try
            {
                // get monday's date from today's date as our starting point
                startingDate = FindMonday(startingDate);

                // now add the number of days in the future to the monday date
                futureDate = GetFutureDate(startingDate, futureDays);

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
                        // first compute number of weeks in the future days passed into the routine
                        numberOfWeeks = Convert.ToInt32(futureDays / 7);

                        // using the number of weeks determine the number of Saturdays and Sundays
                        daysWithWeekends = numberOfWeeks * 2;

                        // Compute the "Future Days Without Weekends" by subtracting the number of saturdays and sundays from the future days passed into routine
                        futureDaysWithoutWeekend = futureDays - daysWithWeekends;

                        // now using the future days without weekends find the first number divisible by 7 that falls on or before the future days without weekend value
                        // we are finding the day that starts with a red car
                        if (futureDaysWithoutWeekend % 7 == 0)
                        {
                            futureDaysWithoutWeekendForRedColor = futureDaysWithoutWeekend;
                        }
                        else
                        {
                            futureDaysWithoutWeekendForRedColor = futureDaysWithoutWeekend - (futureDaysWithoutWeekend % 7);
                        }

                        // now subtract the future day without weekends for the red car from the future days without weekend
                        // this will give us the correct index in the list of car colors
                        carColorIndex = futureDaysWithoutWeekend - futureDaysWithoutWeekendForRedColor;

                        // get the car color
                        carColor = carColors[carColorIndex];
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // return the car color
            return carColor;
        }

        /// <summary>
        /// Find the prior date that starts on a monday using a starting date (normally today's date)
        /// </summary>
        /// <param name="startingDate"></param>
        /// <returns></returns>
        public static DateTime FindMonday(DateTime startingDate)
        {
            try
            {
                // declare variables
                int dayOfWeek = 0;                                                      // the day of the week as an integer

                // find monday if it isn't monday already
                if (startingDate.DayOfWeek.ToString() != "Monday")
                {
                    // get the current day of the week
                    dayOfWeek = (int)startingDate.DayOfWeek;
                    startingDate = startingDate.AddDays(dayOfWeek == 0 ? -6 : -1 * (dayOfWeek - 1));
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // return the date the starts on Monday
            return startingDate;
        }

        /// <summary>
        /// Get the future date based on the start date of Monday and the number of future days the user inputs
        /// </summary>
        /// <param name="startingDate"></param>
        /// <param name="futureDays"></param>
        /// <returns></returns>
        public static DateTime GetFutureDate(DateTime startingDate, int futureDays)
        {
            try
            {
                return startingDate.AddDays(futureDays);
            }
            catch (Exception ex)
            {
                throw ex;
            }
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
