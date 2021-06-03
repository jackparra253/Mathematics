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
            var termOne = new Term(3, "a", "1");
            var termTwo = new Term(2, "a", string.Empty);
            var terms = new List<Term> { termOne, termTwo };
            var result = new Result(5, "a");
            var reducer = new Reducer();

            Result reduction = reducer.Reduction(terms);

            Assert.Equal(result.Value, reduction.Value);
            Assert.Equal(result.Constant, reduction.Constant);
        }

        [Fact(DisplayName = "Should Reduce reduction of two or more similar terms of the same sign.")]
        public void Reducer_Case_ReductionNegativeSign()
        {
            var termOne = new Term(-5, "b", "1");
            var termTwo = new Term(-7, "b", string.Empty);
            var terms = new List<Term> { termOne, termTwo };
            var result = new Result(-12, "b");
            var reducer = new Reducer();

            Result reduction = reducer.Reduction(terms);

            Assert.Equal(result.Value, reduction.Value);
            Assert.Equal(result.Constant, reduction.Constant);
        }

        [Fact(DisplayName = "Should Reduce reduction of two or more similar terms of the same sign.")]
        public void Reducer_Case_ReductionPopsitiveSignMoreTerms()
        {
            var termOne = new Term(5, "x", "1");
            var termTwo = new Term(1, "x", string.Empty);
            var termThree = new Term(2, "x", "1");
            var terms = new List<Term> { termOne, termTwo, termThree };
            var result = new Result(8, "x");
            var reducer = new Reducer();

            Result reduction = reducer.Reduction(terms);

            Assert.Equal(result.Value, reduction.Value);
            Assert.Equal(result.Constant, reduction.Constant);
        }


        [Fact(DisplayName = "Should Reduce reduction of two or more similar terms of the different sign")]
        public void Reducer_Case_ReductionNegativeSignMoreTerms()
        {
            var termOne = new Term(-11, "ab", "1");
            var termTwo = new Term(-15, "ab", "1");
            var termThree = new Term(26, "ab", string.Empty);
            var terms = new List<Term> { termOne, termTwo, termThree };
            var result = new Result(0, "");
            var reducer = new Reducer();

            Result reduction = reducer.Reduction(terms);

            Assert.Equal(result.Value, reduction.Value);
            Assert.Equal(result.Constant, reduction.Constant);
        }
    }
}
