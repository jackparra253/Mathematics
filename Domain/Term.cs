namespace Domain
{
    public class Term
    {
        public Term(int value, string constant, string exponent)
        {
            Value = value;
            Constant = constant;
            Exponent = exponent;
        }

        public int Value { get; private set; }
        public string Constant { get; private set; }
        public string Exponent { get; private set; }
    }
}