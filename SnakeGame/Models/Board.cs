using Microsoft.Maui.Controls.Shapes;
using Microsoft.Maui.Graphics;
using SnakeGame.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Color = Microsoft.Maui.Graphics.Color;

namespace SnakeGame.Models
{
    public class Board : IBoard
    {
        public bool Playing
        {
            get => playing;
            set => playing = value;
        }

        private readonly int BoardSizeX;
        private readonly int BoardSizeY;
        private bool playing;
        private Snake snake;
        private List<Food> food;

        public Board(int x_size, int y_size)
        {
        }

        public List<Tile> DumpBoard()
        {
            return new List<Tile>();
        }

        public void InitBoard()
        {
        }

        public void KeyPress(Snake.Direction direction)
        {
        }

        public void TestInitBoard(Snake snake, List<Food> food)
        {
            this.playing = true;
            this.snake = snake;
            this.food = food;
        }

        public int Tick()
        {
            return 0;
        }
    }
}
