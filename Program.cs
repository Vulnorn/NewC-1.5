namespace NewC_1._5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int goldPlayer;
            int crystalPlayer;
            int priceCrystal = 10;

            Console.Write($"Введите Ваше количество золота: ");
            goldPlayer = Convert.ToInt32(Console.ReadLine());

            Console.Write($"Сколько кристалов вы хотите купить? Цена одного {priceCrystal}: ");
            crystalPlayer = Convert.ToInt32(Console.ReadLine());

            goldPlayer = goldPlayer - (crystalPlayer * priceCrystal);

            Console.WriteLine($"У Вас в наличии {crystalPlayer} кристалов и {goldPlayer} золота осталось");
            Console.ReadKey();
        }
    }
}