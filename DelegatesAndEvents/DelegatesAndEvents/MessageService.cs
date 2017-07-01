using System;

namespace DelegatesAndEvents
{
    public class MessageService
    {
        public void OnVideoEncoded(object obj, MovieEventArgs args)
        {
            Console.WriteLine("Sending message..." + args.Movie.Name);
        }
    }
}