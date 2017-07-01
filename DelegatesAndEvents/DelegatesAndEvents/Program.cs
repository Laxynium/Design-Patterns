using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegatesAndEvents
{
    class Program
    {
        static void Main(string[] args)
        {
            var movie=new Movie{Name="Koty"};
            var videoEncoder=new VideoEncoder();
            var mailService=new MailService();
            var messageService=new MessageService();
            videoEncoder.VideoEncoded += mailService.OnVideoEncoded;
            videoEncoder.VideoEncoded += messageService.OnVideoEncoded;
            videoEncoder.Encode(movie);
        }
    }
}
