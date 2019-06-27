using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nQueens
{
    //Creates a chess board
    public class Board
    {
        //Holds the dimensions of the board
        //1 denotes a piece
        //0 denotes emtpy
        int[,] storage;
        int dimension;
        //Create a board with defined dimensions
        public Board(int i)
        {
            storage = new int[i,i];
            dimension = i;
            for(int m = 0; m < dimension; m++)
            {
                for (int v = 0; v < dimension; v++)
                {
                    storage[m, v] = 0;
                }
            }
        }
        //Print a board
        public void printBoard()
        {
            for (int m = 0; m < dimension; m++)
            {
                for (int v = 0; v < dimension; v++)
                {
                    if (storage[m, v] == 0)
                    {
                        Console.Write("X ");
                    }
                    else
                    {
                        Console.Write("Q ");
                    }
                }
                Console.WriteLine();
            }
        }
        public void randomizeBoard()
        {
            Random r = new Random();
            for (int m = 0; m < dimension; m++)
            {
                for (int v = 0; v < dimension; v++)
                {
                    if(r.Next(100) > 50)
                    {
                        storage[m, v] = 0;
                    }
                    else
                    {
                        storage[m, v] = 1;
                    }
                }
            }
        }
        public void setValue(int i, int m, int x)
        {
            storage[i, m] = x;
        }
        public Boolean verifyBoard()
        {
            int col;
            int row;
            for (int m = 0; m < dimension; m++)
            {
                for (int v = 0; v < dimension; v++)
                {
                    if (storage[m,v] == 1)
                    {
                        //Check above
                        col = v + 1;      
                        while (col < dimension)
                        {
                            if(storage[m,col] == 1)
                            {
                                return false;
                            }
                            col++;
                        }
                        //Check below
                        col = v - 1;
                        while (col > -1)
                        {
                            if (storage[m, col] == 1)
                            {
                                return false;
                            }
                            col--;
                        }
                        //Check right
                        row = m + 1;
                        while (row < dimension)
                        {
                            if (storage[row, v] == 1)
                            {
                                return false;
                            }
                            row++;
                        }
                        //Check left
                        row = m - 1;
                        while (row > -1)
                        {
                            if (storage[row, v] == 1)
                            {
                                return false;
                            }
                            row--;
                        }
                        //Check topRight
                        row = m + 1;
                        col = v + 1;
                        while (row < dimension && col < dimension)
                        {
                            if (storage[row, col] == 1)
                            {
                                return false;
                            }
                            row++;
                            col++;
                        }
                        //Check topLeft
                        row = m - 1;
                        col = v + 1;
                        while (row > -1 && col < dimension)
                        {
                            if (storage[row, col] == 1)
                            {
                                return false;
                            }
                            row--;
                            col++;
                        }
                        //Check bottomRight
                        row = m + 1;
                        col = v - 1;
                        while (row < dimension && col > -1)
                        {
                            if (storage[row, col] == 1)
                            {
                                return false;
                            }
                            row++;
                            col--;
                        }
                        //Check bottmLeft
                        row = m - 1;
                        col = v - 1;
                        while (row > -1 && col > -1)
                        {
                            if (storage[row, col] == 1)
                            {
                                return false;
                            }
                            row--;
                            col--;
                        }
                    }
                    
                }
            }
            return true;
        }
    }
}
