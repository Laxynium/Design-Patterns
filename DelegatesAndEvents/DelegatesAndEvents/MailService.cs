using System;

namespace DelegatesAndEvents
{
    class MailService
    {
        public void OnVideoEncoded(object obj, MovieEventArgs args)
        {
            Console.WriteLine("Sending mail..." +args.Movie.Name);
        }
    }
}
