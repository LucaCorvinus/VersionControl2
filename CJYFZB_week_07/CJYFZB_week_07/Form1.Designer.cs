namespace CJYFZB_week_07
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.createTimer = new System.Windows.Forms.Timer(this.components);
            this.conveyorTimer = new System.Windows.Forms.Timer(this.components);
            this.btn_Car = new System.Windows.Forms.Button();
            this.btn_Ball = new System.Windows.Forms.Button();
            this.lbl_Next = new System.Windows.Forms.Label();
            this.btn_BallColor = new System.Windows.Forms.Button();
            this.btn_Present = new System.Windows.Forms.Button();
            this.btn_BoxColor = new System.Windows.Forms.Button();
            this.btn_RibbonColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.Location = new System.Drawing.Point(12, 252);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(784, 194);
            this.mainPanel.TabIndex = 0;
            // 
            // createTimer
            // 
            this.createTimer.Enabled = true;
            this.createTimer.Interval = 3000;
            this.createTimer.Tick += new System.EventHandler(this.createTimer_Tick);
            // 
            // conveyorTimer
            // 
            this.conveyorTimer.Enabled = true;
            this.conveyorTimer.Interval = 10;
            this.conveyorTimer.Tick += new System.EventHandler(this.conveyorTimer_Tick);
            // 
            // btn_Car
            // 
            this.btn_Car.Location = new System.Drawing.Point(12, 24);
            this.btn_Car.Name = "btn_Car";
            this.btn_Car.Size = new System.Drawing.Size(94, 54);
            this.btn_Car.TabIndex = 1;
            this.btn_Car.Text = "CAR";
            this.btn_Car.UseVisualStyleBackColor = true;
            this.btn_Car.Click += new System.EventHandler(this.btn_Car_Click);
            // 
            // btn_Ball
            // 
            this.btn_Ball.Location = new System.Drawing.Point(127, 24);
            this.btn_Ball.Name = "btn_Ball";
            this.btn_Ball.Size = new System.Drawing.Size(94, 54);
            this.btn_Ball.TabIndex = 2;
            this.btn_Ball.Text = "BALL";
            this.btn_Ball.UseVisualStyleBackColor = true;
            this.btn_Ball.Click += new System.EventHandler(this.btn_Ball_Click);
            // 
            // lbl_Next
            // 
            this.lbl_Next.AutoSize = true;
            this.lbl_Next.Location = new System.Drawing.Point(12, 95);
            this.lbl_Next.Name = "lbl_Next";
            this.lbl_Next.Size = new System.Drawing.Size(103, 20);
            this.lbl_Next.TabIndex = 3;
            this.lbl_Next.Text = "Coming Next:";
            // 
            // btn_BallColor
            // 
            this.btn_BallColor.BackColor = System.Drawing.Color.SteelBlue;
            this.btn_BallColor.Location = new System.Drawing.Point(237, 24);
            this.btn_BallColor.Name = "btn_BallColor";
            this.btn_BallColor.Size = new System.Drawing.Size(93, 54);
            this.btn_BallColor.TabIndex = 4;
            this.btn_BallColor.Text = "Ball Color";
            this.btn_BallColor.UseVisualStyleBackColor = false;
            this.btn_BallColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_Present
            // 
            this.btn_Present.Location = new System.Drawing.Point(349, 24);
            this.btn_Present.Name = "btn_Present";
            this.btn_Present.Size = new System.Drawing.Size(113, 54);
            this.btn_Present.TabIndex = 5;
            this.btn_Present.Text = "PRESENT";
            this.btn_Present.UseVisualStyleBackColor = true;
            this.btn_Present.Click += new System.EventHandler(this.btn_Present_Click);
            // 
            // btn_BoxColor
            // 
            this.btn_BoxColor.Location = new System.Drawing.Point(349, 95);
            this.btn_BoxColor.Name = "btn_BoxColor";
            this.btn_BoxColor.Size = new System.Drawing.Size(113, 33);
            this.btn_BoxColor.TabIndex = 6;
            this.btn_BoxColor.Text = "Box Color";
            this.btn_BoxColor.UseVisualStyleBackColor = true;
            this.btn_BoxColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_RibbonColor
            // 
            this.btn_RibbonColor.Location = new System.Drawing.Point(349, 146);
            this.btn_RibbonColor.Name = "btn_RibbonColor";
            this.btn_RibbonColor.Size = new System.Drawing.Size(113, 33);
            this.btn_RibbonColor.TabIndex = 7;
            this.btn_RibbonColor.Text = "Ribbon Color";
            this.btn_RibbonColor.UseVisualStyleBackColor = true;
            this.btn_RibbonColor.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_RibbonColor);
            this.Controls.Add(this.btn_BoxColor);
            this.Controls.Add(this.btn_Present);
            this.Controls.Add(this.btn_BallColor);
            this.Controls.Add(this.lbl_Next);
            this.Controls.Add(this.btn_Ball);
            this.Controls.Add(this.btn_Car);
            this.Controls.Add(this.mainPanel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Timer createTimer;
        private System.Windows.Forms.Timer conveyorTimer;
        private System.Windows.Forms.Button btn_Car;
        private System.Windows.Forms.Button btn_Ball;
        private System.Windows.Forms.Label lbl_Next;
        private System.Windows.Forms.Button btn_BallColor;
        private System.Windows.Forms.Button btn_Present;
        private System.Windows.Forms.Button btn_BoxColor;
        private System.Windows.Forms.Button btn_RibbonColor;
    }
}

