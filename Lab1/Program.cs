using System;

class Slovo
{
    private string word;

    public void Input()
    {
        Console.Write("Введіть слово: ");
        word = Console.ReadLine();
    }

    public int CountDigits()
    {
        int count = 0;
        foreach (char c in word)
        {
            if (char.IsDigit(c))
                count++;
        }
        return count;
    }
}

class Program
{
    static void Main()
    {
        Slovo slovo = new Slovo();
        slovo.Input();
        int digits = slovo.CountDigits();
        Console.WriteLine($"Кількість цифр у слові: {digits}");
    }
}