using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Seconds
{
    internal class Program
    {
        //ask user for seconds
        static int Seconds()
        {   
            int seconds = 0;
            WriteLine("Please input the amount of seconds: ");
            seconds = int.Parse(ReadLine());
            return seconds;
        }

        //return the value in seconds
        static double ConvertToSeconds(int seconds)
        {
            if (seconds < 59)
            {
                return seconds;
            }
            else
            {
                return seconds % 60;
            }

        }

        //return the value in minutes
        static double ConvertToMinutes(int seconds)
        {
            double minutes = 0;
            minutes = seconds / 60.0;
            if(minutes < 59)
            {
                return (int)minutes;
            }
            else
            {
                return (int)minutes % 60; 
            }
        }

        //return the value in hours
        static double ConvertToHours(int seconds)
        {
            double hours = 0;
            hours = seconds / 3600.0;
            return (int)hours;
        }

        

        static void Main(string[] args)
        {
            int secondsbyUser = 0;
            double minutes = 0;
            double hours = 0;
            double seconds = 0;

            secondsbyUser = Seconds();
            WriteLine("You have entered " + secondsbyUser + " Seconds");

            //calculate seconds, minutes and hours
            hours = ConvertToHours(secondsbyUser);                               
            minutes = ConvertToMinutes(secondsbyUser);    
            seconds = ConvertToSeconds(secondsbyUser);
            
            //evaluate input and display results
            if (secondsbyUser < 60)
            {
                hours = 0;
                minutes = 0;
                WriteLine("You enterded: " + hours + "H:" + minutes + "M:" +  secondsbyUser + "S");
            } else if (minutes < 60 && hours < 1 )
            {
                hours = 0;
                WriteLine("You enterded: " + hours + "H:" + minutes + "M:" + seconds + "S");
            } else if (hours >= 1)
            {
                WriteLine("You enterded: " + hours + "H:" + minutes + "M:" + seconds + "S");
            }
            ReadKey();
            
        }
    }
}
