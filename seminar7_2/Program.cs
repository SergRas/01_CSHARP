// Считать строку с консоли, содержащую латинские буквы.
// Вывести на экран согласные буквы этой строки.

void Consonants(string s)
{
    if (s.Length == 0) return;
    string st = "aoueyi";
    if (st.Contains(s[0]) == false) Console.Write($"{s[0]}");
    Consonants(s[1..]);
}

void Consonants2(string s, int i = 0)
{

    string st = "aoueyi";
    if (i == s.Length) return;
    if (st.Contains(s[i]) == false) Console.Write($"{s[i]}");
    Consonants2(s, i + 1);
}


string st = Console.ReadLine()!;
Consonants(st);
Console.WriteLine();
Consonants2(st);