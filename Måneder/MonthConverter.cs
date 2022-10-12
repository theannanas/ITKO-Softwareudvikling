
using System.Linq;

namespace Måneder
{
    internal class MonthConverter
    {
        public static string ConvertNumberToMonth(int month) {
            string[] months = { 
                "Januar", 
                "Februar", 
                "Marts", 
                "April", 
                "Maj", 
                "Juni", 
                "Juli", 
                "August", 
                "September",
                "Oktober",
                "November",
                "December"
            };
            return months[month - 1];
        }

        public static int ConvertMonthToNumber(string month) {
            int monthAsInt;
            switch (month) {
                case "Januar":
                    monthAsInt = 1;
                    break;
                case "Februar":
                    monthAsInt = 2;
                    break;
                case "Marts":
                    monthAsInt = 3;
                    break;
                case "April":
                    monthAsInt = 4;
                    break;
                case "Maj":
                    monthAsInt = 5;
                    break;
                case "Juni":
                    monthAsInt = 6;
                    break;
                case "Juli":
                    monthAsInt = 7;
                    break;
                case "August":
                    monthAsInt = 8;
                    break;
                case "September":
                    monthAsInt = 9;
                    break;
                case "Oktober":
                    monthAsInt = 10;
                    break;
                case "November":
                    monthAsInt = 11;
                    break;
                case "December":
                    monthAsInt = 12;
                    break;
                default:
                    monthAsInt = -1;
                    break;
            }
            return monthAsInt;
        }
    }
}
