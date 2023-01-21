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
    public partial class UserColors : Form
    {
        public static UserColors instance2;
        public UserColors()
        {
            InitializeComponent();
            instance2 = this;
            
        }
        private bool isUserInput = true;
        private bool itemsAdded = false;
        private Color _selectedColor;
        public Color SelectedColor
        {
            get { return _selectedColor; }
            set { _selectedColor = value; }
        }

        private void ApplyColorButton_Click(object sender, EventArgs e)
        {
            _selectedColor = pbxColor.BackColor;
            Form1.instance1.cellColor = _selectedColor;
        }
        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Bitmap pbm = (Bitmap)pictureBox1.Image;
            if (e.X < pbm.Width && e.Y < pbm.Height)
            {
                Color c = pbm.GetPixel(e.X, e.Y);
                lblSs.BackColor = c;
                rgbValues.Text = "R = " + c.R.ToString() + ", G = " + c.G.ToString() + ", B = " + c.B.ToString();
            }
        }
        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            isUserInput = false;
            Bitmap pd = (Bitmap)pictureBox1.Image;
            Color d = pd.GetPixel(e.X, e.Y);
            txtBRed.Text = d.R.ToString();
            tbxGreen.Text = d.G.ToString();
            tbxBlue.Text = d.B.ToString();
            pbxColor.BackColor = d;
            isUserInput = true;
            tbxRed_TextChanged(sender, e);
            tbxGreen_TextChanged(sender, e);
            tbxBlue_TextChanged(sender, e);
        }
        private void tbxRed_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbxGreen_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbxBlue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbxRed_TextChanged(object sender, EventArgs e)
        {
            if (isUserInput)
            {
                if (txtBRed.Text != "")
                {
                    int r = Convert.ToInt32(txtBRed.Text);
                    if (r > 255)
                    {
                        txtBRed.Text = "255";
                    }
                    if (r < 0)
                    {
                        txtBRed.Text = "0";
                    }
                    int g = Convert.ToInt32(tbxGreen.Text);
                    int b = Convert.ToInt32(tbxBlue.Text);
                    pbxColor.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }
        private void tbxGreen_TextChanged(object sender, EventArgs e)
        {
            if (isUserInput)
            {
                if (tbxGreen.Text != "")
                {
                    int g = Convert.ToInt32(tbxGreen.Text);
                    if (g > 255)
                    {
                        tbxGreen.Text = "255";
                    }
                    if (g < 0)
                    {
                        tbxGreen.Text = "0";
                    }
                    int r = Convert.ToInt32(txtBRed.Text);
                    int b = Convert.ToInt32(tbxBlue.Text);
                    pbxColor.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }
        private void tbxBlue_TextChanged(object sender, EventArgs e)
        {
            if (isUserInput)
            {
                if (tbxBlue.Text != "")
                {
                    int b = Convert.ToInt32(tbxBlue.Text);
                    if (b > 255)
                    {
                        tbxBlue.Text = "255";
                    }
                    if (b < 0)
                    {
                        tbxBlue.Text = "0";
                    }
                    int r = Convert.ToInt32(txtBRed.Text);
                    int g = Convert.ToInt32(tbxGreen.Text);
                    pbxColor.BackColor = Color.FromArgb(r, g, b);
                }
            }
        }
        private void Cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void Ok_Click(object sender, EventArgs e)
        {
            Form1 mainForm = Form1.instance1;
            string selectedItem = cBox.SelectedItem.ToString();
            if (selectedItem == "Cells")
            {
                mainForm.cellColor = pbxColor.BackColor;
            }
            else if (selectedItem == "Universe and Scratchpad")
            {
                mainForm.gridColor = pbxColor.BackColor;
            }
            else if (selectedItem == "Background")
            {
                mainForm.BackColor = pbxColor.BackColor;
            }
            Close();
        }
        private void cBox_DropDown(object sender, EventArgs e)
        {
            if (!itemsAdded)
            {
                cBox.Items.Add("Cells");
                cBox.Items.Add("Universe and Scratchpad");
                cBox.Items.Add("Background");
                itemsAdded = true;
            }
        }
        private void cBox_Click(object sender, EventArgs e)
        {
            
            if (cBox.SelectedItem != null)
            {
                switch (cBox.Text)
                {
                    case "Cells":
                        //This should allow the user to change the colors of the cells.
                        pbxColor.BackColor = Form1.instance1.cellColor;
                        break;
                    case "Universe and Scratchpad":
                        //This should allow the user to change the colors of the gridColor.
                        pbxColor.BackColor = Form1.instance1.gridColor;
                        break;
                    case "Background":
                        //This should allow the user to change the background of Form1.
                        pbxColor.BackColor = Form1.instance1.BackColor;
                        break;
                }
            }
        }
        private void clearItems()
        {
            cBox.Items.Clear();
            itemsAdded = false;
        }
        private void cBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            cBox.Text = cBox.SelectedItem.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            clearItems();
        }
    }
}