namespace Paint
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.Timer1 = new System.Windows.Forms.Timer(this.components);
            this.hScrollBar1 = new System.Windows.Forms.HScrollBar();
            this.orange = new System.Windows.Forms.Button();
            this.red = new System.Windows.Forms.Button();
            this.green = new System.Windows.Forms.Button();
            this.lime = new System.Windows.Forms.Button();
            this.blue = new System.Windows.Forms.Button();
            this.cyan = new System.Windows.Forms.Button();
            this.purple = new System.Windows.Forms.Button();
            this.yellow = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Timer1
            // 
            this.Timer1.Interval = 1;
            this.Timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // hScrollBar1
            // 
            this.hScrollBar1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.hScrollBar1.Location = new System.Drawing.Point(9, 424);
            this.hScrollBar1.Name = "hScrollBar1";
            this.hScrollBar1.Size = new System.Drawing.Size(779, 17);
            this.hScrollBar1.TabIndex = 4;
            this.hScrollBar1.ValueChanged += new System.EventHandler(this.hScrollBar1_ValueChanged);
            // 
            // orange
            // 
            this.orange.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.orange.BackColor = System.Drawing.Color.Orange;
            this.orange.Location = new System.Drawing.Point(40, 293);
            this.orange.Name = "orange";
            this.orange.Size = new System.Drawing.Size(25, 25);
            this.orange.TabIndex = 13;
            this.orange.UseVisualStyleBackColor = false;
            this.orange.Click += new System.EventHandler(this.orange_Click);
            // 
            // red
            // 
            this.red.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.red.BackColor = System.Drawing.Color.Red;
            this.red.Location = new System.Drawing.Point(9, 293);
            this.red.Name = "red";
            this.red.Size = new System.Drawing.Size(25, 25);
            this.red.TabIndex = 14;
            this.red.UseVisualStyleBackColor = false;
            this.red.Click += new System.EventHandler(this.red_Click);
            // 
            // green
            // 
            this.green.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.green.BackColor = System.Drawing.Color.Green;
            this.green.Location = new System.Drawing.Point(40, 355);
            this.green.Name = "green";
            this.green.Size = new System.Drawing.Size(25, 25);
            this.green.TabIndex = 15;
            this.green.UseVisualStyleBackColor = false;
            this.green.Click += new System.EventHandler(this.green_Click);
            // 
            // lime
            // 
            this.lime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lime.BackColor = System.Drawing.Color.Lime;
            this.lime.Location = new System.Drawing.Point(40, 324);
            this.lime.Name = "lime";
            this.lime.Size = new System.Drawing.Size(25, 25);
            this.lime.TabIndex = 16;
            this.lime.UseVisualStyleBackColor = false;
            this.lime.Click += new System.EventHandler(this.lime_Click);
            // 
            // blue
            // 
            this.blue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.blue.BackColor = System.Drawing.Color.Blue;
            this.blue.Location = new System.Drawing.Point(9, 386);
            this.blue.Name = "blue";
            this.blue.Size = new System.Drawing.Size(25, 25);
            this.blue.TabIndex = 17;
            this.blue.UseVisualStyleBackColor = false;
            this.blue.Click += new System.EventHandler(this.blue_Click);
            // 
            // cyan
            // 
            this.cyan.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cyan.BackColor = System.Drawing.Color.Cyan;
            this.cyan.Location = new System.Drawing.Point(9, 355);
            this.cyan.Name = "cyan";
            this.cyan.Size = new System.Drawing.Size(25, 25);
            this.cyan.TabIndex = 18;
            this.cyan.UseVisualStyleBackColor = false;
            this.cyan.Click += new System.EventHandler(this.cyan_Click);
            // 
            // purple
            // 
            this.purple.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.purple.BackColor = System.Drawing.Color.Purple;
            this.purple.Location = new System.Drawing.Point(40, 386);
            this.purple.Name = "purple";
            this.purple.Size = new System.Drawing.Size(25, 25);
            this.purple.TabIndex = 19;
            this.purple.UseVisualStyleBackColor = false;
            this.purple.Click += new System.EventHandler(this.purple_Click);
            // 
            // yellow
            // 
            this.yellow.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.yellow.BackColor = System.Drawing.Color.Yellow;
            this.yellow.Location = new System.Drawing.Point(9, 324);
            this.yellow.Name = "yellow";
            this.yellow.Size = new System.Drawing.Size(25, 25);
            this.yellow.TabIndex = 20;
            this.yellow.UseVisualStyleBackColor = false;
            this.yellow.Click += new System.EventHandler(this.yellow_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(9, 253);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "new color";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.yellow);
            this.Controls.Add(this.purple);
            this.Controls.Add(this.cyan);
            this.Controls.Add(this.blue);
            this.Controls.Add(this.lime);
            this.Controls.Add(this.green);
            this.Controls.Add(this.red);
            this.Controls.Add(this.orange);
            this.Controls.Add(this.hScrollBar1);
            this.Name = "Form1";
            this.Text = "Paint";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Timer Timer1;
        private System.Windows.Forms.HScrollBar hScrollBar1;
        private System.Windows.Forms.Button orange;
        private System.Windows.Forms.Button red;
        private System.Windows.Forms.Button green;
        private System.Windows.Forms.Button lime;
        private System.Windows.Forms.Button blue;
        private System.Windows.Forms.Button cyan;
        private System.Windows.Forms.Button purple;
        private System.Windows.Forms.Button yellow;
        private System.Windows.Forms.Button button1;
    }
}

