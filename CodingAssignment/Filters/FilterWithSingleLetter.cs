namespace CodingAssignment.Filters;

public class FilterWithSingleLetter(char letter, StringComparison stringComparison) : IFilter
{
    public bool Filter(string word) => word.Contains(letter, stringComparison);
}
