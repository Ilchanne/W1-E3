class Program
{
    static void Main(string[] args)
    {
        Random rnd = new Random();
        int[] a = new int[rnd.Next(1, 100 + 1)];
        for (int i = 0; i < a.Length; i++)
        {
            a[i] = rnd.Next(1, 100 + 1);
        }
        Sort(a);
        Console.WriteLine("Введите к");
        int k = Convert.ToInt32(Console.ReadLine());
        int k1 = a.Length - k;
        for (int i = a.Length - 1; i > k1 - 1; i--)
        {
            Console.Write(a[i] + " ");
        }


        Console.ReadKey();
    }
    static void Sort(int[] Array)
    {
        for (int i = 0; i < Array.Length; i++)
        {
            for (int j = 0; j < Array.Length - 1; j++)
            {
                if (Array[j] > Array[j + 1])
                {
                    int temp = Array[j];
                    Array[j] = Array[j + 1];
                    Array[j + 1] = temp;
                }
            }
        }
    }
}