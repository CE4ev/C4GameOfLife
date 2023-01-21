using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static System.Net.WebRequestMethods;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Reflection.Emit;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using TrackBar = System.Windows.Forms.TrackBar;
using NewGameOfLife;

namespace NewGameOfLife
{
    //Reset for the HeadsUp method.
    //Allowing user to change colors of the Game of Life.
    //Making the HeadsUp method vanish and reappear with the toggleButton_Click at the bottom.
    //When universe size, timer interval and color options are changed by the user they should persist even after the program has been closed and then opened again.
    
    //Allow the user to hide the Displaying the neighbor count in each cell.
    
    //Add Resume to a new form which I will make as my Resume which will also have a timer until I graduate(progress bar).
    //Will implement the .NET ability to add my website to my application
    public partial class Form1 : Form
    {
        public Color cellColor = Color.Aqua;
        public Color gridColor = Color.Navy;
        public int[,] Cells { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsToroidal { get; set; }
        public bool[,] universe = new bool[50, 50];
        public bool[,] scratchpad = new bool[50, 50];
        public Timer timer = new Timer();
        public static int timerInterval;
        int generations = 0;
        private string _save;
        private bool isHeadsUpVisible = true;
        public static Form1 instance1;
        public int count { get; set; }
        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(1119, 563);
            timerInterval = 100;
            timer = new Timer();
            timer.Interval = timerInterval;
            timer.Tick += Timer_Tick;
            timer.Enabled = false;
            instance1 = this;
        }
        public void NextGeneration()
        {
            int liveCells = 0;
            for (int row = 0; row < universe.GetLength(0); row++)
            {
                for (int col = 0; col < universe.GetLength(1); col++)
                {
                    int neighbors = CountNeighbors(row, col);
                    if (universe[row, col])
                    {
                        if (neighbors < 2 || neighbors > 3)
                        {
                            scratchpad[row, col] = false;
                        }
                        else
                        {
                            scratchpad[row, col] = true;
                            liveCells++;
                        }
                    }
                    else
                    {
                        if (neighbors == 3)
                        {
                            scratchpad[row, col] = true;
                            liveCells++;
                        }
                        else
                        {
                            scratchpad[row, col] = false;
                        }
                    }
                }
            }
            count = 0;
            for (int row = 0; row < universe.GetLength(0); row++)
            {
                for (int col = 0; col < universe.GetLength(1); col++)
                {
                    if (universe[row, col])
                    {
                        count++;
                    }
                }
            }
            count = liveCells;
            graphicsPanel1.Invalidate();
            bool[,] temp = universe;
            universe = scratchpad;
            scratchpad = temp;
            generations++;
            DrawUniverse();
            HeadsUp(count);
        }
        Bitmap bmp = new Bitmap(1119, 563);
        public void DrawUniverse()
        {
            count = 0;
            using (Graphics g = Graphics.FromImage(bmp))
            {
                g.Clear(Color.White);
                for (int row = 0; row < universe.GetLength(0); row++)
                {
                    for (int col = 0; col < universe.GetLength(1); col++)
                    {
                        if (universe[row, col])
                        {
                            g.FillRectangle(Brushes.Black, col * 10, row * 10, 10, 10);
                            count++;
                        }
                        else
                        {
                            g.FillRectangle(Brushes.White, col * 10, row * 10, 10, 10);
                        }
                    }
                }
            }
            HeadsUp(count);
        }
        public void HeadsUp(int count)
        {
            int maxCells = universe.GetLength(0) * universe.GetLength(1);
            if (count > maxCells)
            {
                count = maxCells;
            }
            else if (count < 0)
            {
                count = 0;
            }
            CellCountLabel.Text = "Cell Count: " + count.ToString();
            CellCountLabel.ForeColor = Color.Orange;
            GenerationLabel.Text = "Generation: " + generations.ToString();
            GenerationLabel.ForeColor = Color.Orange;
            BoundaryTypeLabel.Text = "Boundary Type: " + (IsToroidal ? "Toroidal" : "Finite");
            UniverseSizeLabel.Text = "Universe Size: " + universe.GetLength(0) + "x" + universe.GetLength(1);
            BoundaryTypeLabel.ForeColor = Color.Orange;
            UniverseSizeLabel.ForeColor = Color.Orange;
        }
        public void RandomUniverse()
        {
            Random random = new Random();
            for (int row = 0; row < universe.GetLength(0); row++)
            {
                for (int col = 0; col < universe.GetLength(1); col++)
                {
                    universe[row, col] = random.Next(2) == 1;
                }
            }
            DrawUniverse();
            graphicsPanel1.Invalidate();
        }
        private int CountNeighborsFinite(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;
                    if (xOffset == 0 && yOffset == 0)
                    {
                        continue;
                    }
                    if (xCheck < 0)
                    {
                        continue;
                    }
                    if (yCheck < 0)
                    {
                        continue;
                    }
                    if (xCheck >= xLen)
                    {
                        continue;
                    }
                    if (yCheck >= yLen)
                    {
                        continue;
                    }

                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
        }
        private int CountNeighborsToroidal(int x, int y)
        {
            int count = 0;
            int xLen = universe.GetLength(0);
            int yLen = universe.GetLength(1);
            for (int yOffset = -1; yOffset <= 1; yOffset++)
            {
                for (int xOffset = -1; xOffset <= 1; xOffset++)
                {
                    int xCheck = x + xOffset;
                    int yCheck = y + yOffset;
                    if (xOffset == 0 && yOffset == 0) continue;
                    if (xCheck < 0) xCheck = xLen - 1;
                    if (yCheck < 0) yCheck = yLen - 1;
                    if (xCheck >= xLen) xCheck = 0;
                    if (yCheck >= yLen) yCheck = 0;
                    if (universe[xCheck, yCheck] == true) count++;
                }
            }
            return count;
        }
        private int CountNeighbors(int x, int y)
        {
            if (IsToroidal)
            {
                return CountNeighborsToroidal(x, y);
            }
            else
            {
                return CountNeighborsFinite(x, y);
            }
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellWidth = ClientSize.Width / Width;
            int cellHeight = ClientSize.Height / Height;
            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    if (Cells[x, y] == 1)
                    {
                        g.FillRectangle(new SolidBrush(cellColor), x * cellWidth, y * cellHeight, cellWidth, cellHeight);
                    }
                    g.DrawRectangle(new Pen(gridColor), x * cellWidth, y * cellHeight, cellWidth, cellHeight);
                }
            }
        }
        private void Timer_Tick(object sender, EventArgs e)
        {

            timer.Start();
            NextGeneration();
        }
        public void UpdateGridGraphics()
        {
            graphicsPanel1.Invalidate();
        }
        public void Reset()
        {
            count = 0;
            HeadsUp(count);
            timer.Stop();
            generations = 0;
            Array.Clear(universe, 0, universe.Length);
            Array.Clear(scratchpad, 0, scratchpad.Length);
            graphicsPanel1.Invalidate();
        }
        public void graphicsPanel1_Paint(object sender, PaintEventArgs e)
        {
            int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
            int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);
            Pen gridPen = new Pen(gridColor, 1);
            Brush cellBrush = new SolidBrush(cellColor);
            for (int y = 0; y < universe.GetLength(1); y++)
            {
                for (int x = 0; x < universe.GetLength(0); x++)
                {
                    Rectangle cellRect = Rectangle.Empty;
                    cellRect.X = x * cellWidth;
                    cellRect.Y = y * cellHeight;
                    cellRect.Width = cellWidth;
                    cellRect.Height = cellHeight;
                    if (universe[x, y] == true)
                    {
                        e.Graphics.FillRectangle(cellBrush, cellRect);
                    }
                    e.Graphics.DrawRectangle(gridPen, cellRect.X, cellRect.Y, cellRect.Width, cellRect.Height);
                    if (universe[x, y] == false)
                    {
                        int count = CountNeighbors(x, y);
                        if (count > 0)
                        {
                            e.Graphics.DrawString(count.ToString(), new Font("Arial", 10), Brushes.Yellow, cellRect.X + 5, cellRect.Y + 5);
                        }
                    }
                }
            }
            gridPen.Dispose();
            cellBrush.Dispose();
        }
        public void graphicsPanel1_MouseClick(object sender, MouseEventArgs e)
        {
            // If the left mouse button was clicked
            if (e.Button == MouseButtons.Left)
            {
                // Calculate the width and height of each cell in pixels
                int cellWidth = graphicsPanel1.ClientSize.Width / universe.GetLength(0);
                int cellHeight = graphicsPanel1.ClientSize.Height / universe.GetLength(1);

                // Calculate the cell that was clicked in
                // CELL X = MOUSE X / CELL WIDTH
                int x = e.X / cellWidth;
                // CELL Y = MOUSE Y / CELL HEIGHT
                int y = e.Y / cellHeight;

                // Toggle the cell's state
                universe[x, y] = !universe[x, y];

                // Tell Windows you need to repaint
                graphicsPanel1.Invalidate();
            }
        }
        private void Save()
        {
            if (_save == null)
            {
                SaveAs();
            }
            else
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog()
                {
                    Filter = "All Files | *.* |Cells| *.cells",
                    FilterIndex = 2,
                    DefaultExt = "cells"
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    _save = saveFileDialog.FileName;
                    StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                    writer.WriteLine("Life 1.06");
                    for (int y = 0; y < universe.GetLength(1); y++)
                    {
                        StringBuilder row = new StringBuilder();
                        for (int x = 0; x < universe.GetLength(0); x++)
                        {
                            row.Append(universe[x, y] ? "O" : ".");
                        }
                        writer.WriteLine(row.ToString());
                    }
                    writer.Close();
                }
            }
        }
        private void SaveAs()
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                Filter = "All Files | *.* |Cells| *.cells",
                FilterIndex = 2,
                DefaultExt = "cells"
            };
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                _save = saveFileDialog.FileName;
                StreamWriter writer = new StreamWriter(saveFileDialog.FileName);
                
                    writer.WriteLine("Life 1.06");

                for (int y = 0; y < universe.GetLength(1); y++)
                {
                    String row = string.Empty;
                    writer.WriteLine(row);
                    for (int x = 0; x < universe.GetLength(0); x++)
                    {
                        row = universe[x, y] ? "O" : ".";
                        writer.Write(row);
                    }
                }
                writer.Close();
            }
        }
        private void Open()
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = @"All Files|*.*|Cells|*.cells";
            dlg.FilterIndex = 2;
            int maxWidth = 0, maxHeight = 0, y = 0;
            if (DialogResult.OK == dlg.ShowDialog())
            {
                _save = dlg.FileName;
                StreamReader reader = new StreamReader(dlg.FileName);
                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();

                    if (row == "" || row == "!")
                    {
                        continue;
                    }
                    if (row != "!")
                    {
                        maxHeight++;
                    }
                    if (maxWidth < row.Length)
                    {
                        maxWidth = row.Length;
                    }
                }
                universe = new bool[maxWidth, maxHeight];
                scratchpad = new bool[maxWidth, maxHeight];
                reader.BaseStream.Seek(0, SeekOrigin.Begin);
                y = 0;
                count = 0;
                while (!reader.EndOfStream)
                {
                    string row = reader.ReadLine();
                    if (row == "" || row[0] == '!')
                    {
                        continue;
                    }
                    for (int x = 0; x < row.Length; x++)
                    {
                        if (x < universe.GetLength(0) && y < universe.GetLength(1))
                        {
                            universe[x, y] = row[x] == 'O';
                            if (row[x] == 'O')
                            {
                                count++;
                            }
                        }
                    }
                    y++;
                }
                reader.Close();
                DrawUniverse();
                HeadsUp(count);
            }
        }
        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            
            Timer_Tick(sender, e);
        }
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            timer.Enabled = false;
        }
        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            NextGeneration();
            timer.Enabled = false;

        }
        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            HeadsUp(count);
            Reset();
        }
        private void toolStripStatusLabelGenerations_Click(object sender, EventArgs e)
        {

        }
        private void RandomUniverseButton_Click(object sender, EventArgs e)
        {
            RandomUniverse();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void customizeToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void finiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsToroidal = false;
            Timer_Tick(sender, e);
        }
        private void toroidalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            IsToroidal = true;
            Timer_Tick(sender, e);
        }
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveAs();
        }
        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Thank you for using my application. My name is Wendell Elios Moore and I am a student at Full Sail University in Winter Parks, Florida. I will be graduating in 2024 and I created this application in January of 2023.", "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void finiteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IsToroidal = false;
            
        }
        private void toroidalToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            IsToroidal = true;
        }
        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Open();
        }
        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Reset();
        }
        private void toggleButton_Click(object sender, EventArgs e)
        {
            isHeadsUpVisible = !isHeadsUpVisible;
            if (!isHeadsUpVisible)
            {
                BoundaryTypeLabel.Visible = true;
                UniverseSizeLabel.Visible = true;
                CellCountLabel.Visible = true;
                GenerationLabel.Visible = true;
                HeadsUp(count);
            }
            else
            {
                BoundaryTypeLabel.Visible = false;
                UniverseSizeLabel.Visible = false;
                CellCountLabel.Visible = false;
                GenerationLabel.Visible = false;
            }
        }
        public void universeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserUniverse _uU = new UserUniverse();
            _uU.Show();

        }
        private void timerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserTimer _uT = new UserTimer();
            _uT.Show();
        }
        private void colorsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserColors _uC = new UserColors();
            _uC.Show();
        }

        private void toolsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}