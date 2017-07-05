using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
   public  partial class InterpreterOfRomanNumericSystem
    {
        private partial class InterpreterOfThousands : InterpreterOfRomanNumericSystem
        {
            public InterpreterOfThousands() : base(0)
            { }

            protected override char One() => 'M';

            protected override char[] Four() => "".ToCharArray();

            protected override char Five() => '\0';

            protected override char[] Nine() => "".ToCharArray();

            protected override int Multiplayer() => 1000;
        }
    }
   
}
