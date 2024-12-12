namespace Tyuiu.BaldinAA.Sprint6.Task6.V26
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            buttonOpen = new Button();
            buttonDone = new Button();
            buttonHelp = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            textBoxTask = new TextBox();
            labelTask = new Label();
            panel3 = new Panel();
            textBoxInput = new TextBox();
            labelInput = new Label();
            panel4 = new Panel();
            textBoxOutput = new TextBox();
            labelOutput = new Label();
            openFileDialogTask = new OpenFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // buttonOpen
            // 
            buttonOpen.Location = new Point(0, 0);
            buttonOpen.Name = "buttonOpen";
            buttonOpen.Size = new Size(79, 64);
            buttonOpen.TabIndex = 0;
            buttonOpen.Text = "Открыть файл";
            buttonOpen.UseVisualStyleBackColor = true;
            buttonOpen.Click += buttonOpen_Click;
            // 
            // buttonDone
            // 
            buttonDone.Enabled = false;
            buttonDone.Location = new Point(85, 0);
            buttonDone.Name = "buttonDone";
            buttonDone.Size = new Size(85, 64);
            buttonDone.TabIndex = 1;
            buttonDone.Text = "Выполнить";
            buttonDone.UseVisualStyleBackColor = true;
            buttonDone.Click += buttonDone_Click;
            // 
            // buttonHelp
            // 
            buttonHelp.Location = new Point(687, 0);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(76, 64);
            buttonHelp.TabIndex = 3;
            buttonHelp.Text = "Помощь";
            buttonHelp.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonOpen);
            panel1.Controls.Add(buttonDone);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 67);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.Controls.Add(textBoxTask);
            panel2.Controls.Add(labelTask);
            panel2.Location = new Point(12, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(763, 74);
            panel2.TabIndex = 5;
            // 
            // textBoxTask
            // 
            textBoxTask.BorderStyle = BorderStyle.None;
            textBoxTask.Location = new Point(12, 30);
            textBoxTask.Multiline = true;
            textBoxTask.Name = "textBoxTask";
            textBoxTask.ReadOnly = true;
            textBoxTask.Size = new Size(670, 37);
            textBoxTask.TabIndex = 1;
            textBoxTask.Text = resources.GetString("textBoxTask.Text");
            // 
            // labelTask
            // 
            labelTask.AutoSize = true;
            labelTask.Location = new Point(12, 7);
            labelTask.Name = "labelTask";
            labelTask.Size = new Size(53, 15);
            labelTask.TabIndex = 0;
            labelTask.Text = "Условие";
            // 
            // panel3
            // 
            panel3.Controls.Add(textBoxInput);
            panel3.Controls.Add(labelInput);
            panel3.Location = new Point(12, 165);
            panel3.Name = "panel3";
            panel3.Size = new Size(382, 273);
            panel3.TabIndex = 6;
            // 
            // textBoxInput
            // 
            textBoxInput.Location = new Point(3, 32);
            textBoxInput.Multiline = true;
            textBoxInput.Name = "textBoxInput";
            textBoxInput.Size = new Size(367, 238);
            textBoxInput.TabIndex = 1;
            // 
            // labelInput
            // 
            labelInput.AutoSize = true;
            labelInput.Location = new Point(12, 14);
            labelInput.Name = "labelInput";
            labelInput.Size = new Size(33, 15);
            labelInput.TabIndex = 0;
            labelInput.Text = "Ввод";
            // 
            // panel4
            // 
            panel4.Controls.Add(textBoxOutput);
            panel4.Controls.Add(labelOutput);
            panel4.Location = new Point(400, 165);
            panel4.Name = "panel4";
            panel4.Size = new Size(375, 273);
            panel4.TabIndex = 7;
            // 
            // textBoxOutput
            // 
            textBoxOutput.Location = new Point(3, 32);
            textBoxOutput.Multiline = true;
            textBoxOutput.Name = "textBoxOutput";
            textBoxOutput.Size = new Size(358, 238);
            textBoxOutput.TabIndex = 1;
            // 
            // labelOutput
            // 
            labelOutput.AutoSize = true;
            labelOutput.Location = new Point(14, 14);
            labelOutput.Name = "labelOutput";
            labelOutput.Size = new Size(42, 15);
            labelOutput.TabIndex = 0;
            labelOutput.Text = "Вывод";
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "outPutFileTask6V26.txt";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "FormMain";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button buttonOpen;
        private Button buttonDone;
        private Button buttonHelp;
        private Panel panel1;
        private Panel panel2;
        private TextBox textBoxTask;
        private Label labelTask;
        private Panel panel3;
        private TextBox textBoxInput;
        private Label labelInput;
        private Panel panel4;
        private TextBox textBoxOutput;
        private Label labelOutput;
        private OpenFileDialog openFileDialogTask;
    }
}
