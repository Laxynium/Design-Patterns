using System;
namespace DelegatesAndEvents
{
    public class MovieEventArgs:EventArgs
    {
        public Movie Movie { get; set; }
    }
}