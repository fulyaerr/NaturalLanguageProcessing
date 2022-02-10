namespace NaturalLanguageProcessing
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.buttonTokenize = new System.Windows.Forms.Button();
            this.txtTokenize = new System.Windows.Forms.TextBox();
            this.txtRoot = new System.Windows.Forms.TextBox();
            this.btnFindRoot = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDosyaSec = new System.Windows.Forms.Button();
            this.btnNormalize = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(680, 182);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(156, 46);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Veri Temizleme";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(60, 26);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(776, 150);
            this.textBox1.TabIndex = 1;
            // 
            // buttonTokenize
            // 
            this.buttonTokenize.Location = new System.Drawing.Point(856, 26);
            this.buttonTokenize.Name = "buttonTokenize";
            this.buttonTokenize.Size = new System.Drawing.Size(228, 46);
            this.buttonTokenize.TabIndex = 2;
            this.buttonTokenize.Text = "Tokenize";
            this.buttonTokenize.UseVisualStyleBackColor = true;
            this.buttonTokenize.Click += new System.EventHandler(this.buttonTokenize_Click);
            // 
            // txtTokenize
            // 
            this.txtTokenize.Location = new System.Drawing.Point(856, 78);
            this.txtTokenize.Multiline = true;
            this.txtTokenize.Name = "txtTokenize";
            this.txtTokenize.Size = new System.Drawing.Size(228, 514);
            this.txtTokenize.TabIndex = 3;
            // 
            // txtRoot
            // 
            this.txtRoot.Location = new System.Drawing.Point(60, 234);
            this.txtRoot.Multiline = true;
            this.txtRoot.Name = "txtRoot";
            this.txtRoot.Size = new System.Drawing.Size(776, 150);
            this.txtRoot.TabIndex = 4;
            // 
            // btnFindRoot
            // 
            this.btnFindRoot.Location = new System.Drawing.Point(60, 390);
            this.btnFindRoot.Name = "btnFindRoot";
            this.btnFindRoot.Size = new System.Drawing.Size(156, 46);
            this.btnFindRoot.TabIndex = 5;
            this.btnFindRoot.Text = "Kökleri Bul";
            this.btnFindRoot.UseVisualStyleBackColor = true;
            this.btnFindRoot.Click += new System.EventHandler(this.btnFindRoot_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(60, 442);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(776, 150);
            this.textBox3.TabIndex = 6;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(1109, 78);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(630, 514);
            this.dataGridView1.TabIndex = 7;
            // 
            // btnDosyaSec
            // 
            this.btnDosyaSec.Location = new System.Drawing.Point(1109, 26);
            this.btnDosyaSec.Name = "btnDosyaSec";
            this.btnDosyaSec.Size = new System.Drawing.Size(228, 46);
            this.btnDosyaSec.TabIndex = 8;
            this.btnDosyaSec.Text = "Dosya Seç";
            this.btnDosyaSec.UseVisualStyleBackColor = true;
            this.btnDosyaSec.Click += new System.EventHandler(this.btnDosyaSec_Click);
            // 
            // btnNormalize
            // 
            this.btnNormalize.Location = new System.Drawing.Point(507, 182);
            this.btnNormalize.Name = "btnNormalize";
            this.btnNormalize.Size = new System.Drawing.Size(156, 46);
            this.btnNormalize.TabIndex = 9;
            this.btnNormalize.Text = "Normalize Et";
            this.btnNormalize.UseVisualStyleBackColor = true;
            this.btnNormalize.Click += new System.EventHandler(this.btnNormalize_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1761, 639);
            this.Controls.Add(this.btnNormalize);
            this.Controls.Add(this.btnDosyaSec);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.btnFindRoot);
            this.Controls.Add(this.txtRoot);
            this.Controls.Add(this.txtTokenize);
            this.Controls.Add(this.buttonTokenize);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.buttonClear);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button buttonTokenize;
        private System.Windows.Forms.TextBox txtTokenize;
        private System.Windows.Forms.TextBox txtRoot;
        private System.Windows.Forms.Button btnFindRoot;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDosyaSec;
        private System.Windows.Forms.Button btnNormalize;
    }
}

