namespace Tyuiu.BaldinAA.Sprint6.Task7.V27
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
            panel1 = new Panel();
            buttonSave = new Button();
            buttonHelp = new Button();
            buttonOpen = new Button();
            buttonDone = new Button();
            dataGridViewInput = new DataGridView();
            dataGridViewOutput = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            saveFileDialogTask = new SaveFileDialog();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonOpen);
            panel1.Controls.Add(buttonDone);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 67);
            panel1.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Enabled = false;
            buttonSave.Location = new Point(176, 0);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(89, 63);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Сохранить файл";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
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
            // dataGridViewInput
            // 
            dataGridViewInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewInput.ColumnHeadersVisible = false;
            dataGridViewInput.Location = new Point(14, 96);
            dataGridViewInput.Name = "dataGridViewInput";
            dataGridViewInput.RowHeadersVisible = false;
            dataGridViewInput.Size = new Size(354, 342);
            dataGridViewInput.TabIndex = 6;
            // 
            // dataGridViewOutput
            // 
            dataGridViewOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewOutput.ColumnHeadersVisible = false;
            dataGridViewOutput.Location = new Point(381, 93);
            dataGridViewOutput.Name = "dataGridViewOutput";
            dataGridViewOutput.RowHeadersVisible = false;
            dataGridViewOutput.Size = new Size(394, 345);
            dataGridViewOutput.TabIndex = 7;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridViewOutput);
            Controls.Add(dataGridViewInput);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewInput).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button buttonSave;
        private Button buttonHelp;
        private Button buttonOpen;
        private Button buttonDone;
        private DataGridView dataGridViewInput;
        private DataGridView dataGridViewOutput;
        private OpenFileDialog openFileDialogTask;
        private SaveFileDialog saveFileDialogTask;
    }
}
