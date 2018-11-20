namespace Fill
{
    partial class Lab2
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.AreaAlgo1 = new System.Windows.Forms.TabPage();
            this.AreaAlgo2 = new System.Windows.Forms.TabPage();
            this.Area1 = new System.Windows.Forms.PictureBox();
            this.Area2 = new System.Windows.Forms.PictureBox();
            this.AreaFill1 = new System.Windows.Forms.Button();
            this.AreaFill2 = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.tabControl1.SuspendLayout();
            this.AreaAlgo1.SuspendLayout();
            this.AreaAlgo2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Area1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Area2)).BeginInit();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.AreaAlgo1);
            this.tabControl1.Controls.Add(this.AreaAlgo2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(42, 30);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(718, 408);
            this.tabControl1.TabIndex = 0;
            // 
            // AreaAlgo1
            // 
            this.AreaAlgo1.Controls.Add(this.AreaFill1);
            this.AreaAlgo1.Controls.Add(this.Area1);
            this.AreaAlgo1.Location = new System.Drawing.Point(4, 22);
            this.AreaAlgo1.Name = "AreaAlgo1";
            this.AreaAlgo1.Padding = new System.Windows.Forms.Padding(3);
            this.AreaAlgo1.Size = new System.Drawing.Size(710, 382);
            this.AreaAlgo1.TabIndex = 0;
            this.AreaAlgo1.Text = "Area seed algorythm";
            this.AreaAlgo1.UseVisualStyleBackColor = true;
            // 
            // AreaAlgo2
            // 
            this.AreaAlgo2.Controls.Add(this.AreaFill2);
            this.AreaAlgo2.Controls.Add(this.Area2);
            this.AreaAlgo2.Location = new System.Drawing.Point(4, 22);
            this.AreaAlgo2.Name = "AreaAlgo2";
            this.AreaAlgo2.Padding = new System.Windows.Forms.Padding(3);
            this.AreaAlgo2.Size = new System.Drawing.Size(710, 382);
            this.AreaAlgo2.TabIndex = 1;
            this.AreaAlgo2.Text = "Line area algorythm";
            this.AreaAlgo2.UseVisualStyleBackColor = true;
            // 
            // Area1
            // 
            this.Area1.Location = new System.Drawing.Point(79, 37);
            this.Area1.Name = "Area1";
            this.Area1.Size = new System.Drawing.Size(558, 303);
            this.Area1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Area1.TabIndex = 0;
            this.Area1.TabStop = false;
            // 
            // Area2
            // 
            this.Area2.Location = new System.Drawing.Point(76, 40);
            this.Area2.Name = "Area2";
            this.Area2.Size = new System.Drawing.Size(558, 303);
            this.Area2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Area2.TabIndex = 1;
            this.Area2.TabStop = false;
            // 
            // AreaFill1
            // 
            this.AreaFill1.Location = new System.Drawing.Point(596, 347);
            this.AreaFill1.Name = "AreaFill1";
            this.AreaFill1.Size = new System.Drawing.Size(75, 23);
            this.AreaFill1.TabIndex = 1;
            this.AreaFill1.Text = "Fill";
            this.AreaFill1.UseVisualStyleBackColor = true;
            this.AreaFill1.Click += new System.EventHandler(this.AreaFill1_Click);
            // 
            // AreaFill2
            // 
            this.AreaFill2.Location = new System.Drawing.Point(629, 349);
            this.AreaFill2.Name = "AreaFill2";
            this.AreaFill2.Size = new System.Drawing.Size(75, 23);
            this.AreaFill2.TabIndex = 2;
            this.AreaFill2.Text = "Fill";
            this.AreaFill2.UseVisualStyleBackColor = true;
            this.AreaFill2.Click += new System.EventHandler(this.AreaFill2_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.pictureBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(710, 382);
            this.tabPage1.TabIndex = 2;
            this.tabPage1.Text = "Rectangle line algorythm";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.button2);
            this.tabPage2.Controls.Add(this.pictureBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(710, 382);
            this.tabPage2.TabIndex = 3;
            this.tabPage2.Text = "Rectangle sort algorythm";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(616, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Fill";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(63, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(558, 303);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(620, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 6;
            this.button2.Text = "Fill";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(67, 40);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(558, 303);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // Lab2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Lab2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab2";
            this.Load += new System.EventHandler(this.Lab2_Load);
            this.tabControl1.ResumeLayout(false);
            this.AreaAlgo1.ResumeLayout(false);
            this.AreaAlgo2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Area1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Area2)).EndInit();
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage AreaAlgo1;
        private System.Windows.Forms.TabPage AreaAlgo2;
        private System.Windows.Forms.PictureBox Area1;
        private System.Windows.Forms.PictureBox Area2;
        private System.Windows.Forms.Button AreaFill1;
        private System.Windows.Forms.Button AreaFill2;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

