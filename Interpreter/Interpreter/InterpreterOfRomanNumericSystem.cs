using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Interpreter
{
    public partial class InterpreterOfRomanNumericSystem
    {
        protected virtual void Interpret(ref string romanNumber,ref int value)
        {
            if (romanNumber.Length == 0) return;

            int index = 0;

            int romanNumberLength = romanNumber.Length;
            string firstTwoChars=null;
            if (romanNumberLength>=2)
            firstTwoChars = romanNumber.Substring(0, 2);

            if (romanNumberLength >= 2&&firstTwoChars.Equals(new string(Nine())))
            {
                value += 9 * Multiplayer();
                index += 2;
            }else if (romanNumberLength >= 2 && firstTwoChars.Equals(new string(Four())))
            {
                value += 4 * Multiplayer();
                index += 2;
            }
            else
            {
                if (romanNumber[0] == Five())
                {
                    value += 5 * Multiplayer();
                    index = 1;
                }
                else index = 0;
                for (int end = romanNumberLength; index < end; index++)
                {
                    if (romanNumber[index] == One())
                        value += 1 * Multiplayer();
                    else break;
                }
            }
            romanNumber = romanNumber.Substring(index);

        }

        protected virtual char One()=> '\0';

        protected virtual char[] Four() => "\0".ToCharArray();

        protected virtual char Five() => '\0';

        protected virtual char[]Nine()=> "\0".ToCharArray();

        protected virtual int Multiplayer()=>0;

        private readonly InterpreterOfRomanNumericSystem _interpreterOfThousands;
        private readonly InterpreterOfRomanNumericSystem _interpreterOfHundreds;
        private readonly InterpreterOfRomanNumericSystem _interpreterOfTens;
        private readonly InterpreterOfRomanNumericSystem _interpreterOfUnits;

        //used to do not create new instances of InterpreterOfRomanNumericSystem
        protected InterpreterOfRomanNumericSystem(int arg)
        { }
        private partial class InterpreterOfThousands : InterpreterOfRomanNumericSystem
        {}

        private partial class InterpreterOfHundreds : InterpreterOfRomanNumericSystem
        {}
        private partial class InterpreterOfTens : InterpreterOfRomanNumericSystem
        {}
        private partial class InterpreterOfUnits : InterpreterOfRomanNumericSystem
        {}

        public InterpreterOfRomanNumericSystem()
        {
            _interpreterOfThousands = new InterpreterOfThousands();
            _interpreterOfHundreds = new InterpreterOfHundreds();
            _interpreterOfTens = new InterpreterOfTens();
            _interpreterOfUnits = new InterpreterOfUnits();
        }
        public int Interpret(string romanNumber)
        {
            
            int value = 0;
            _interpreterOfThousands.Interpret(ref romanNumber, ref value);
            _interpreterOfHundreds.Interpret(ref romanNumber, ref value);
            _interpreterOfTens.Interpret(ref romanNumber, ref value);
            _interpreterOfUnits.Interpret(ref romanNumber, ref value);

            if (!string.IsNullOrEmpty(romanNumber))
                throw new ArgumentException("The number is not correct.");

            return value;
        }
    }



}
