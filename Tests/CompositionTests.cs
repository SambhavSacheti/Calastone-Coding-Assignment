using CodingAssignment.Filters;
using System;
using System.Collections.Generic;
using System.Text;

namespace CodingAssesment_Tests;

public class FilterCompositionTests
{
    [Fact]
    public void Filters_AppliedInProgramOrder_RemoveExpectedWords()
    {
        Func<string, bool>[] filters =
        [
            new FilterWordsLessThanNChars(3).Filter,
            new FilterWithSingleLetter('t', StringComparison.OrdinalIgnoreCase).Filter,
            new RemoveWordsWithFilter(['a', 'e', 'i', 'o', 'u']).Filter
        ];

        string[] words = ["go", "tap", "clean", "sky", "brrr"];

        string[] result = words.Where(word => !filters.Any(filter => filter(word))).ToArray();

        Assert.Equal(["sky", "brrr"], result);
    }
}
