namespace UserMaintenance
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
            this.listBox_User = new System.Windows.Forms.ListBox();
            this.textBox_FullName = new System.Windows.Forms.TextBox();
            this.label_FullName = new System.Windows.Forms.Label();
            this.button_Add = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // listBox_User
            // 
            this.listBox_User.FormattingEnabled = true;
            this.listBox_User.ItemHeight = 20;
            this.listBox_User.Location = new System.Drawing.Point(13, 52);
            this.listBox_User.Name = "listBox_User";
            this.listBox_User.Size = new System.Drawing.Size(297, 384);
            this.listBox_User.TabIndex = 0;
            // 
            // textBox_FullName
            // 
            this.textBox_FullName.Location = new System.Drawing.Point(450, 52);
            this.textBox_FullName.Name = "textBox_FullName";
            this.textBox_FullName.Size = new System.Drawing.Size(305, 26);
            this.textBox_FullName.TabIndex = 1;
            // 
            // label_FullName
            // 
            this.label_FullName.AutoSize = true;
            this.label_FullName.Location = new System.Drawing.Point(317, 52);
            this.label_FullName.Name = "label_FullName";
            this.label_FullName.Size = new System.Drawing.Size(51, 20);
            this.label_FullName.TabIndex = 3;
            this.label_FullName.Text = "label1";
            // 
            // button_Add
            // 
            this.button_Add.Location = new System.Drawing.Point(450, 103);
            this.button_Add.Name = "button_Add";
            this.button_Add.Size = new System.Drawing.Size(305, 53);
            this.button_Add.TabIndex = 5;
            this.button_Add.Text = "button1";
            this.button_Add.UseVisualStyleBackColor = true;
            this.button_Add.Click += new System.EventHandler(this.button_Add_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button_Add);
            this.Controls.Add(this.label_FullName);
            this.Controls.Add(this.textBox_FullName);
            this.Controls.Add(this.listBox_User);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_User;
        private System.Windows.Forms.TextBox textBox_FullName;
        private System.Windows.Forms.Label label_FullName;
        private System.Windows.Forms.Button button_Add;
    }
}

