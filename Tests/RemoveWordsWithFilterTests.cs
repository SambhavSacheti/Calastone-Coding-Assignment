using CodingAssignment.Filters;

namespace CodingAssesment_Tests;

public class RemoveWordsWithFilterTests
{
    private static readonly char[] Vowels = ['a', 'e', 'i', 'o', 'u'];

    [Theory]
    [InlineData("clean", true)]
    [InlineData("what", true)]
    [InlineData("currently", true)]
    [InlineData("the", false)]
    [InlineData("rather", false)]
    public void Filter_MatchesAssignmentExamples(string word, bool expected)
    {
        var sut = new RemoveWordsWithFilter(Vowels);

        bool actual = sut.Filter(word);

        Assert.Equal(expected, actual);
    }

    [Fact]
    public void Filter_ReturnsFalse_ForEvenLengthWord_WithNoMiddleVowel()
    {
        var sut = new RemoveWordsWithFilter(Vowels);

        bool actual = sut.Filter("brrr");

        Assert.False(actual);
    }
}


