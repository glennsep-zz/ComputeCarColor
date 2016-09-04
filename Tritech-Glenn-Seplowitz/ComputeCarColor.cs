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
        /// <param name="futureDateOut"></param>
        /// <returns></returns>
        public static string DeterimeCarColor(int futureDays, out DateTime futureDateOut)
        {
            // explaination of approach to compute car color

            // first review the following chart

            //Future Days without Weekends    Color Index     Color       Future Days     Day of Week
            //0                               0               Red         0               mon
            //1                               1               Orange      1               tue
            //2                               2               Yellow      2               wed
            //3                               3               Green       3               thu
            //4                               4               Blue        4               fri
            //                                                No Color    5               sat
            //                                                No Color    6               sun
            //5                               5               Purple      7               mon
            //6                               6               Black       8               tue
            //7                               0               Red         9               wed
            //8                               1               Orange      10              thu
            //9                               2               Yellow      11              fri
            //                                                No color    12              sat
            //                                                No Color    13              sun
            //10                              3               Green       14              mon
            //11                              4               Blue        15              tue
            //12                              5               Purple      16              wed
            //13                              6               Black       17              thu
            //14                              0               Red         18              fri
            //                                                no Color    19              sat
            //                                                No Color    20              sun

            // The "Future Days" column represents the number of days in the future that the user inputs to determine the color from a start date of Monday
            // The "Day of Week" is used as a reference to show what day the future days falls on
            // The "Color Index" column represents the index in the color list.
            // The "Color" column is synced with the "Color Index" column.  The Color Index column is used to get the color from the list
            // The "Future Days without Weekends" column represents the days in the future without taking into account weekends.  This is important as this number
            //      will help determine what color to use.

            // the logic flow goes like this:
            // 1. the user enters a future date.
            // 2. Based on today's date the Monday date prior to today's date is computed.  This date serves as the starting date.
            // 3. The date in the future is determined by adding the future days passed into the routine to the starting date. This is called the future date.
            // 4. If the future date falls on a Saturday or Sunday then "No Color" is returned.
            // 5. If the days in the future is between 0 and 4 inclusive then the routine passes in the index to the color list and returns the color.
            // 6. If the days in the future is greater then 4 we first need to compute the "Future Days without Weekends"
                    // a. This is done by taking the future days passed into the routine and determining the number of weeks that fall within the future days.
                            // for example if the future days is 21 then this equates to 3 weeks.
                    // b. once the number of weeks is determined we need to count the number of saturdays and sundays.
                            // so for 1 week there is always a Saturday and Sunday.  This is 2 days that we don't want to include
                            // so if we have 3 weeks there are six days we dont want to include.  That is 3 weeks * 2 days (Saturday and Sunday).  This gives us 6 days.
                    // c. Once we have the number of days not to include we subtract this number from the future days passed into the routine.
                            // this gives us the "Future Days without Weekends" column.
            // 7. The table above shows that every "Future Days without Weekends that is divisble by 7 starts with the color Red.
                    // So the days of 7 and 14 start with red.
            // 8. Based on the "Future Days Without Weekends" we determine where the prior number that is divsible by 7.
                    // so if the "Future Days Without Weekends" is 12 then the number divisible by 7 would by 7.
            // 9. We then determine the index in the car color list by subtracting the number divisble by 7 from the "Future Days Without Weekends" that syncs with future days
            // 10.  We then use this index to get the color.

            // so let's say the user enters in a future day of 15.
            // we determine that 15 days has 2 full weeks.
            // we then take 2 weeks times 2 days (for saturday and sunday).  This gives us 4.
            // we then get the "Future Days Without Weekends" by subtracting 15 (future days) - 4 which gives us 11.
            // Then using 11 we find the prior day that is divisible by 7 which is 7 days in the "Future Days Without Weekends" column.
            // We then subtract 11 - 7 which equals 4.
            // 4 is the index for the blue color in the "Color Index" column.
            // we then get the color blue by passing in the index of 4 to the color list and return the color.
            

            // declare variables
            string carColor = string.Empty;                                         // the car color 
            DateTime startingDate = DateTime.Now;                                   // determine Monday's date by using today's date
            DateTime futureDate;                                                    // the date in the future
            int numberOfWeeks = 0;                                                  // the number of weeks between start and future dates
            int daysWithoutWeekends = 0;                                            // the number of days that don't include weekends
            int futureDaysWithoutWeekend = 0;                                       // the future day without including the weekends
            int futureDaysWithoutWeekendForRedColor = 0;                            // the future day without including the weekend that determines where the red color is
            int carColorIndex = 0;                                                  // the index to locate car color from list of car colors

            // get monday's date from today's date as our starting point
            startingDate = FindMonday(startingDate);

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
                    // first compute number of weeks in the future days passed into the routine
                    numberOfWeeks = Convert.ToInt32(futureDays / 7);

                    // using the number of weeks determine the number of Saturdays and Sundays
                    daysWithoutWeekends = numberOfWeeks * 2;

                    // Compute the "Future Days Without Weekends" by subtracting the number of saturdays and sundays from the future days passed into routine
                    futureDaysWithoutWeekend = futureDays - daysWithoutWeekends;

                    // now using the future days without including weekends find the first number divisible by 7
                    // we are finding the day that start with a red car
                    if (futureDaysWithoutWeekend % 7 == 0)
                    {
                        futureDaysWithoutWeekendForRedColor = futureDaysWithoutWeekend;
                    }
                    else
                    {
                        futureDaysWithoutWeekendForRedColor = futureDaysWithoutWeekend - (futureDaysWithoutWeekend % 7);
                    }

                    // now subtract the future day without weekends that is divible by 7 (red car) from take the future days without weekend
                    // this will give us the correct index in the list of car colors
                    carColorIndex = futureDaysWithoutWeekend - futureDaysWithoutWeekendForRedColor;

                    // get the car color
                    carColor = carColors[carColorIndex];
                }
            }

            // return the car color
            futureDateOut = futureDate;
            return carColor;
        }

        /// <summary>
        /// Find the prior date that starts on a monday using a starting date (normally today's date)
        /// </summary>
        /// <param name="startingDate"></param>
        /// <returns></returns>
        public static DateTime FindMonday(DateTime startingDate)
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
