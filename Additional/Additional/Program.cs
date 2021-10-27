using System;
using System.Collections.Generic;

namespace Additional
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Enum iterate

            //Console.WriteLine($"1 - {WeekDay.Monday}, 2 - {WeekDay.Tuesday}");

            //GetWeekDays();

            //foreach (var item in GetWeekDays())
            //{
            //    Console.Write(item + " ");
            //}

            #endregion

            #region TypeOf, NameOf

            //Console.WriteLine(typeof(WeekDay));

            //Console.WriteLine(typeof(Person));

            //var person = new Person();
            //Console.WriteLine(person.GetType());

            //Console.WriteLine("Age");
            //Console.WriteLine(nameof(Person.Age));

            #endregion

            #region DateTime

            DateTime now = DateTime.Now;
            DateTime today = DateTime.Today;
            DateTime utc = DateTime.UtcNow;

            //Console.WriteLine("Now: " + now);
            //Console.WriteLine("Today: " + today);
            //Console.WriteLine("Utc: " + utc);

            //Console.WriteLine("ToLongDateString: " + today.ToLongDateString());
            //Console.WriteLine("ToShortDateString: " + today.ToShortDateString());
            //Console.WriteLine("ToLongTimeString: " + today.ToLongTimeString());
            //Console.WriteLine("ToShortTimeString: " + today.ToShortTimeString());

            //Console.WriteLine("ToString: " + today.ToString("dd-MM-yyyy"));

            //DateTime yesterday = DateTime.Today.AddDays(-1);
            //Console.WriteLine(yesterday);

            //var difference = today - yesterday;
            //Console.WriteLine(difference);

            //DateTimeOffset dateTimeOffset = DateTimeOffset.FromUnixTimeSeconds(1635353262);
            //Console.WriteLine(dateTimeOffset);

            //DateTime dateTime = DateTime.MinValue;
            //DateTime dateTime2 = DateTime.MaxValue;

            //Console.WriteLine(dateTime);
            //Console.WriteLine(dateTime2);

            #endregion

            #region GUID

            //Guid id = Guid.NewGuid();
            //Guid empty = Guid.Empty;
            //Console.WriteLine(id);
            //Console.WriteLine(empty);

            #endregion
        }

        static IEnumerable<string> GetWeekDays()
        {
            foreach (var item in Enum.GetValues(typeof(WeekDay)))
            {
                yield return $"{(int)item} - {item}";
            }
        }

        //static List<string> GetWeekDays()
        //{
        //    List<string> weekDays = new List<string>();

        //    foreach (var item in Enum.GetValues(typeof(WeekDay)))
        //    {
        //        //weekDays.Add(item.ToString());
        //        weekDays.Add($"{(int)item} - {item}");
        //    }

        //    return weekDays;
        //}
    }

    class Person
    {
        public int Age { get; set; }
    }

    enum WeekDay
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
}
