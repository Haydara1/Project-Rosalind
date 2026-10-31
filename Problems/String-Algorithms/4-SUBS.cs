// Problem 4: 
// Finding a motif in DNA

string s = Console.ReadLine();
string t = Console.ReadLine();


for (int i = 0; i < s.Length - t.Length; i++)
{
    if (s[i] == t[0])
    {
        string substring = s.Substring(i, t.Length);

        if (substring == t)
        {
            Console.Write(i + 1 + " ");
        }
    }
}
