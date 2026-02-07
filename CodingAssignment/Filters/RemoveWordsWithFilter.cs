namespace CodingAssignment.Filters;

public class RemoveWordsWithFilter(char[] removeWordsWithCharList) : IFilter
{
    private readonly HashSet<char> _removeWordsWithCharList = [.. removeWordsWithCharList];
    public bool Filter(string word)
    {
        int length = word.Length;
        int middleIndex = length / 2;
        // Check for odd length words
        if (length % 2 != 0)
        {
            char middleChar = char.ToLower(word[middleIndex]);
            return IsCharInRemoveWordsWithCharList(middleChar);
        }
        else // Check for even length words
        {
            char middleChar1 = char.ToLower(word[middleIndex - 1]);
            char middleChar2 = char.ToLower(word[middleIndex]);
            return IsCharInRemoveWordsWithCharList(middleChar1) || IsCharInRemoveWordsWithCharList(middleChar2);
        }
    }

    private bool IsCharInRemoveWordsWithCharList(char middleChar) => _removeWordsWithCharList.Contains(middleChar);   
}
