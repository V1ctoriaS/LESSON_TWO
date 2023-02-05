
        void Main(string[] args)
        {
            int[,] number = new int[3, 5];
            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.WriteLine("Please enter number");
                    number[x, i] = int.Parse(Console.ReadLine());
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int x = 0; x < 3; x++)
                {
                    Console.Write(number[x, i] + " ");
                }
                Console.WriteLine(" ");
                Console.ReadLine();
            }
        }
