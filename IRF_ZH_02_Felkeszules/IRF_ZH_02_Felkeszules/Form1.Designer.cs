namespace IRF_ZH_02_Felkeszules
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgw_Rates = new System.Windows.Forms.DataGridView();
            this.chart_RateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker_start = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker_end = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Currencies = new System.Windows.Forms.ComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Rates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RateData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Rates
            // 
            this.dgw_Rates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Rates.Location = new System.Drawing.Point(12, 86);
            this.dgw_Rates.Name = "dgw_Rates";
            this.dgw_Rates.RowHeadersWidth = 62;
            this.dgw_Rates.RowTemplate.Height = 28;
            this.dgw_Rates.Size = new System.Drawing.Size(254, 352);
            this.dgw_Rates.TabIndex = 1;
            // 
            // chart_RateData
            // 
            chartArea1.Name = "ChartArea1";
            this.chart_RateData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart_RateData.Legends.Add(legend1);
            this.chart_RateData.Location = new System.Drawing.Point(295, 86);
            this.chart_RateData.Name = "chart_RateData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chart_RateData.Series.Add(series1);
            this.chart_RateData.Size = new System.Drawing.Size(482, 352);
            this.chart_RateData.TabIndex = 2;
            this.chart_RateData.Text = "chart1";
            // 
            // dateTimePicker_start
            // 
            this.dateTimePicker_start.Location = new System.Drawing.Point(101, 30);
            this.dateTimePicker_start.Name = "dateTimePicker_start";
            this.dateTimePicker_start.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_start.TabIndex = 3;
            this.dateTimePicker_start.ValueChanged += new System.EventHandler(this.dateTimePicker_start_ValueChanged);
            // 
            // dateTimePicker_end
            // 
            this.dateTimePicker_end.Location = new System.Drawing.Point(321, 29);
            this.dateTimePicker_end.Name = "dateTimePicker_end";
            this.dateTimePicker_end.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker_end.TabIndex = 4;
            this.dateTimePicker_end.ValueChanged += new System.EventHandler(this.dateTimePicker_end_ValueChanged);
            // 
            // comboBox_Currencies
            // 
            this.comboBox_Currencies.FormattingEnabled = true;
            this.comboBox_Currencies.Location = new System.Drawing.Point(528, 27);
            this.comboBox_Currencies.Name = "comboBox_Currencies";
            this.comboBox_Currencies.Size = new System.Drawing.Size(231, 28);
            this.comboBox_Currencies.TabIndex = 5;
            this.comboBox_Currencies.Text = "EUR";
            this.comboBox_Currencies.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(13, 13);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(749, 384);
            this.richTextBox1.TabIndex = 6;
            this.richTextBox1.Text = "";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.comboBox_Currencies);
            this.Controls.Add(this.dateTimePicker_end);
            this.Controls.Add(this.dateTimePicker_start);
            this.Controls.Add(this.chart_RateData);
            this.Controls.Add(this.dgw_Rates);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Rates)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RateData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgw_Rates;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart_RateData;
        private System.Windows.Forms.DateTimePicker dateTimePicker_start;
        private System.Windows.Forms.DateTimePicker dateTimePicker_end;
        private System.Windows.Forms.ComboBox comboBox_Currencies;
        private System.Windows.Forms.RichTextBox richTextBox1;
    }
}

