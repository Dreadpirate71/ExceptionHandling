using System;
using System.Net;

namespace Exception_Handling_Exercise_13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string urlOne = "https://introprogramming.info/wp-content/uploads/2017/08/csharp-book-nakov-en-v2013-cover.jpg";
            string urlTwo = "http://introprogramming.info/wp-content/themes/introprograming_en/images/Intro-Csharp-Book-front-cover-big_en.png";
            using var client = new WebClient();
            {
                client.DownloadFile(urlOne, "C:\\Users\\James.Remus\\OneDrive - Veterans United Home Loans\\Documents\\Code VU\\git\\Exception Handling\\Exception Handling Exercise 13\\Cover.jpg");
              
                try
                {
                    client.DownloadFile(urlTwo, "coverBig.png");
                }
                catch (System.Net.WebException)
                {
                    Console.WriteLine("File Not Found");
                }
            }

        }
    }
}
