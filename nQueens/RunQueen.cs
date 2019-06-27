using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nQueens
{
    public static class RunQueen
    {
       public static void run()
        {
            //Request the dimension of board
            Console.Write("Input the dimension value of the board: ");
            int dimension = 0;
            Int32.TryParse(Console.ReadLine(), out dimension);
            Console.WriteLine();
            //Create a board
            Board b1 = new Board(dimension);
            //Print board state
            print(b1);
            /* Code to enable generating randomized boards that are valid
            //Randomize board
            Console.WriteLine("\nRandomizing...\n");
            rand(b1);
            //Verify
            Console.Write("\nVerfiying board...\n\n");
            while (verify(b1) == false)
            {
                rand(b1);
            }
            */
            Console.WriteLine("\nGenerating...\n");
            generate(b1,dimension);
        }
        private static void print(Board b1)
        {
            //Print board state
            b1.printBoard();
            Console.Write("\nThis is a preview of the current state of your board. Press enter to continue.");
            Console.ReadLine();
        }
        private static int rand(Board b1)
        {            
            b1.randomizeBoard();
            //print(b1);
            //Console.Write("\nPress enter to continue. Enter 1 to randomize again: ");
            int ret = 0;
            //Int32.TryParse(Console.ReadLine(), out ret);
            return ret;
        }
        private static Boolean verify(Board b1)
        {
            bool ver;
            ver = b1.verifyBoard();
            if (ver == true)
            {
                Console.WriteLine("\nStatus: Passed\n");
                print(b1);
            }
            else
            {
                //Console.WriteLine("\nStatus: Failed\n");          
            }
            return ver;
        }
        private static void generate(Board b1, int dimension)
        {
            for(int m = 0; m < dimension; m++)
            {
                for (int v = 0; v < dimension; v++)
                {
                    b1.setValue(v, m, 1);
                    if(b1.verifyBoard()==false)
                    {
                        b1.setValue(v, m, 0);
                    }
                }
            }
            print(b1);
        }
    }
}
