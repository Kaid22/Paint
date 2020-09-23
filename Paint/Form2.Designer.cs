namespace Paint
{
    partial class Colorpicker
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
            this.colorshow = new System.Windows.Forms.Button();
            this.Red = new System.Windows.Forms.NumericUpDown();
            this.Green = new System.Windows.Forms.NumericUpDown();
            this.Blue = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.Reds = new System.Windows.Forms.HScrollBar();
            this.Greens = new System.Windows.Forms.HScrollBar();
            this.Blues = new System.Windows.Forms.HScrollBar();
            this.Done = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Red)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).BeginInit();
            this.SuspendLayout();
            // 
            // colorshow
            // 
            this.colorshow.Location = new System.Drawing.Point(100, 185);
            this.colorshow.Name = "colorshow";
            this.colorshow.Size = new System.Drawing.Size(200, 200);
            this.colorshow.TabIndex = 9;
            this.colorshow.UseVisualStyleBackColor = true;
            // 
            // Red
            // 
            this.Red.Location = new System.Drawing.Point(12, 35);
            this.Red.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Red.Name = "Red";
            this.Red.Size = new System.Drawing.Size(120, 20);
            this.Red.TabIndex = 10;
            this.Red.ValueChanged += new System.EventHandler(this.Red_ValueChanged);
            // 
            // Green
            // 
            this.Green.Location = new System.Drawing.Point(138, 35);
            this.Green.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Green.Name = "Green";
            this.Green.Size = new System.Drawing.Size(120, 20);
            this.Green.TabIndex = 11;
            this.Green.ValueChanged += new System.EventHandler(this.Green_ValueChanged);
            // 
            // Blue
            // 
            this.Blue.Location = new System.Drawing.Point(264, 35);
            this.Blue.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
            this.Blue.Name = "Blue";
            this.Blue.Size = new System.Drawing.Size(120, 20);
            this.Blue.TabIndex = 12;
            this.Blue.ValueChanged += new System.EventHandler(this.Blue_ValueChanged);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(12, 62);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 13;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.button2.Location = new System.Drawing.Point(138, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(120, 23);
            this.button2.TabIndex = 14;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.button3.Location = new System.Drawing.Point(264, 61);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(120, 23);
            this.button3.TabIndex = 15;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // Reds
            // 
            this.Reds.Location = new System.Drawing.Point(12, 92);
            this.Reds.Maximum = 255;
            this.Reds.Name = "Reds";
            this.Reds.Size = new System.Drawing.Size(120, 17);
            this.Reds.TabIndex = 16;
            this.Reds.ValueChanged += new System.EventHandler(this.Reds_ValueChanged);
            // 
            // Greens
            // 
            this.Greens.Location = new System.Drawing.Point(138, 92);
            this.Greens.Maximum = 255;
            this.Greens.Name = "Greens";
            this.Greens.Size = new System.Drawing.Size(120, 17);
            this.Greens.TabIndex = 17;
            this.Greens.ValueChanged += new System.EventHandler(this.Greens_ValueChanged);
            // 
            // Blues
            // 
            this.Blues.Location = new System.Drawing.Point(264, 92);
            this.Blues.Maximum = 255;
            this.Blues.Name = "Blues";
            this.Blues.Size = new System.Drawing.Size(120, 17);
            this.Blues.TabIndex = 18;
            this.Blues.ValueChanged += new System.EventHandler(this.Blues_ValueChanged);
            // 
            // Done
            // 
            this.Done.Location = new System.Drawing.Point(138, 391);
            this.Done.Name = "Done";
            this.Done.Size = new System.Drawing.Size(120, 47);
            this.Done.TabIndex = 19;
            this.Done.Text = "Done";
            this.Done.UseVisualStyleBackColor = true;
            this.Done.Click += new System.EventHandler(this.Done_Click);
            // 
            // Colorpicker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(405, 450);
            this.Controls.Add(this.Done);
            this.Controls.Add(this.Blues);
            this.Controls.Add(this.Greens);
            this.Controls.Add(this.Reds);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Blue);
            this.Controls.Add(this.Green);
            this.Controls.Add(this.Red);
            this.Controls.Add(this.colorshow);
            this.Name = "Colorpicker";
            this.Text = "Color picker";
            this.Load += new System.EventHandler(this.Colorpicker_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Red)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Green)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Blue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button colorshow;
        private System.Windows.Forms.NumericUpDown Red;
        private System.Windows.Forms.NumericUpDown Green;
        private System.Windows.Forms.NumericUpDown Blue;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.HScrollBar Reds;
        private System.Windows.Forms.HScrollBar Greens;
        private System.Windows.Forms.HScrollBar Blues;
        private System.Windows.Forms.Button Done;
    }
}