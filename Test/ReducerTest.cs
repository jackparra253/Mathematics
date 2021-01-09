namespace Test
{
    using Xunit;
    using Domain;
    using System.Collections.Generic;

    public class ReducerTest
    {
        [Fact(DisplayName = "Should Reduce reduction of two or more similar terms of the same sign.")]
        public void Reducer_Case_ReductionPopsitiveSign()
        {
            Term termOne = new Term(3, "a", "1");
            Term termTwo = new Term(2, "a", string.Empty);
            List<Term> terms = new List<Term> { termOne, termTwo };
            Result result = new Result(5, "a");
            Reducer reducer = new Reducer();

            Result reduction = reducer.Reduction(terms);

            Assert.Equal(result.Value, reduction.Value);
            Assert.Equal(result.Constant, reduction.Constant);
        }

        [Fact(DisplayName = "Should Reduce reduction of two or more similar terms of the same sign.")]
        public void Reducer_Case_ReductionNegativeSign()
        {
            Term termOne = new Term(-5, "b", "1");
            Term termTwo = new Term(-7, "b", string.Empty);
            List<Term> terms = new List<Term> { termOne, termTwo };
            Result result = new Result(-12, "b");
            Reducer reducer = new Reducer();

            Result reduction = reducer.Reduction(terms);

            Assert.Equal(result.Value, reduction.Value);
            Assert.Equal(result.Constant, reduction.Constant);
        }

        [Fact(DisplayName = "Should Reduce reduction of two or more similar terms of the same sign.")]
        public void Reducer_Case_ReductionPopsitiveSignMoreTerms()
        {
            Term termOne = new Term(5, "x", "1");
            Term termTwo = new Term(1, "x", string.Empty);
            Term termThree = new Term(2, "x", "1");
            List<Term> terms = new List<Term> { termOne, termTwo, termThree };

            Result result = new Result(8, "x");
            Reducer reducer = new Reducer();

            Result reduction = reducer.Reduction(terms);

            Assert.Equal(result.Value, reduction.Value);
            Assert.Equal(result.Constant, reduction.Constant);
        }
    }
}
