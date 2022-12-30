internal class Program
{
    private static void Main(string[] args)
    {
        int num1, num2;
        bool flag = true;






        Console.Write("Enter start number: ");
        num1 = int.Parse(Console.ReadLine());
        Console.Write("Enter end number: ");
        num2 = int.Parse(Console.ReadLine());


        for (int i = num1; i <= num2; i++)
        {
            for (int j = 2; j <= Math.Sqrt(i); j++)
            {
                if (i % j == 0)
                    flag = false;
            }
            if (flag == true && i != 1)
            {

                Console.WriteLine(i);

            }
            flag = true;
        }



        Console.ReadKey();
    }
}