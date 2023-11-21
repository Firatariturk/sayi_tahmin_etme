
Random rnd = new Random();
int sayi = rnd.Next(1, 101);
int tahmin = 101;
//Console.WriteLine(sayi);
Console.WriteLine("bir sayi girin");
while (sayi != tahmin)
{
    tahmin = Convert.ToInt32(Console.ReadLine());
    if (sayi == tahmin) { Console.WriteLine("tebrikler sayi " + sayi +"'idi."); }
    else
    {
        if (tahmin < sayi)
        {
            if (sayi - tahmin < 6)
            {
                Console.WriteLine("cok sicak");
            }
            else if (sayi - tahmin < 11)
            {
                Console.WriteLine("sicak");
            }
            else if (sayi - tahmin < 21)
            {
                Console.WriteLine("soguk");
            }
            else if (sayi - tahmin > 20)
            {
                Console.WriteLine("cok soguk");
            }
        }
        else
        {
            if ((sayi - tahmin) * -1 < 6)
            {
                Console.WriteLine("cok sicak");
            }
            else if ((sayi - tahmin) * -1 < 11)
            {
                Console.WriteLine("sicak");
            }
            else if ((sayi - tahmin) * -1 < 21)
            {
                Console.WriteLine("soguk");
            }
            else if ((sayi - tahmin) * -1 > 20)
            {
                Console.WriteLine("cok soguk");
            }
        }
    }
}