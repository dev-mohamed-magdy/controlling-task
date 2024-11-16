namespace ControllingTask
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>();
            int value = 0;

            do
            {
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number ");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest numbers");
                Console.WriteLine("F - Finde a number");
                Console.WriteLine("Q - Quit");

                char choice = Convert.ToChar(Console.ReadLine().ToUpper());

                switch (choice)
                {
                    case 'P':
                        if(numbers.Count == 0)
                        {
                            Console.WriteLine("No ddata is found !");
                        }
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < numbers.Count; i++)
                            {
                                Console.Write(numbers[i] + " ");
                            }
                            Console.Write("]");
                        }
                        break;
                    case 'A':
                        Console.Write("Select how mane numbers you want to add ?");
                        int count = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine(count);
                        for(int i = 0; i < count; i++)
                        {
                            int selection = Convert.ToInt32(Console.ReadLine());
                            numbers.Add(selection);
                        }
                        break;
                    case 'M':
                        value = numbers[0];
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            value += numbers[i];
                        }
                        double avg = value / numbers.Count;
                        Console.WriteLine(avg);
                        break;
                    case 'S':
                        value = numbers[0];
                        for(int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] < value)
                            {
                                value = numbers[i];
                                Console.WriteLine(value);
                            }
                        }
                        break;
                    case 'L':
                        value = numbers[0];
                        for (int i = 0; i < numbers.Count; i++)
                        {
                            if (numbers[i] > value)
                            {
                                value = numbers[i];
                                Console.WriteLine(value);
                            }
                        }
                        break;
                    case 'F':
                        Console.Write("Search ...");
                        int search = Convert.ToInt32(Console.ReadLine());
                        if(numbers.Count > 1)
                        {
                            for(int i = 0; i < numbers.Count; i++)
                            {
                                if(numbers[i] == search)
                                {
                                    Console.WriteLine($"It was found in the index {i}");
                                }
                            }
                        }
                        else
                        {
                            Console.WriteLine("No data found");
                        }
                        break;
                    case 'Q':
                        Console.WriteLine("Quit");
                        break;
                    default:
                        Console.WriteLine("Opration not exsist");
                        break;
                }
            } while (true);
        }
    }
}
