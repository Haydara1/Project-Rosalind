// Problem 1: 
// Counting DNA Nucleotides.

string s = Console.ReadLine();

int A = 0, G = 0, C = 0, T = 0;

foreach (char c in s)
{
    switch (c)
    {
        case 'G':
            G++;
            break;
        case 'T':
            T++;
            break;
        case 'A':
            A++;
            break;
        case 'C':
            C++;
            break;
    }
}

Console.WriteLine(A + " " + C + " " + G + " " + T);

// Answer: 224 204 224 252
