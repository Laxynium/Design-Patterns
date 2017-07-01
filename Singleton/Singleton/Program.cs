using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random=new Random();

            RegisterOfEvents.GetInstance().EnableImmediateSaving(false);
            for (int i = 0; i < 10; ++i)
            {
                int randomNumber = random.Next();
                RegisterOfEvents.GetInstance().AddEvent("Random number:"+randomNumber.ToString());
            }
            RegisterOfEvents.GetInstance().Save();

        }
    }
}
