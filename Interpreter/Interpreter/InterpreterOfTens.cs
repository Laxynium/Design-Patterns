namespace Interpreter
{
    public partial class InterpreterOfRomanNumericSystem
    {
        private partial class InterpreterOfTens:InterpreterOfRomanNumericSystem
        {
            public InterpreterOfTens():
                base(0)
            { }
            protected override char One() => 'X';

            protected override char[] Four() => "XL".ToCharArray();

            protected override char Five() => 'L';

            protected override char[] Nine() => "XC".ToCharArray();

            protected override int Multiplayer() => 10;

        }
    }
}