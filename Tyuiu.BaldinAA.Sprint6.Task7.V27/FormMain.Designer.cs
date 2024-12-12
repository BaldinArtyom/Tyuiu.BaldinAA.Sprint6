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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panel1 = new Panel();
            buttonHelp = new Button();
            buttonSave = new Button();
            buttonLoad = new Button();
            panel2 = new Panel();
            GridInput = new DataGridView();
            panel3 = new Panel();
            GridOutput = new DataGridView();
            openFileDialogTask = new OpenFileDialog();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridInput).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)GridOutput).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(buttonHelp);
            panel1.Controls.Add(buttonSave);
            panel1.Controls.Add(buttonLoad);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(1089, 125);
            panel1.TabIndex = 0;
            // 
            // buttonHelp
            // 
            buttonHelp.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp.Image = (Image)resources.GetObject("buttonHelp.Image");
            buttonHelp.Location = new Point(983, 12);
            buttonHelp.Name = "buttonHelp";
            buttonHelp.Size = new Size(94, 94);
            buttonHelp.TabIndex = 0;
            buttonHelp.UseVisualStyleBackColor = true;
            buttonHelp.Click += buttonHelp_Click;
            // 
            // buttonSave
            // 
            buttonSave.Image = (Image)resources.GetObject("buttonSave.Image");
            buttonSave.Location = new Point(112, 12);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(94, 94);
            buttonSave.TabIndex = 0;
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonLoad
            // 
            buttonLoad.Image = (Image)resources.GetObject("buttonLoad.Image");
            buttonLoad.Location = new Point(12, 12);
            buttonLoad.Name = "buttonLoad";
            buttonLoad.Size = new Size(94, 94);
            buttonLoad.TabIndex = 0;
            buttonLoad.UseVisualStyleBackColor = true;
            buttonLoad.Click += buttonLoad_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(GridInput);
            panel2.Dock = DockStyle.Left;
            panel2.Location = new Point(0, 125);
            panel2.Name = "panel2";
            panel2.Size = new Size(565, 591);
            panel2.TabIndex = 0;
            // 
            // GridInput
            // 
            GridInput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridInput.ColumnHeadersVisible = false;
            GridInput.Dock = DockStyle.Fill;
            GridInput.Location = new Point(0, 0);
            GridInput.Name = "GridInput";
            GridInput.RowHeadersVisible = false;
            GridInput.RowHeadersWidth = 51;
            GridInput.Size = new Size(565, 591);
            GridInput.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(GridOutput);
            panel3.Dock = DockStyle.Fill;
            panel3.Location = new Point(565, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(524, 591);
            panel3.TabIndex = 0;
            // 
            // GridOutput
            // 
            GridOutput.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            GridOutput.ColumnHeadersVisible = false;
            GridOutput.Dock = DockStyle.Fill;
            GridOutput.Location = new Point(0, 0);
            GridOutput.Name = "GridOutput";
            GridOutput.RowHeadersVisible = false;
            GridOutput.RowHeadersWidth = 51;
            GridOutput.Size = new Size(524, 591);
            GridOutput.TabIndex = 0;
            // 
            // openFileDialogTask
            // 
            openFileDialogTask.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1089, 716);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "FormMain";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridInput).EndInit();
            panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)GridOutput).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Panel panel3;
        private Button buttonHelp;
        private Button buttonSave;
        private Button buttonLoad;
        private DataGridView GridInput;
        private DataGridView GridOutput;
        private OpenFileDialog openFileDialogTask;

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
