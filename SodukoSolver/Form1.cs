using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SodukoSolver
{
    public partial class Soduko : Form
    {

        RichTextBox[,] richBoxes = new RichTextBox[9, 9];
        char[,] sudoku = new char[,]
        {
            { '5', '3', '0', '0', '7', '0', '0', '0', '0' },
            { '6', '0', '0', '1', '9', '5', '0', '0', '0' },
            { '0', '9', '8', '0', '0', '0', '0', '6', '0' },
            { '8', '0', '0', '0', '6', '0', '0', '0', '3' },
            { '4', '0', '0', '8', '0', '3', '0', '0', '1' },
            { '7', '0', '0', '0', '2', '0', '0', '0', '6' },
            { '0', '6', '0', '0', '0', '0', '2', '8', '0' },
            { '0', '0', '0', '4', '1', '9', '0', '0', '5' },
            { '0', '0', '0', '0', '8', '0', '0', '7', '9' }
        };
        public Soduko()
        {
            InitializeComponent();
            InitializeSoduku();
            
        }

        private void InitializeSoduku()
        {
            Panel panel = new Panel();
            for (int i = 0; i < richBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < richBoxes.GetLength(1); j++)
                {
                    richBoxes[i, j] = new RichTextBox();
                    richBoxes[i, j].Size = new Size(40, 40);
                    richBoxes[i, j].Location = new Point(BoxPadding(i) + 2, 2 + BoxPadding(j));
                    richBoxes[i, j].ReadOnly = true;
                    richBoxes[i, j].Parent = panel;
                    richBoxes[i, j].Text = GetNumber(i, j);
                    richBoxes[i, j].Font = new Font("arial", 27.0f);
                    richBoxes[i, j].ScrollBars = RichTextBoxScrollBars.None;
                    richBoxes[i, j].SelectionAlignment = HorizontalAlignment.Center;
                }
            }
            panel.Parent = this;
            panel.BackColor = Color.Black;
            panel.Size = new Size(384, 384);
            panel.Location = new Point(23, 28);
        }

        /// <summary>
        /// calculates the padding value and returns the result
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        private int BoxPadding(int i)
        {
            if(i >= 3 && i < 6)
            {
                return 42 * i;
            }
            if(i >= 6)
                return 42 * i+2;
            return 41 * i;
        }

        /// <summary>
        /// returns the number from sudoku array with i and j indexes
        /// </summary>
        /// <param name="i"></param>
        /// <param name="j"></param>
        /// <returns></returns>
        private string GetNumber(int i, int j)
        {
            if (sudoku[i, j] != '0')
            {
                return Convert.ToString(sudoku[i, j]);
            }
            else return "";
        }

        public void SolveSudoku(char[,] board)
        {
            if (board == null || board.Length == 0)
                return;
            Rolve(sudoku);
            FillBoxes(sudoku);
        }

        private void FillBoxes(char[,] board)
        {
            for (int i = 0; i < richBoxes.GetLength(0); i++)
            {
                for (int j = 0; j < richBoxes.GetLength(1); j++)
                {
                    richBoxes[i, j].Text = GetNumber(i, j);
                }
            }
        }


        public bool Rolve(char[,] board)
        {
            for (int i = 0; i < board.GetLength(0); i++)
            {
                for (int j = 0; j < board.GetLength(1); j++)
                {
                    if (board[i, j] == '0')
                    {
                        for (char c = '1'; c <= '9'; c++)
                        {
                            if (IsValid(board, i, j, c))
                            {
                                board[i, j] = c;
                                if (Rolve(board)) { 
                                    return true;
                                }
                                else
                                    board[i, j] = '0';
                            }
                        }
                        return false;
                    }
                }
            }
            return true;
        }

        public static bool IsValid(char[,] board, int row, int col, char c)
        {
            for (int i = 0; i < 9; i++)
            {
                //check row  
                if (board[i, col] != '0' && board[i, col] == c)
                    return false;
                //check column  
                if (board[row, i] != '0' && board[row, i] == c)
                    return false;
                //check 3*3 block  
                if (board[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] != '0' && board[3 * (row / 3) + i / 3, 3 * (col / 3) + i % 3] == c)
                    return false;
            }
            return true;
        }

        private void _solve_Click(object sender, EventArgs e)
        {
            SolveSudoku(sudoku);
        }

        private void _new_Click(object sender, EventArgs e)
        {
            string grid = sudukoGrid.Text;
            int index = 0;
            for (int i = 0; i < sudoku.GetLength(0); i++)
            {
                for (int j = 0; j < sudoku.GetLength(1); j++)
                {
                    sudoku[i, j] = grid[index];
                    index++;
                }
            }
            FillBoxes(sudoku);
        }
    }
}
