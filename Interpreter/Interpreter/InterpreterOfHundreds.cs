using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public partial class InterpreterOfRomanNumericSystem
    {
        private partial class InterpreterOfHundreds : InterpreterOfRomanNumericSystem
        {
            public InterpreterOfHundreds() : base(0)
            { }
            protected override char One() => 'C';

            protected override char[] Four() => "CD".ToCharArray();

            protected override char Five() => 'D';

            protected override char[] Nine() => "CM".ToCharArray();

            protected override int Multiplayer() => 100;
        }
    }   
}
