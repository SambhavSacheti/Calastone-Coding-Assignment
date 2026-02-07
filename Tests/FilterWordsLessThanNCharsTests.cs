using CodingAssignment.Filters;

namespace CodingAssesment_Tests;

public class FilterWordsLessThanNCharsTests
{
    [Theory]
    [InlineData("hi", true)]
    [InlineData("the", false)]
    [InlineData("words", false)]
    public void Filter_AppliesLengthBoundary_AsExpected(string word, bool expected)
    {
        var sut = new FilterWordsLessThanNChars(3);

        bool actual = sut.Filter(word);

        Assert.Equal(expected, actual);
    }
}
