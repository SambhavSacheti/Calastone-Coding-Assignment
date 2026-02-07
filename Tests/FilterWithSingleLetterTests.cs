using CodingAssignment.Filters;

namespace CodingAssesment_Tests;

public class FilterWithSingleLetterTests
{
    [Fact]
    public void Filter_ReturnsTrue_WhenLetterExists_WithOrdinalIgnoreCase()
    {
        var sut = new FilterWithSingleLetter('t', StringComparison.OrdinalIgnoreCase);

        bool actual = sut.Filter("CaT");

        Assert.True(actual);
    }

    [Fact]
    public void Filter_ReturnsFalse_WhenLetterDoesNotExist()
    {
        var sut = new FilterWithSingleLetter('t', StringComparison.OrdinalIgnoreCase);

        bool actual = sut.Filter("clean");

        Assert.False(actual);
    }

    [Fact]
    public void Filter_RespectsCase_WhenUsingOrdinalComparison()
    {
        var sut = new FilterWithSingleLetter('T', StringComparison.Ordinal);

        bool actual = sut.Filter("cat");

        Assert.False(actual);
    }
}
