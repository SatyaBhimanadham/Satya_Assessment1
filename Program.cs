namespace Assesment_1_Satya
{
    internal class Program
    {

        static void Main(string[] args)
        {
            static void Main()
            {
                try
                {
                    int[,] arr = new int[3, 3];
                    int c = 0;
                    arr[0, 0] = 1;
                    arr[0, 1] = 2;
                    arr[0, 2] = 3;
                    arr[1, 0] = 4;
                    arr[1, 1] = 5;
                    arr[1, 2] = 6;
                    arr[2, 0] = 7;
                    arr[2, 1] = 8;
                    arr[2, 2] = 9;
                    foreach (int i in arr)
                    {
                        c++;
                        Console.Write(i + " ");
                    }

                    if (c % 3 == 0)
                    {
                        Console.WriteLine();
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


            }
        }
}
