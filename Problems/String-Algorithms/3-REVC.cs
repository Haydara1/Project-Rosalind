// Problem 3:
// Complementing a strand of DNA:

string input = Console.ReadLine();

string output = "";

foreach (char c in input)
{
    switch (c)
    {
        case 'A':
            output += 'T';
            break;
        case 'T':
            output += 'A';
            break;
        case 'G':
            output += 'C';
            break;
        case 'C':
            output += 'G';
            break;
    }
}

// Define a function to revers the string.
string Reverse( string s )
{
    char[] charArray = s.ToCharArray();
    Array.Reverse(charArray);
    return new string(charArray);
}

output = Reverse(output);

Console.WriteLine(output);
