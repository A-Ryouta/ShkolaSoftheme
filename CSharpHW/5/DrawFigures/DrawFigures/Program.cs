using System;
using System.Text;

namespace DrawFigures
{
    class Program
    {
        static void Main()
        {
            bool exit = false;
            do
            {
                Console.WriteLine("Select 2DShape Triangle - t, Square - s, Romb - r.\nTo exit press q");
                string shape = Console.ReadLine();

                if(shape == "q")
                {
                    break;
                }

                Console.WriteLine("Select your 2DShape size from 1 to 10");
                int size = int.Parse(Console.ReadLine());
                                
                StringBuilder block = new StringBuilder("");
                
                switch (shape)
                {
                    case "t":
                        for(int i = 0; i < size; i++)
                        {
                            block.Append("*");
                            Console.WriteLine(block);
                        }
                        break;
                    case "s":
                        block.Append('*', size);
                        for(int i = 0; i < size; i++)
                        {
                            Console.WriteLine(block);
                        }
                        break;
                    case "r":
                        StringBuilder space = new StringBuilder();
                        space.Append(' ', size);
                        block.Append("*");

                        for(int i = 0; i < size; i++)
                        {
                            if (i < (size / 2))
                            {
                                Console.WriteLine("{0}{1}", space, block);
                                space.Remove(0, 1);
                                block.Append("**");
                            }
                            else if (i > (size / 2))
                            {
                                if (i <= size - 1)
                                {
                                    block.Remove(0, 2);
                                }
                                else
                                {
                                    block.Remove(0, 1);
                                }
                                space.Append(" ");
                                Console.WriteLine("{0}{1}", space, block);                                
                            }
                            else
                            {
                                Console.WriteLine("{0}{1}", space, block);
                            }
                        }
                        break;
                    case "q":
                        exit = true;
                        break;
                }                
            } while (!exit);
        }
    }
}
