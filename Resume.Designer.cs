namespace NewGameOfLife
{
    partial class Resume
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Resume));
            this.label = new System.Windows.Forms.Label();
            this.GOL = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label
            // 
            this.label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.ForeColor = System.Drawing.Color.DarkOrange;
            this.label.Location = new System.Drawing.Point(12, 9);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(1213, 188);
            this.label.TabIndex = 0;
            this.label.Text = resources.GetString("label.Text");
            this.label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label.UseCompatibleTextRendering = true;
            // 
            // GOL
            // 
            this.GOL.BackColor = System.Drawing.Color.Black;
            this.GOL.ForeColor = System.Drawing.Color.DarkOrange;
            this.GOL.Location = new System.Drawing.Point(492, 200);
            this.GOL.Name = "GOL";
            this.GOL.Size = new System.Drawing.Size(250, 23);
            this.GOL.TabIndex = 1;
            this.GOL.Text = "First Project: John Conway\'s Game Of Life";
            this.GOL.UseVisualStyleBackColor = false;
            this.GOL.Click += new System.EventHandler(this.GOL_Click);
            // 
            // Resume
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(1237, 712);
            this.Controls.Add(this.GOL);
            this.Controls.Add(this.label);
            this.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Resume";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Resume";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Button GOL;
    }
}