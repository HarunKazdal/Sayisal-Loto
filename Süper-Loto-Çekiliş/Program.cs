namespace Süper_Loto_Çekiliş
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SayisalLotoProgram();
        }
        static void SayisalLotoProgram()
        {

            // Sayısal Loto oyunu: 
            
            Console.WriteLine("Lütfen 1 ile 49 arasında 6 adet farklı sayı giriniz:");
            int[] kupon = new int[6];
            for (int i = 0; i < kupon.Length; i++)
            {
                Console.Write((i + 1) + ". Sayı: ");
                kupon[i] = Convert.ToInt32(Console.ReadLine());
            }
            
            int[] cekilis = new int[6];
            Random rnd = new Random();
            for (int i = 0; i < cekilis.Length; i++)
            {
                cekilis[i] = rnd.Next(1, 6);
                Console.Write(cekilis[i] + " ");
            }
            
            int bilinen = 0;
            string pano = "";
            for (int i = 0; i < kupon.Length; i++)
            {
                for (int j = 0; j < cekilis.Length; j++)
                {
                    if (kupon[i] == cekilis[j])
                    {
                        bilinen++;
                        pano += cekilis[j] + " ";
                        break;
                    }
                }
            }

             
            if (bilinen < 3)
            {
                Console.WriteLine("Kazanamadınız.");
            }
            else
            {
                Console.WriteLine("Tebrikler, {bilinen} adet sayı bildiniz.");
            }

            
            Console.WriteLine("Bilinen sayılar " + pano);


        }
    }
}
