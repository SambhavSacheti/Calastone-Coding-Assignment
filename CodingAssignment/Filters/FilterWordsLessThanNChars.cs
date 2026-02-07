namespace CodingAssignment.Filters;

public class FilterWordsLessThanNChars(int nChars) : IFilter
{
    public bool Filter(string word) =>  word.Length < nChars;
}
