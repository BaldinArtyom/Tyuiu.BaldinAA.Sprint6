namespace Tyuiu.BaldinAA.Sprint6.Task4.V11
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            panelData = new Panel();
            panel1 = new Panel();
            panelDataInput_TAV = new Panel();
            panel3 = new Panel();
            buttonSave_TAV = new Button();
            buttonResult_TAV = new Button();
            buttonData_TAV = new Button();
            groupBoxDataInput_TAV = new GroupBox();
            textBoxStopStep_TAV = new TextBox();
            textBoxStartStep_TAV = new TextBox();
            textBoxVarStopStep_TAV = new TextBox();
            textBoxVarStartStep_TAV = new TextBox();
            groupBoxCondition_TAV = new GroupBox();
            textBox1 = new TextBox();
            panel2 = new Panel();
            groupBoxDataOutput = new GroupBox();
            textBoxResult = new TextBox();
            splitter1 = new Splitter();
            panel4 = new Panel();
            chartFunction = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelData.SuspendLayout();
            panelDataInput_TAV.SuspendLayout();
            groupBoxDataInput_TAV.SuspendLayout();
            groupBoxCondition_TAV.SuspendLayout();
            panel2.SuspendLayout();
            groupBoxDataOutput.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction).BeginInit();
            SuspendLayout();
            // 
            // panelData
            // 
            panelData.Controls.Add(panel1);
            panelData.Controls.Add(panelDataInput_TAV);
            panelData.Controls.Add(buttonSave_TAV);
            panelData.Controls.Add(buttonResult_TAV);
            panelData.Controls.Add(buttonData_TAV);
            panelData.Controls.Add(groupBoxDataInput_TAV);
            panelData.Controls.Add(groupBoxCondition_TAV);
            panelData.Dock = DockStyle.Top;
            panelData.Location = new Point(0, 0);
            panelData.Name = "panelData";
            panelData.Size = new Size(784, 126);
            panelData.TabIndex = 0;
            // 
            // panel1
            // 
            panel1.Location = new Point(4, 125);
            panel1.Name = "panel1";
            panel1.Size = new Size(285, 282);
            panel1.TabIndex = 4;
            // 
            // panelDataInput_TAV
            // 
            panelDataInput_TAV.Controls.Add(panel3);
            panelDataInput_TAV.Location = new Point(6, 125);
            panelDataInput_TAV.Name = "panelDataInput_TAV";
            panelDataInput_TAV.Size = new Size(285, 287);
            panelDataInput_TAV.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(0, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(285, 287);
            panel3.TabIndex = 0;
            // 
            // buttonSave_TAV
            // 
            buttonSave_TAV.BackColor = Color.FromArgb(128, 128, 255);
            buttonSave_TAV.Location = new Point(692, 57);
            buttonSave_TAV.Name = "buttonSave_TAV";
            buttonSave_TAV.Size = new Size(80, 28);
            buttonSave_TAV.TabIndex = 2;
            buttonSave_TAV.Text = "Сохранить";
            buttonSave_TAV.UseVisualStyleBackColor = false;
            buttonSave_TAV.Click += buttonSave_TAV_Click;
            // 
            // buttonResult_TAV
            // 
            buttonResult_TAV.BackColor = Color.Cyan;
            buttonResult_TAV.Location = new Point(593, 57);
            buttonResult_TAV.Name = "buttonResult_TAV";
            buttonResult_TAV.Size = new Size(80, 28);
            buttonResult_TAV.TabIndex = 2;
            buttonResult_TAV.Text = "Выполнить";
            buttonResult_TAV.UseVisualStyleBackColor = false;
            buttonResult_TAV.Click += buttonResult_TAV_Click;
            // 
            // buttonData_TAV
            // 
            buttonData_TAV.BackColor = Color.Cyan;
            buttonData_TAV.Location = new Point(495, 57);
            buttonData_TAV.Name = "buttonData_TAV";
            buttonData_TAV.Size = new Size(80, 28);
            buttonData_TAV.TabIndex = 2;
            buttonData_TAV.Text = "Справка";
            buttonData_TAV.UseVisualStyleBackColor = false;
            buttonData_TAV.Click += buttonData_TAV_Click;
            // 
            // groupBoxDataInput_TAV
            // 
            groupBoxDataInput_TAV.Controls.Add(textBoxStopStep_TAV);
            groupBoxDataInput_TAV.Controls.Add(textBoxStartStep_TAV);
            groupBoxDataInput_TAV.Controls.Add(textBoxVarStopStep_TAV);
            groupBoxDataInput_TAV.Controls.Add(textBoxVarStartStep_TAV);
            groupBoxDataInput_TAV.Location = new Point(293, 14);
            groupBoxDataInput_TAV.Name = "groupBoxDataInput_TAV";
            groupBoxDataInput_TAV.Size = new Size(199, 106);
            groupBoxDataInput_TAV.TabIndex = 1;
            groupBoxDataInput_TAV.TabStop = false;
            groupBoxDataInput_TAV.Text = "Ввод данных";
            // 
            // textBoxStopStep_TAV
            // 
            textBoxStopStep_TAV.Location = new Point(109, 57);
            textBoxStopStep_TAV.Name = "textBoxStopStep_TAV";
            textBoxStopStep_TAV.Size = new Size(77, 23);
            textBoxStopStep_TAV.TabIndex = 1;
            // 
            // textBoxStartStep_TAV
            // 
            textBoxStartStep_TAV.Location = new Point(6, 57);
            textBoxStartStep_TAV.Name = "textBoxStartStep_TAV";
            textBoxStartStep_TAV.Size = new Size(77, 23);
            textBoxStartStep_TAV.TabIndex = 1;
            textBoxStartStep_TAV.TextChanged += textBoxStartStep_TAV_TextChanged;
            // 
            // textBoxVarStopStep_TAV
            // 
            textBoxVarStopStep_TAV.BackColor = SystemColors.Menu;
            textBoxVarStopStep_TAV.BorderStyle = BorderStyle.None;
            textBoxVarStopStep_TAV.Location = new Point(109, 27);
            textBoxVarStopStep_TAV.Name = "textBoxVarStopStep_TAV";
            textBoxVarStopStep_TAV.Size = new Size(84, 16);
            textBoxVarStopStep_TAV.TabIndex = 0;
            textBoxVarStopStep_TAV.Text = "Конец шага";
            textBoxVarStopStep_TAV.TextAlign = HorizontalAlignment.Center;
            // 
            // textBoxVarStartStep_TAV
            // 
            textBoxVarStartStep_TAV.BackColor = SystemColors.Menu;
            textBoxVarStartStep_TAV.BorderStyle = BorderStyle.None;
            textBoxVarStartStep_TAV.Location = new Point(7, 27);
            textBoxVarStartStep_TAV.Name = "textBoxVarStartStep_TAV";
            textBoxVarStartStep_TAV.Size = new Size(84, 16);
            textBoxVarStartStep_TAV.TabIndex = 0;
            textBoxVarStartStep_TAV.Text = "Старт шага";
            textBoxVarStartStep_TAV.TextAlign = HorizontalAlignment.Center;
            // 
            // groupBoxCondition_TAV
            // 
            groupBoxCondition_TAV.Controls.Add(textBox1);
            groupBoxCondition_TAV.Location = new Point(5, 5);
            groupBoxCondition_TAV.Name = "groupBoxCondition_TAV";
            groupBoxCondition_TAV.Size = new Size(279, 118);
            groupBoxCondition_TAV.TabIndex = 0;
            groupBoxCondition_TAV.TabStop = false;
            groupBoxCondition_TAV.Text = "Условие";
            // 
            // textBox1
            // 
            textBox1.BackColor = SystemColors.Menu;
            textBox1.BorderStyle = BorderStyle.None;
            textBox1.Location = new Point(3, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(272, 99);
            textBox1.TabIndex = 0;
            textBox1.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в textBox, построить график функции и сохранить\r\nв файл OutPutFileTask4V11.txt по нажатию кнопки. ";
            // 
            // panel2
            // 
            panel2.Controls.Add(groupBoxDataOutput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 126);
            panel2.Name = "panel2";
            panel2.Size = new Size(284, 285);
            panel2.TabIndex = 1;
            // 
            // groupBoxDataOutput
            // 
            groupBoxDataOutput.Controls.Add(textBoxResult);
            groupBoxDataOutput.Dock = DockStyle.Fill;
            groupBoxDataOutput.Location = new Point(0, 0);
            groupBoxDataOutput.Name = "groupBoxDataOutput";
            groupBoxDataOutput.Size = new Size(284, 285);
            groupBoxDataOutput.TabIndex = 0;
            groupBoxDataOutput.TabStop = false;
            groupBoxDataOutput.Text = "Вывод данных";
            // 
            // textBoxResult
            // 
            textBoxResult.BackColor = SystemColors.Menu;
            textBoxResult.BorderStyle = BorderStyle.None;
            textBoxResult.Dock = DockStyle.Fill;
            textBoxResult.Location = new Point(3, 19);
            textBoxResult.Multiline = true;
            textBoxResult.Name = "textBoxResult";
            textBoxResult.ReadOnly = true;
            textBoxResult.ScrollBars = ScrollBars.Vertical;
            textBoxResult.Size = new Size(278, 263);
            textBoxResult.TabIndex = 0;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(284, 126);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 285);
            splitter1.TabIndex = 2;
            splitter1.TabStop = false;
            // 
            // panel4
            // 
            panel4.Controls.Add(chartFunction);
            panel4.Dock = DockStyle.Fill;
            panel4.Location = new Point(287, 126);
            panel4.Name = "panel4";
            panel4.Size = new Size(497, 285);
            panel4.TabIndex = 3;
            // 
            // chartFunction
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction.ChartAreas.Add(chartArea1);
            chartFunction.Dock = DockStyle.Fill;
            chartFunction.Location = new Point(0, 0);
            chartFunction.Name = "chartFunction";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.Name = "Series1";
            chartFunction.Series.Add(series1);
            chartFunction.Size = new Size(497, 285);
            chartFunction.TabIndex = 0;
            chartFunction.Text = "chart1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(panel4);
            Controls.Add(splitter1);
            Controls.Add(panel2);
            Controls.Add(panelData);
            MinimumSize = new Size(800, 450);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 11 | Талалаева А.В.";
            panelData.ResumeLayout(false);
            panelDataInput_TAV.ResumeLayout(false);
            groupBoxDataInput_TAV.ResumeLayout(false);
            groupBoxDataInput_TAV.PerformLayout();
            groupBoxCondition_TAV.ResumeLayout(false);
            groupBoxCondition_TAV.PerformLayout();
            panel2.ResumeLayout(false);
            groupBoxDataOutput.ResumeLayout(false);
            groupBoxDataOutput.PerformLayout();
            panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelData;
        private GroupBox groupBoxCondition_TAV;
        private GroupBox groupBoxDataInput_TAV;
        private TextBox textBox1;
        private TextBox textBoxVarStopStep_TAV;
        private TextBox textBoxVarStartStep_TAV;
        private Button buttonSave_TAV;
        private Button buttonResult_TAV;
        private Button buttonData_TAV;
        private TextBox textBoxStopStep_TAV;
        private TextBox textBoxStartStep_TAV;
        private Panel panel1;
        private Panel panelDataInput_TAV;
        private Panel panel2;
        private GroupBox groupBoxDataOutput;
        private Panel panel3;
        private TextBox textBoxResult;
        private Splitter splitter1;
        private Panel panel4;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction;
    }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "Form1";
        }

        #endregion
    }
}
