namespace NewGameOfLife
{
    partial class UserColors
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserColors));
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.pbxColor = new System.Windows.Forms.Panel();
            this.tbxBlue = new System.Windows.Forms.TextBox();
            this.tbxGreen = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblSs = new System.Windows.Forms.Label();
            this.rgbValues = new System.Windows.Forms.Label();
            this.cBox = new System.Windows.Forms.ComboBox();
            this.txtBRed = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(784, 754);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 0;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Cancel.Location = new System.Drawing.Point(1102, 754);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 1;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            this.Cancel.Click += new System.EventHandler(this.Cancel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(258, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(176, 32);
            this.label1.TabIndex = 2;
            this.label1.Text = "Color Picker";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Cursor = System.Windows.Forms.Cursors.Cross;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(720, 720);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseDown);
            this.pictureBox1.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pictureBox1_MouseMove);
            // 
            // label2
            // 
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Location = new System.Drawing.Point(6, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Red";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBRed);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.pbxColor);
            this.groupBox1.Controls.Add(this.tbxBlue);
            this.groupBox1.Controls.Add(this.tbxGreen);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(799, 388);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(363, 273);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selected Color";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(226, 17);
            this.label5.TabIndex = 13;
            this.label5.Text = "Please enter a value from 0 to 255";
            // 
            // pbxColor
            // 
            this.pbxColor.Location = new System.Drawing.Point(216, 35);
            this.pbxColor.Name = "pbxColor";
            this.pbxColor.Size = new System.Drawing.Size(142, 220);
            this.pbxColor.TabIndex = 12;
            // 
            // tbxBlue
            // 
            this.tbxBlue.Location = new System.Drawing.Point(92, 235);
            this.tbxBlue.Name = "tbxBlue";
            this.tbxBlue.Size = new System.Drawing.Size(118, 20);
            this.tbxBlue.TabIndex = 11;
            this.tbxBlue.TextChanged += new System.EventHandler(this.tbxBlue_TextChanged);
            this.tbxBlue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxBlue_KeyPress);
            // 
            // tbxGreen
            // 
            this.tbxGreen.Location = new System.Drawing.Point(92, 131);
            this.tbxGreen.Name = "tbxGreen";
            this.tbxGreen.Size = new System.Drawing.Size(118, 20);
            this.tbxGreen.TabIndex = 10;
            this.tbxGreen.TextChanged += new System.EventHandler(this.tbxGreen_TextChanged);
            this.tbxGreen.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxGreen_KeyPress);
            // 
            // label4
            // 
            this.label4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label4.Location = new System.Drawing.Point(6, 232);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 23);
            this.label4.TabIndex = 8;
            this.label4.Text = "Blue";
            // 
            // label3
            // 
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label3.Location = new System.Drawing.Point(6, 131);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 23);
            this.label3.TabIndex = 7;
            this.label3.Text = "Green";
            // 
            // lblSs
            // 
            this.lblSs.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblSs.Location = new System.Drawing.Point(914, 134);
            this.lblSs.Name = "lblSs";
            this.lblSs.Size = new System.Drawing.Size(118, 117);
            this.lblSs.TabIndex = 7;
            // 
            // rgbValues
            // 
            this.rgbValues.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.rgbValues.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rgbValues.Location = new System.Drawing.Point(799, 269);
            this.rgbValues.Name = "rgbValues";
            this.rgbValues.Size = new System.Drawing.Size(363, 38);
            this.rgbValues.TabIndex = 8;
            // 
            // cBox
            // 
            this.cBox.FormattingEnabled = true;
            this.cBox.Location = new System.Drawing.Point(905, 310);
            this.cBox.Name = "cBox";
            this.cBox.Size = new System.Drawing.Size(136, 21);
            this.cBox.TabIndex = 9;
            this.cBox.Text = "Please select an option";
            this.cBox.DropDown += new System.EventHandler(this.cBox_DropDown);
            this.cBox.Click += new System.EventHandler(this.cBox_Click);
            // 
            // txtBRed
            // 
            this.txtBRed.Location = new System.Drawing.Point(92, 39);
            this.txtBRed.Name = "txtBRed";
            this.txtBRed.Size = new System.Drawing.Size(100, 20);
            this.txtBRed.TabIndex = 14;
            this.txtBRed.TextChanged += new System.EventHandler(this.tbxRed_TextChanged);
            this.txtBRed.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbxRed_KeyPress);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(1065, 667);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Clear Selection";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(808, 667);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Save Selected Item";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // UserColors
            // 
            this.AcceptButton = this.Ok;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.Cancel;
            this.ClientSize = new System.Drawing.Size(1200, 789);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cBox);
            this.Controls.Add(this.rgbValues);
            this.Controls.Add(this.lblSs);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "UserColors";
            this.Text = "UserColors";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel pbxColor;
        private System.Windows.Forms.TextBox tbxBlue;
        private System.Windows.Forms.TextBox tbxGreen;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblSs;
        private System.Windows.Forms.Label rgbValues;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cBox;
        private System.Windows.Forms.TextBox txtBRed;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}