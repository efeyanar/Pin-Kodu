internal class Program
{
    private static void Main(string[] args)
    {
        int pin = 1881;
        int hak = 3;

    tepe:
        try
        {
            Console.Write("Pin Kodunu Giriniz : ");
            int pinDeneme = Convert.ToInt32(Console.ReadLine());

            if (pinDeneme == pin)
            {
                Console.WriteLine("Pin Kodu Doğru.");
                
            }
            else
            {
                hak--;
            }

            if (hak == 0)
            {
                Console.WriteLine("Hakkınız Bitmiştir. Telefon Kapatılıyor...");
            }
            else if (hak != 0 && pinDeneme == pin)
            {
                Console.WriteLine("Hoşgeldiniz...");
            }
            else if (hak != 0 && pinDeneme!=pin)
            {
                Console.WriteLine(hak + " Hakkınız Kaldı.");
                goto tepe;
            }
        
            
        }
        catch (Exception ex)
        {
            Console.WriteLine("Bilgileri Doğru Girdiğinizden Emin Olunuz.");
            goto tepe;
        }
        Console.ReadKey();
    }
}