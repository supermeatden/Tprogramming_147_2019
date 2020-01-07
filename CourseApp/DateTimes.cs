using System;

namespace CourseApp
{
    public class DateTimes
    {
        public string CulculateAge(int year, int month, int day)
        {
            DateTime dateBirthDay = new DateTime(year, month, day);
            DateTime dateNow = DateTime.Now;
            var age = new DateTime(dateNow.Ticks - dateBirthDay.Ticks);
            if (dateNow.Ticks < dateBirthDay.Ticks)
            {
                throw new Exception("я того рот ебал, не тo!!!");
            }
            else if (dateNow.Ticks < dateBirthDay.Ticks)
            {
                throw new Exception("ты еблан, поздравляю !");
            }

             return $"Возраст = {age.Year - 1} лет {age.Month - 1} месяцев {age.Day - 1} дней";
        }

        public string CulculateAge(int year, int month, int day, int toyear, int tomonth, int today, bool fullAge)
        {
            DateTime dateBirthDay = new DateTime(year, month, day);
            DateTime dateNow = new DateTime(toyear, tomonth, today);
            var age = new DateTime(dateNow.Ticks - dateBirthDay.Ticks);
            if (dateNow.Ticks < dateBirthDay.Ticks)
            {
                throw new Exception("you cannot enter a date thet did not occur");
            }
            else if (dateNow.Ticks < dateBirthDay.Ticks)
            {
                throw new Exception("You was born today");
            }
            else
            {
                if (fullAge == true)
                {
                    return $"Возраст = {age.Year - 1} лет {age.Month - 1} месяцев {age.Day - 1} дней";
                }
                else
                {
                    return $"Возраст = {age.Year - 1} лет";
                }
            }
        }
    }
}