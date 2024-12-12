namespace Tyuiu.BaldinAA.Sprint6.Task6.V14
{
    partial class FormAbout
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            this.pictureBoxAvatar_LAV = new System.Windows.Forms.PictureBox();
            this.buttonClose_LAV = new System.Windows.Forms.Button();
            this.labelInfo_LAV = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LAV)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBoxAvatar_LAV
            // 
            this.pictureBoxAvatar_LAV.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pictureBoxAvatar_LAV.Location = new System.Drawing.Point(23, 30);
            this.pictureBoxAvatar_LAV.Name = "pictureBoxAvatar_LAV";
            this.pictureBoxAvatar_LAV.Size = new System.Drawing.Size(177, 229);
            this.pictureBoxAvatar_LAV.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxAvatar_LAV.TabIndex = 0;
            this.pictureBoxAvatar_LAV.TabStop = false;
            // 
            // buttonClose_LAV
            // 
            this.buttonClose_LAV.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.buttonClose_LAV.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClose_LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonClose_LAV.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.buttonClose_LAV.Location = new System.Drawing.Point(668, 229);
            this.buttonClose_LAV.Name = "buttonClose_LAV";
            this.buttonClose_LAV.Size = new System.Drawing.Size(117, 30);
            this.buttonClose_LAV.TabIndex = 1;
            this.buttonClose_LAV.Text = "ok";
            this.buttonClose_LAV.UseVisualStyleBackColor = false;
            this.buttonClose_LAV.Click += new System.EventHandler(this.buttonClose_LAV_Click);
            // 
            // labelInfo_LAV
            // 
            this.labelInfo_LAV.AutoSize = true;
            this.labelInfo_LAV.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelInfo_LAV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelInfo_LAV.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.labelInfo_LAV.Location = new System.Drawing.Point(224, 30);
            this.labelInfo_LAV.Name = "labelInfo_LAV";
            this.labelInfo_LAV.Size = new System.Drawing.Size(460, 180);
            this.labelInfo_LAV.TabIndex = 2;
            // 
            // FormAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(810, 285);
            this.Controls.Add(this.labelInfo_LAV);
            this.Controls.Add(this.buttonClose_LAV);
            this.Controls.Add(this.pictureBoxAvatar_LAV);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(771, 332);
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Информация";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAvatar_LAV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxAvatar_LAV;
        private System.Windows.Forms.Button buttonClose_LAV;
        private System.Windows.Forms.Label labelInfo_LAV;
    }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Text = "FormAbout";
        }

        #endregion
    }
}