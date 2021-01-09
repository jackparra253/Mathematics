namespace Domain
{
    public class Result
    {
        public Result(int value, string constant)
        {
            Value = value;
            Constant = constant;
        }

        public int Value { get; private set; }
        public string Constant { get; private set; }
    }
}