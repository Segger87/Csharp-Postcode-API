using System;

namespace Postcode
{
    class Program
    {
        static void Main(string[] args)
        {

            string postcode = "";

            while (string.IsNullOrEmpty(postcode) || postcode.Length > 8)
            {
                Console.WriteLine("Please Write your postcode");
                postcode = Console.ReadLine().ToLower();
            }
            var apiCall = new PostCodeApiCalls();
            var returnPostcodeResults = apiCall.GetPostCodeDetails(postcode);

            Console.WriteLine(returnPostcodeResults);

            Console.ReadLine();
        }
    }
}
