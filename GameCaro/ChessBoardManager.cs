using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameCaro
{
    public class ChessBoardManager
    {
        public int size;
        private readonly Panel ChessBoard;
        private readonly TextBox PlayerName;
        public List<Player> Players;
        private int CurrentPlayer;
        private List<List<Button>> Matrix;

        private const int CHESS_SIZE = 60;
        private int BoardSize = (480 / CHESS_SIZE);
        private int EndGameCondition = (480 / CHESS_SIZE) >= 5 ? 5 : 3;

        public ChessBoardManager(Panel pnl, TextBox txt)
        {
            this.Matrix = new List<List<Button>>();
            this.size = CHESS_SIZE;
            this.ChessBoard = pnl;
            this.PlayerName = txt;
            this.Players = new() {
                new Player() { Id = 0, Name = "Mark Zuckerberg", Mark = Properties.Resources.x },
                new Player() { Id = 1, Name = "Elon Musk", Mark = Properties.Resources.o },
            };
            CurrentPlayer = 0;
            ChangePlayer();
        }

        public void DrawChessBoard()
        {
            ChessBoard.Controls.Clear();
            this.Matrix = new List<List<Button>>();
            for (int i = 0; i < BoardSize; i++)
            {
                Matrix.Add(new List<Button>());
                for (int j = 0; j < BoardSize; j++)
                {
                    Point position = new(0 + (i * size), 0 + (j * size));
                    Button btn = new()
                    {
                        Height = size,
                        Width = size,
                        Location = position,
                        FlatStyle = FlatStyle.Flat,
                        BackgroundImage = null,
                        BackgroundImageLayout = ImageLayout.Stretch,
                        Tag = i.ToString()
                    };
                    btn.Click += Select;

                    ChessBoard.Controls.Add(btn);
                    Matrix[i].Add(btn);
                }
            }
        }

        private void Select(object? sender, EventArgs e)
        {
            Button btn = sender as Button;

            if (btn?.BackgroundImage != null)
            {
                return;
            }

            Mark(btn);

            ChangePlayer();

        }

        private void Mark(Button btn)
        {
            btn.BackgroundImage = Players[CurrentPlayer].Mark;
            if (isEndGame(btn))
            {
                EndGame();
            }
            else
            {
                CurrentPlayer = CurrentPlayer == 0 ? 1 : 0;
            }
        }

        private void ChangePlayer()
        {
            PlayerName.Text = Players[CurrentPlayer].Name + "'s turn";
        }

        private Point GetChessPoint(Button btn)
        {
            int horizontal = Convert.ToInt32(btn.Tag);
            int vertical = Matrix[horizontal].IndexOf(btn);

            Point point = new Point(horizontal, vertical);

            return point;
        }

        private void EndGame()
        {
            MessageBox.Show("End Game. The winner is " + Players[CurrentPlayer].Name,
                            "Congratulation", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.DrawChessBoard();
        }

        private bool isEndGame(Button btn)
        {
            return isEndHorizontal(btn) || isEndVertical(btn) || isEndPrimary(btn) || isEndSub(btn);
        }

        private bool isEndHorizontal(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countLeft = 0;
            for (int i = point.X; i >= 0; i--)
            {
                if (Matrix[i][point.Y].BackgroundImage == btn.BackgroundImage)
                {
                    countLeft++;
                }
                else
                    break;
            }

            int countRight = 0;
            for (int i = point.X + 1; i < BoardSize; i++)
            {
                if (Matrix[i][point.Y].BackgroundImage == btn.BackgroundImage)
                {
                    countRight++;
                }
                else
                    break;
            }

            return countLeft + countRight == EndGameCondition;
        }

        private bool isEndVertical(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = point.Y; i >= 0; i--)
            {
                if (Matrix[point.X][i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = point.Y + 1; i < BoardSize; i++)
            {
                if (Matrix[point.X][i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == EndGameCondition;
        }

        private bool isEndPrimary(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i <= point.X; i++)
            {
                if (point.X - i < 0 || point.Y - i < 0)
                    break;

                if (Matrix[point.X - i][point.Y - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i < BoardSize - point.X; i++)
            {
                if (point.Y + i >= BoardSize || point.X + i >= BoardSize)
                    break;

                if (Matrix[point.X + i][point.Y + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == EndGameCondition;
        }

        private bool isEndSub(Button btn)
        {
            Point point = GetChessPoint(btn);

            int countTop = 0;
            for (int i = 0; i < point.X; i++)
            {
                if (point.X + i >= BoardSize || point.Y - i < 0)
                    break;

                if (Matrix[point.X + i][point.Y - i].BackgroundImage == btn.BackgroundImage)
                {
                    countTop++;
                }
                else
                    break;
            }

            int countBottom = 0;
            for (int i = 1; i < BoardSize - point.Y; i++)
            {
                if (point.Y + i >= BoardSize || point.X - i < 0)
                    break;

                if (Matrix[point.X - i][point.Y + i].BackgroundImage == btn.BackgroundImage)
                {
                    countBottom++;
                }
                else
                    break;
            }

            return countTop + countBottom == EndGameCondition;
        }

    }
}
