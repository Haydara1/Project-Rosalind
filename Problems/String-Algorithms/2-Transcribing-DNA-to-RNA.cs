// Problem 2:
// Transcribing DNA to RNA.

string s = ""; // Insert from the dataset.

string output = "";

foreach (char c in s)
{
    if (c == 'T')
    {
        output += 'U';
        continue;
    }
    
    output += c;
}

Console.WriteLine(output);
