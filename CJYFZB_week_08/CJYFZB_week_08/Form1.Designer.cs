﻿namespace CJYFZB_week_08
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
            this.dgw_Ticks = new System.Windows.Forms.DataGridView();
            this.dgw_Portfolio = new System.Windows.Forms.DataGridView();
            this.btn_Save = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Ticks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Portfolio)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Ticks
            // 
            this.dgw_Ticks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Ticks.Location = new System.Drawing.Point(12, 12);
            this.dgw_Ticks.Name = "dgw_Ticks";
            this.dgw_Ticks.RowHeadersWidth = 62;
            this.dgw_Ticks.RowTemplate.Height = 28;
            this.dgw_Ticks.Size = new System.Drawing.Size(447, 426);
            this.dgw_Ticks.TabIndex = 0;
            // 
            // dgw_Portfolio
            // 
            this.dgw_Portfolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Portfolio.Location = new System.Drawing.Point(466, 13);
            this.dgw_Portfolio.Name = "dgw_Portfolio";
            this.dgw_Portfolio.RowHeadersWidth = 62;
            this.dgw_Portfolio.RowTemplate.Height = 28;
            this.dgw_Portfolio.Size = new System.Drawing.Size(240, 425);
            this.dgw_Portfolio.TabIndex = 1;
            // 
            // btn_Save
            // 
            this.btn_Save.Location = new System.Drawing.Point(713, 203);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(75, 55);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Save);
            this.Controls.Add(this.dgw_Portfolio);
            this.Controls.Add(this.dgw_Ticks);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Ticks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Portfolio)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgw_Ticks;
        private System.Windows.Forms.DataGridView dgw_Portfolio;
        private System.Windows.Forms.Button btn_Save;
    }
}

