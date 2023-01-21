using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGameOfLife
{
    public partial class UserUniverse : Form
    {
        public static UserUniverse instance4;
        public ToolStripMenuItem UTSM;
        public UserUniverse()
        {
            InitializeComponent();
            instance4 = this;
        }
        private void WidthInput_TextChanged(object sender, EventArgs e)
        {
            int newWidth;
            if (int.TryParse(WidthInput.Text, out newWidth))
            {
                bool[,] newUniverse = new bool[newWidth, Form1.instance1.universe.GetLength(1)];
                int minWidth = Math.Min(newWidth, Form1.instance1.universe.GetLength(0));
                int minHeight = Math.Min(Form1.instance1.universe.GetLength(1), newUniverse.GetLength(1));
                for (int x = 0; x < minWidth; x++)
                {
                    for (int y = 0; y < minHeight; y++)
                    {
                        newUniverse[x, y] = Form1.instance1.universe[x, y];
                    }
                }
                Form1.instance1.universe = newUniverse;
            }
            if (int.TryParse(WidthInput.Text, out newWidth))
            {
                bool[,] newScratchpad = new bool[newWidth, Form1.instance1.scratchpad.GetLength(1)];
                int minWidth = Math.Min(newWidth, Form1.instance1.scratchpad.GetLength(0));
                int minHeight = Math.Min(Form1.instance1.scratchpad.GetLength(1), newScratchpad.GetLength(1));
                for (int x = 0; x < minWidth; x++)
                {
                    for (int y = 0; y < minHeight; y++)
                    {
                        newScratchpad[x, y] = Form1.instance1.scratchpad[x, y];
                    }
                }
                Form1.instance1.scratchpad = newScratchpad;
            }
        }
        private void HeightInput_TextChanged(object sender, EventArgs e)
        {
            int newHeight;
            if (int.TryParse(HeightInput.Text, out newHeight))
            {
                bool[,] newUniverse = new bool[Form1.instance1.universe.GetLength(0), newHeight];
                int minWidth = Math.Min(newUniverse.GetLength(0), Form1.instance1.universe.GetLength(0));
                int minHeight = Math.Min(newHeight, Form1.instance1.universe.GetLength(1));
                for (int x = 0; x < minWidth; x++)
                {
                    for (int y = 0; y < minHeight; y++)
                    {
                        newUniverse[x, y] = Form1.instance1.universe[x, y];
                    }
                }
                Form1.instance1.universe = newUniverse;
            }
            if (int.TryParse(HeightInput.Text, out newHeight))
            {
                bool[,] newScratchpad = new bool[Form1.instance1.scratchpad.GetLength(0), newHeight];
                int minWidth = Math.Min(newScratchpad.GetLength(0), Form1.instance1.scratchpad.GetLength(0));
                int minHeight = Math.Min(newHeight, Form1.instance1.scratchpad.GetLength(1));
                for (int x = 0; x < minWidth; x++)
                {
                    for (int y = 0; y < minHeight; y++)
                    {
                        newScratchpad[x, y] = Form1.instance1.scratchpad[x, y];
                    }
                }
                Form1.instance1.scratchpad = newScratchpad;
            }
        }
        private void UpdateUniverse()
        {
            int newWidth, newHeight;
            if (int.TryParse(WidthInput.Text, out newWidth) && int.TryParse(HeightInput.Text, out newHeight))
            {
                if (newWidth > 0 && newHeight > 0)
                {
                    bool[,] newUniverse = new bool[newWidth, newHeight];
                    int minWidth = Math.Min(newWidth, Form1.instance1.universe.GetLength(0));
                    int minHeight = Math.Min(newHeight, Form1.instance1.universe.GetLength(1));
                    for (int x = 0; x < minWidth; x++)
                    {
                        for (int y = 0; y < minHeight; y++)
                        {
                            newUniverse[x, y] = Form1.instance1.universe[x, y];
                        }
                    }
                    Form1.instance1.universe = newUniverse;
                    Form1.instance1.UpdateGridGraphics();
                }
                else
                {
                    MessageBox.Show("Enter a valid width and height greater than 0.");
                }
            }
            else
            {
                MessageBox.Show("Enter a valid width and height.");
            }
        }
        private void HeightInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void WidthInput_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            UpdateUniverse();
            this.Close();
        }
    }
}