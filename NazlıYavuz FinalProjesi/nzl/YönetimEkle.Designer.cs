﻿namespace nzl
{
    partial class YönetimEkle
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(YönetimEkle));
			this.dataGridView1 = new System.Windows.Forms.DataGridView();
			this.button2 = new System.Windows.Forms.Button();
			this.textBox2 = new System.Windows.Forms.TextBox();
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.button1 = new System.Windows.Forms.Button();
			this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
			this.button3 = new System.Windows.Forms.Button();
			this.button4 = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
			this.SuspendLayout();
			// 
			// dataGridView1
			// 
			this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
			this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dataGridView1.Location = new System.Drawing.Point(537, 30);
			this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
			this.dataGridView1.Name = "dataGridView1";
			this.dataGridView1.RowHeadersWidth = 51;
			this.dataGridView1.Size = new System.Drawing.Size(468, 147);
			this.dataGridView1.TabIndex = 25;
			// 
			// button2
			// 
			this.button2.BackColor = System.Drawing.Color.Transparent;
			this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button2.Location = new System.Drawing.Point(537, 295);
			this.button2.Margin = new System.Windows.Forms.Padding(4);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(468, 69);
			this.button2.TabIndex = 24;
			this.button2.Text = "Yönetici Listesini Göster";
			this.button2.UseVisualStyleBackColor = false;
			this.button2.Click += new System.EventHandler(this.button2_Click);
			// 
			// textBox2
			// 
			this.textBox2.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.textBox2.Location = new System.Drawing.Point(32, 218);
			this.textBox2.Margin = new System.Windows.Forms.Padding(4);
			this.textBox2.Name = "textBox2";
			this.textBox2.Size = new System.Drawing.Size(224, 22);
			this.textBox2.TabIndex = 20;
			// 
			// textBox1
			// 
			this.textBox1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.textBox1.Location = new System.Drawing.Point(32, 101);
			this.textBox1.Margin = new System.Windows.Forms.Padding(4);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(224, 22);
			this.textBox1.TabIndex = 19;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label3.Location = new System.Drawing.Point(27, 268);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(150, 25);
			this.label3.TabIndex = 16;
			this.label3.Text = "Yöneticinin Tipi:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label2.Location = new System.Drawing.Point(27, 152);
			this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(175, 25);
			this.label2.TabIndex = 15;
			this.label2.Text = "Yöneticinin Görevi:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.label1.Location = new System.Drawing.Point(27, 41);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(207, 25);
			this.label1.TabIndex = 14;
			this.label1.Text = "Yöneticinin Ad-Soyad:";
			// 
			// button1
			// 
			this.button1.BackColor = System.Drawing.Color.Transparent;
			this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button1.Location = new System.Drawing.Point(537, 208);
			this.button1.Margin = new System.Windows.Forms.Padding(4);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(468, 69);
			this.button1.TabIndex = 13;
			this.button1.Text = "Yöneticiyi Ekle";
			this.button1.UseVisualStyleBackColor = false;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// numericUpDown1
			// 
			this.numericUpDown1.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.numericUpDown1.Location = new System.Drawing.Point(32, 322);
			this.numericUpDown1.Margin = new System.Windows.Forms.Padding(4);
			this.numericUpDown1.Maximum = new decimal(new int[] {
            13,
            0,
            0,
            0});
			this.numericUpDown1.Minimum = new decimal(new int[] {
            11,
            0,
            0,
            0});
			this.numericUpDown1.Name = "numericUpDown1";
			this.numericUpDown1.Size = new System.Drawing.Size(160, 22);
			this.numericUpDown1.TabIndex = 26;
			this.numericUpDown1.Value = new decimal(new int[] {
            11,
            0,
            0,
            0});
			// 
			// button3
			// 
			this.button3.BackColor = System.Drawing.Color.Transparent;
			this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button3.Location = new System.Drawing.Point(537, 382);
			this.button3.Margin = new System.Windows.Forms.Padding(4);
			this.button3.Name = "button3";
			this.button3.Size = new System.Drawing.Size(468, 69);
			this.button3.TabIndex = 27;
			this.button3.Text = "Yönetici Bilgisini Güncelle";
			this.button3.UseVisualStyleBackColor = false;
			this.button3.Click += new System.EventHandler(this.button3_Click);
			// 
			// button4
			// 
			this.button4.BackColor = System.Drawing.Color.Transparent;
			this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
			this.button4.Location = new System.Drawing.Point(537, 459);
			this.button4.Margin = new System.Windows.Forms.Padding(4);
			this.button4.Name = "button4";
			this.button4.Size = new System.Drawing.Size(468, 69);
			this.button4.TabIndex = 28;
			this.button4.Text = "Yönetici Ara";
			this.button4.UseVisualStyleBackColor = false;
			// 
			// YönetimEkle
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveBorder;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
			this.ClientSize = new System.Drawing.Size(1067, 554);
			this.Controls.Add(this.button4);
			this.Controls.Add(this.button3);
			this.Controls.Add(this.numericUpDown1);
			this.Controls.Add(this.dataGridView1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.textBox2);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.DoubleBuffered = true;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Margin = new System.Windows.Forms.Padding(4);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "YönetimEkle";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Yönetim";
			((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}