namespace Domain
{
    using System.Collections.Generic;
    using System.Linq;

    public class Reducer
    {
        public Result Result { get; private set; }

        public Result Reduction(List<Term> terms)
        {
            int i = 0;
            int value = 0;
            string constant = "";
            for (i = 0; i < terms.Count; i++)
            {
                value += terms[i].Value;
            }

            Result result = new Result(value, terms.FirstOrDefault().Constant);

            return result;
        }
    }
}