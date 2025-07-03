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

            // Fill the map with floor tiles (0)
            for (int x = 0; x < mapWidth; x++)
            {
                for (int y = 0; y < mapHeight; y++)
                {
                    map[x, y] = 0; // floor
                }
            }

            // Create walls around the edges (1)
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

            // Add some inner walls for challenge
            map[5, 5] = 1;
            map[6, 5] = 1;
            map[7, 5] = 1;

            // Add an interactive object (2)
            map[10, 10] = 2;
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
            if (map[characterX, characterY] == 2)
            {
                MessageBox.Show("You started a battle");
                Battle start = new Battle();
                start.Show();
                this.Hide();
                map[characterX, characterY] = 0; // remove the object from the map
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
