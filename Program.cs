using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Program
    {
        public class Person
        {

            public string FirstName
            {
                get { return FirstName; }
                set { FirstName = value; }
            }
            public string LastName
            {
                get { return LastName; }
                set { LastName = value; }
            }
            public int Age
            {
                get { return Age; }
                set { Age = value; }
            }
            public string GetFullName()
            {
                return FirstName;
                return LastName;
            }
            public void DisplayInfo()
            {
                Console.WriteLine(FirstName + " " + LastName);
                Console.WriteLine("Age: " + Age);
            }
            public bool IsAdult()
            {
                bool person = false;
                if (Age >= 18)
                {
                    return true;

                }
                else
                {
                    return false;
                }
            }
            public void HaveBirthday()
            {
                Age++;
            }
        }


        static void Main(string[] args)
        {
            //qweqweqweqweqw
        }
        

    }
}
