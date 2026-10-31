// Problem 1:
// Counting point mutations

string s = Console.ReadLine();
string t = Console.ReadLine();

int distance = 0;

for (int i = 0; i < s.Length; i++)
{
    if (s[i] != t[i])
    {
        distance++;
    }
}

Console.WriteLine(distance);
