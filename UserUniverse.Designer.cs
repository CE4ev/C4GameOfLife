namespace NewGameOfLife
{
    partial class UserUniverse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserUniverse));
            this.UWidth = new System.Windows.Forms.Label();
            this.UHeight = new System.Windows.Forms.Label();
            this.Ok = new System.Windows.Forms.Button();
            this.Cancel = new System.Windows.Forms.Button();
            this.WidthInput = new System.Windows.Forms.TextBox();
            this.HeightInput = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // UWidth
            // 
            this.UWidth.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UWidth.Location = new System.Drawing.Point(12, 93);
            this.UWidth.Name = "UWidth";
            this.UWidth.Size = new System.Drawing.Size(220, 28);
            this.UWidth.TabIndex = 0;
            this.UWidth.Text = "Universe Width";
            // 
            // UHeight
            // 
            this.UHeight.Font = new System.Drawing.Font("Arial Black", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UHeight.Location = new System.Drawing.Point(12, 206);
            this.UHeight.Name = "UHeight";
            this.UHeight.Size = new System.Drawing.Size(220, 30);
            this.UHeight.TabIndex = 1;
            this.UHeight.Text = "Universe Height";
            // 
            // Ok
            // 
            this.Ok.Location = new System.Drawing.Point(17, 300);
            this.Ok.Name = "Ok";
            this.Ok.Size = new System.Drawing.Size(75, 23);
            this.Ok.TabIndex = 2;
            this.Ok.Text = "Ok";
            this.Ok.UseVisualStyleBackColor = true;
            this.Ok.Click += new System.EventHandler(this.Ok_Click);
            // 
            // Cancel
            // 
            this.Cancel.Location = new System.Drawing.Point(305, 300);
            this.Cancel.Name = "Cancel";
            this.Cancel.Size = new System.Drawing.Size(75, 23);
            this.Cancel.TabIndex = 3;
            this.Cancel.Text = "Cancel";
            this.Cancel.UseVisualStyleBackColor = true;
            // 
            // WidthInput
            // 
            this.WidthInput.Location = new System.Drawing.Point(242, 101);
            this.WidthInput.Name = "WidthInput";
            this.WidthInput.Size = new System.Drawing.Size(138, 20);
            this.WidthInput.TabIndex = 4;
            this.WidthInput.TextChanged += new System.EventHandler(this.WidthInput_TextChanged);
            this.WidthInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WidthInput_KeyPress);
            // 
            // HeightInput
            // 
            this.HeightInput.Location = new System.Drawing.Point(242, 214);
            this.HeightInput.Name = "HeightInput";
            this.HeightInput.Size = new System.Drawing.Size(138, 20);
            this.HeightInput.TabIndex = 5;
            this.HeightInput.TextChanged += new System.EventHandler(this.HeightInput_TextChanged);
            this.HeightInput.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.HeightInput_KeyPress);
            // 
            // UserUniverse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.BackgroundImage = global::NewGameOfLife.Properties.Resources.earth;
            this.ClientSize = new System.Drawing.Size(403, 362);
            this.Controls.Add(this.HeightInput);
            this.Controls.Add(this.WidthInput);
            this.Controls.Add(this.Cancel);
            this.Controls.Add(this.Ok);
            this.Controls.Add(this.UHeight);
            this.Controls.Add(this.UWidth);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UserUniverse";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UserUniverse";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label UWidth;
        private System.Windows.Forms.Label UHeight;
        private System.Windows.Forms.Button Ok;
        private System.Windows.Forms.Button Cancel;
        private System.Windows.Forms.TextBox WidthInput;
        private System.Windows.Forms.TextBox HeightInput;
    }
}