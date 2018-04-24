using System;

namespace Postcode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please Write your postcode");
            string postcode = Console.ReadLine().ToLower();
            var apiCall = new PostCodeApiCalls();          
            var returnPostcodeResults = apiCall.GetPostCodeDetails(postcode);

            Console.WriteLine(returnPostcodeResults);

            Console.ReadLine();
        }
    }
}
