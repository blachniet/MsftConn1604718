using System;

namespace MsftConn1604718
{
    class Program
    {
        static void Main(string[] args)
        {

            var mail = new System.Net.Mail.MailMessage();
            mail.Headers.Add("foo", "bar");

            try
            {
                Console.WriteLine("Trying empty string in 'name'");
                mail.Headers.Add(string.Empty, "bar");
            }
            catch (ArgumentException ex)
            {
                // This one is ok.
                Console.WriteLine("Expect ArgumentException with ParamName 'name': '{0}'", ex.ParamName);
            }

            try
            {
                Console.WriteLine("Trying empty string in 'value'");
                mail.Headers.Add("foo", string.Empty);
            }
            catch (ArgumentException ex)
            {
                // This one is not ok. ParamName should be 'value', but it is actually 'name'.
                Console.WriteLine("Expect ArgumentException with ParamName 'value': '{0}'", ex.ParamName);
            }

            Console.ReadKey();
        }
    }
}
