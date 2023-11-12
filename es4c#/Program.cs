Console.WriteLine("Inserisci del testo:");
string? inputText = Console.ReadLine();

string reversedText = ReverseText(inputText);

Console.WriteLine($"Testo al contrario: {reversedText}");

    static string ReverseText(string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }