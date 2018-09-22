using System;
using System.Collections.Generic;
using System.Text;

namespace URLEncoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<char, string> substitute = new Dictionary<char, string>()
            {
                {'>' , "%3E"},
                {'<' , "%3C"},
                {'#' , "%23"},
                {'%' , "%25"},
                {'"' , "%22"},

                {' ' , "%20"},
                {';' , "%3B"},
                {'/' , "%2F"},
                {'?' , "%3F"},
                {':' , "%3A"},
                {'@' , "%40"},
                {'&' , "%26"},
                {'=' , "%3D"},
                {'+' , "%2B"},
                {'$' , "%24"},
                {',' , "%2C"},

                {'{' , "%7B"},
                {'}' , "%7D"},
                {'|' , "%7C"},
                {'\\' , "%5C"},
                {'^' , "%5E"},
                {'[' , "%5B"},
                {']' , "%5D"},
                {'`' , "%60"}

            };



            Console.WriteLine("Write Project Name: ");
            string name = Console.ReadLine();
            Console.WriteLine("\nWrite Activity Name: ");
            string activity = Console.ReadLine();
            


            StringBuilder convertedName = new StringBuilder();
            foreach(char c in name)
            {
                
                if(substitute.ContainsKey(c))
                {
                    convertedName.Append(substitute[c]);
                }
                else
                {
                    convertedName.Append(c);
                }
            }

            StringBuilder convertedActivity = new StringBuilder();
            foreach (char c in activity)
            {

                if (substitute.ContainsKey(c))
                {
                    convertedActivity.Append(substitute[c]);
                }
                else
                {
                    convertedActivity.Append(c);
                }
            }

            Console.WriteLine("\nYour encoded URL is: \nhttps://companyserver.com/content/{0}/files/{1}/{1}Report.pdf", convertedName, convertedActivity);


        }
    }
}
