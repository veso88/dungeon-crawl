using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace dungeon_crawl
{
    public partial class mapgrid : Form
    {
        // Map size in tiles
        int mapWidth = 20;
        int mapHeight = 15;
        int tileSize = 32; // pixels per tile

        // 2D array to represent map tiles
        // 0 = floor, 1 = wall, 2 = interactive object
        int[,] map;

        // Character position in tiles
        int characterX = 1;
        int characterY = 1;

        private void InitializeMap()
        {
            map = new int[mapWidth, mapHeight];

            // Fill the map with floor
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    map[x, y] = 0;
                }
            }

            // Border walls
            for (int x = 0; x < mapWidth; x++)
            {
                map[x, 0] = 1;
                map[x, mapHeight - 1] = 1;
            }
            for (int y = 0; y < mapHeight; y++)
            {
                map[0, y] = 1;
                map[mapWidth - 1, y] = 1;
            }

            // Inner walls (maze style)
            for (int x = 3; x < 17; x++)
            {
                map[x, 3] = 1;
            }

            for (int y = 6; y < 10; y++)
            {
                map[6, y] = 1;
                map[13, y] = 1;
            }

            map[10, 5] = 1;
            map[11, 5] = 1;
            map[12, 5] = 1;

            map[8, 8] = 1;
            map[8, 9] = 1;
            map[8, 10] = 1;

            // Interactables
            map[4, 4] = 2;
            map[10, 10] = 2; 
            map[15, 12] = 2; 
        }
        private bool IsWalkable(int x, int y)
        {
            // Check if inside map boundaries
            if (x < 0 || x >= mapWidth || y < 0 || y >= mapHeight)
                return false;

            // Walkable if not a wall
            return map[x, y] != 1;
        }

        private void CheckInteraction()
        {
            if (characterX == 4 && characterY == 4)
            {
                MessageBox.Show("Sbluska se s mishok palqk");
                new Battle().Show();
                this.Hide();
                map[4, 4] = 0; // Make the interactable disappear
                panelMap.Invalidate();
            }
            else if (characterX == 10 && characterY == 10)
            {
                MessageBox.Show("Nameri neotvorena bira");
                new Bira().ShowDialog();
                map[10, 10] = 0; // Make the interactable disappear
                panelMap.Invalidate();
            }
            else if (characterX == 15 && characterY == 12)
            {
                MessageBox.Show("Nameri 5lea");
                map[15, 12] = 0; // Make the interactable disappear
                panelMap.Invalidate();
            }

        }



        public mapgrid()
        {
            InitializeComponent();

            InitializeMap();

            this.KeyPreview = true; // important to capture keyboard before controls

            this.KeyDown += mapgrid_KeyDown;
            panelMap.Paint += panelMap_Paint;

        }

        private void map_Load(object sender, EventArgs e)
        {

        }

        private void panelMap_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    Brush brush = Brushes.LightGreen; // floor color

                    if (map[x, y] == 1)
                        brush = Brushes.Gray; // wall color
                    else if (map[x, y] == 2)
                        brush = Brushes.Gold; // interactive object color

                    Rectangle tileRect = new Rectangle(x * tileSize, y * tileSize, tileSize, tileSize);

                    g.FillRectangle(brush, tileRect);
                    g.DrawRectangle(Pens.Black, tileRect);
                }
            }

            // Draw the character as a blue circle
            Rectangle charRect = new Rectangle(characterX * tileSize, characterY * tileSize, tileSize, tileSize);
            g.FillEllipse(Brushes.Blue, charRect);
        }

        private void mapgrid_KeyDown(object sender, KeyEventArgs e)
        {
            int newX = characterX;
            int newY = characterY;

            switch (e.KeyCode)
            {
                case Keys.Up:
                    newY--;
                    break;
                case Keys.Down:
                    newY++;
                    break;
                case Keys.Left:
                    newX--;
                    break;
                case Keys.Right:
                    newX++;
                    break;
            }

            // Check boundaries and collisions
            if (IsWalkable(newX, newY))
            {
                characterX = newX;
                characterY = newY;
                panelMap.Invalidate(); // redraw panel

                CheckInteraction();
            }
        }
    }
}
