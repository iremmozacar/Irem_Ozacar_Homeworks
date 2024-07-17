namespace Homework1_13;

class Program
{
    static void Main(string[] args)
    {
        //13.Bir string içindeki sesli harfleri sayan bir program yazınız.
        string text = "En karanlık gece bile sona erer ve güneş tekrar doğar!";
        int sesliHarfSayisi = 0;
        text = text.ToLower();

        string sesliHarfler = "aeıiuüoö";

        foreach (char karakter in text)
        {
            if (sesliHarfler.Contains(karakter))
                sesliHarfSayisi++;
        }
        Console.WriteLine($" ''{text}'' metninde '{sesliHarfSayisi}' adet sesli harf var.");
    }
}
