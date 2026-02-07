using System.Text;
using CodingAssignment.Filters;

IFilter[] filters =
[
    new FilterWordsLessThanNChars(3),
    new FilterWithSingleLetter('t', StringComparison.OrdinalIgnoreCase),
    new RemoveWordsWithFilter(['a', 'e', 'i', 'o', 'u'])
];
string filePath = Path.Combine(AppContext.BaseDirectory, "Input", "Input.txt");
using StreamReader fileReader = new (filePath);
string? line;

while ((line = fileReader.ReadLine()) != null)
{
    StringBuilder word = new();
    foreach (char ch in line)
    {
        if (char.IsLetter(ch))
        {
            word.Append(ch);
        }
        else
        {
            WriteWordIfNotFiltered(word);
            Console.Write(ch);
        }
    }
    WriteWordIfNotFiltered(word);
    Console.WriteLine();
}


void WriteWordIfNotFiltered(StringBuilder word)
{
    if (word.Length == 0)
        return;

    string wordStr = word.ToString();
    foreach (var filter in filters)
    {
        if (filter.Filter(wordStr))
        {
            word.Clear();
            return;
        }
    }

    Console.Write(wordStr);
    word.Clear();
}





