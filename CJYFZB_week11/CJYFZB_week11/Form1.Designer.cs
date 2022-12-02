namespace CJYFZB_week11
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
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Startbtn_Startbtn_Start = new System.Windows.Forms.Button();
            this.btn_Browse = new System.Windows.Forms.Button();
            this.nud_Year = new System.Windows.Forms.NumericUpDown();
            this.textBox_Eleres = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).BeginInit();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.richTextBox1.Location = new System.Drawing.Point(13, 78);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(775, 360);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Záróév:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(232, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Népesség fájl:";
            // 
            // btn_Startbtn_Startbtn_Start
            // 
            this.btn_Startbtn_Startbtn_Start.Location = new System.Drawing.Point(584, 26);
            this.btn_Startbtn_Startbtn_Start.Name = "btn_Startbtn_Startbtn_Start";
            this.btn_Startbtn_Startbtn_Start.Size = new System.Drawing.Size(100, 35);
            this.btn_Startbtn_Startbtn_Start.TabIndex = 3;
            this.btn_Startbtn_Startbtn_Start.Text = "Start";
            this.btn_Startbtn_Startbtn_Start.UseVisualStyleBackColor = true;
            this.btn_Startbtn_Startbtn_Start.Click += new System.EventHandler(this.btn_Startbtn_Startbtn_Start_Click);
            // 
            // btn_Browse
            // 
            this.btn_Browse.Location = new System.Drawing.Point(690, 26);
            this.btn_Browse.Name = "btn_Browse";
            this.btn_Browse.Size = new System.Drawing.Size(100, 35);
            this.btn_Browse.TabIndex = 4;
            this.btn_Browse.Text = "Browse";
            this.btn_Browse.UseVisualStyleBackColor = true;
            this.btn_Browse.Click += new System.EventHandler(this.btn_Browse_Click);
            // 
            // nud_Year
            // 
            this.nud_Year.Location = new System.Drawing.Point(82, 27);
            this.nud_Year.Name = "nud_Year";
            this.nud_Year.Size = new System.Drawing.Size(120, 26);
            this.nud_Year.TabIndex = 5;
            // 
            // textBox_Eleres
            // 
            this.textBox_Eleres.Location = new System.Drawing.Point(348, 27);
            this.textBox_Eleres.Name = "textBox_Eleres";
            this.textBox_Eleres.Size = new System.Drawing.Size(216, 26);
            this.textBox_Eleres.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox_Eleres);
            this.Controls.Add(this.nud_Year);
            this.Controls.Add(this.btn_Browse);
            this.Controls.Add(this.btn_Startbtn_Startbtn_Start);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nud_Year)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Startbtn_Startbtn_Start;
        private System.Windows.Forms.Button btn_Browse;
        private System.Windows.Forms.NumericUpDown nud_Year;
        private System.Windows.Forms.TextBox textBox_Eleres;
    }
}

