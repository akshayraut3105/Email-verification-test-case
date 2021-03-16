using System;
using System.Text.RegularExpressions;

namespace Emial_regex
{
    public class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("Enter Your Email Address");
            string Email = Console.ReadLine();
            Program.EMAIL_VERIFICATION(Email);


        }
        public static bool EMAIL_VERIFICATION(string email)
        {
            string REGEX_EMAIL = @"^[0-9A-Za-z]+([._+-][0-9A-Za-z]+)*[@][0-9A-Za-z]+.[a-zA-Z]{2,3}(.[a-zA-Z]{2,3})?$";
            var Result = Regex.IsMatch(email, REGEX_EMAIL);
            return Result;
        }
    }
}