namespace CJYFZB_week_06
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.dgw_Rates = new System.Windows.Forms.DataGridView();
            this.chart_RateData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.comboBox_Currencies = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgw_Rates)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.chart_RateData)).BeginInit();
            this.SuspendLayout();
            // 
            // dgw_Rates
            // 
            this.dgw_Rates.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgw_Rates.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgw_Rates.Location = new System.Drawing.Point(12, 68);
            this.dgw_Rates.Name = "dgw_Rates";
            this.dgw_Rates.RowHeadersWidth = 62;
            this.dgw_Rates.RowTemplate.Height = 28;
            this.dgw_Rates.Size = new System.Drawing.Size(406, 370);
            this.dgw_Rates.TabIndex = 0;
            // 
            // chart_RateData
            // 
            this.chart_RateData.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            chartArea5.Name = "ChartArea1";
            this.chart_RateData.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.chart_RateData.Legends.Add(legend5);
            this.chart_RateData.Location = new System.Drawing.Point(424, 68);
            this.chart_RateData.Name = "chart_RateData";
            series5.ChartArea = "ChartArea1";
            series5.Legend = "Legend1";
            series5.Name = "Series1";
            this.chart_RateData.Series.Add(series5);
            this.chart_RateData.Size = new System.Drawing.Size(465, 370);
            this.chart_RateData.TabIndex = 1;
            this.chart_RateData.Text = "chart1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(12, 12);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker1.TabIndex = 2;
            this.dateTimePicker1.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(218, 12);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker2.TabIndex = 3;
            this.dateTimePicker2.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // comboBox_Currencies
            // 
            this.comboBox_Currencies.FormattingEnabled = true;
            this.comboBox_Currencies.Location = new System.Drawing.Point(424, 10);
            this.comboBox_Currencies.Name = "comboBox_Currencies";
            this.comboBox_Currencies.Size = new System.Drawing.Size(121, 28);
            this.comboBox_Currencies.TabIndex = 4;
            this.comboBox_Currencies.Text = "EUR";
            this.comboBox_Currencies.SelectedIndexChanged += new System.EventHandler(this.comboBox_Currencies_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 450);
            this.Controls.Add(this.comboBox_Currencies);
            this.Controls.Add(this.dateTimePicker2);
            this.Controls.Add(this.dateTimePicker1);
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
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.ComboBox comboBox_Currencies;
    }
}

