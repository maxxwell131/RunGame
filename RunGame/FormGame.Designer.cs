namespace RunGame
{
    partial class FormGame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
            this.picture = new System.Windows.Forms.PictureBox();
            this.buttonAddGamer = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picture)).BeginInit();
            this.SuspendLayout();
            // 
            // picture
            // 
            this.picture.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.picture.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picture.Location = new System.Drawing.Point(0, 0);
            this.picture.Name = "picture";
            this.picture.Size = new System.Drawing.Size(896, 525);
            this.picture.TabIndex = 0;
            this.picture.TabStop = false;
            // 
            // buttonAddGamer
            // 
            this.buttonAddGamer.Location = new System.Drawing.Point(847, 12);
            this.buttonAddGamer.Name = "buttonAddGamer";
            this.buttonAddGamer.Size = new System.Drawing.Size(37, 23);
            this.buttonAddGamer.TabIndex = 1;
            this.buttonAddGamer.Text = "+";
            this.buttonAddGamer.UseVisualStyleBackColor = true;
            this.buttonAddGamer.Click += new System.EventHandler(this.buttonAddGamer_Click);
            // 
            // FormGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 525);
            this.Controls.Add(this.buttonAddGamer);
            this.Controls.Add(this.picture);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormGame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Game with Interface";
            ((System.ComponentModel.ISupportInitialize)(this.picture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picture;
        private System.Windows.Forms.Button buttonAddGamer;
    }
}

