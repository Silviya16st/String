namespace Skrivalishte
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string map = Console.ReadLine();
            bool success = false;
            int maxCount = 0;
            int index = 0;
           
            do
            {
                string[] token = Console.ReadLine().Split();
                char search = token[0][0];
                int minimumCount = int.Parse(token[1]);
                string pattern = new string(search, minimumCount);
               
                if (map.IndexOf(pattern) >= 0)
                {
                    index = map.IndexOf(pattern);
                    success = true;
                    maxCount = minimumCount;
                    int indexEnd = index + minimumCount;
                    
                    while (indexEnd < map.Length)
                    {
                        if (map[indexEnd] == search)
                        {
                            maxCount++;
                            indexEnd++;
                        }
                        else break;
                    }
                }
            }
            
            while (!success);
            Console.WriteLine("Hideout found at index {0} and it is with size {1}!", index, maxCount);
        }
    }
}