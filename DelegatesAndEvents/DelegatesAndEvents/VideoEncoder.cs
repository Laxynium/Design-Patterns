using System;

namespace DelegatesAndEvents
{
    class VideoEncoder
    {
        public EventHandler<MovieEventArgs> VideoEncoded;
        public void Encode(Movie movie)
        {
            Console.WriteLine("Encoding movie...");
            System.Threading.Thread.Sleep(3000);

            OnVideoEncoded(movie);
        }

        protected void OnVideoEncoded(Movie movie)
        {
            if (VideoEncoded != null)
                VideoEncoded(this,new MovieEventArgs(){Movie =movie});
        }
    }
}