namespace Interpreter
{
    public partial class InterpreterOfRomanNumericSystem
    {
        private partial class InterpreterOfUnits
        {
            public InterpreterOfUnits() : base(0)
            { }
            protected override char One() => 'I';

            protected override char[] Four() => "IV".ToCharArray();

            protected override char Five() => 'V';

            protected override char[] Nine() => "IX".ToCharArray();

            protected override int Multiplayer() => 1;
        }
    }
}