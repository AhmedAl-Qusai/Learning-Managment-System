namespace UniTaskSystem.UI.Forms
{
    partial class GradeSubmissionForm
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
            this.lblStudent = new System.Windows.Forms.Label();
            this.lblSubmittedAt = new System.Windows.Forms.Label();
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.lstFiles = new System.Windows.Forms.ListBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.numScore = new System.Windows.Forms.NumericUpDown();
            this.rtbFeedback = new System.Windows.Forms.RichTextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).BeginInit();
            this.SuspendLayout();
            // 
            // lblStudent
            // 
            this.lblStudent.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblStudent.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblStudent.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStudent.ForeColor = System.Drawing.Color.Black;
            this.lblStudent.Location = new System.Drawing.Point(0, 0);
            this.lblStudent.Name = "lblStudent";
            this.lblStudent.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblStudent.Size = new System.Drawing.Size(777, 47);
            this.lblStudent.TabIndex = 0;
            // 
            // lblSubmittedAt
            // 
            this.lblSubmittedAt.BackColor = System.Drawing.SystemColors.Highlight;
            this.lblSubmittedAt.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblSubmittedAt.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittedAt.ForeColor = System.Drawing.Color.Black;
            this.lblSubmittedAt.Location = new System.Drawing.Point(0, 47);
            this.lblSubmittedAt.Name = "lblSubmittedAt";
            this.lblSubmittedAt.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.lblSubmittedAt.Size = new System.Drawing.Size(777, 53);
            this.lblSubmittedAt.TabIndex = 1;
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.rtbAnswer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnswer.ForeColor = System.Drawing.Color.White;
            this.rtbAnswer.Location = new System.Drawing.Point(299, 103);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbAnswer.Size = new System.Drawing.Size(452, 264);
            this.rtbAnswer.TabIndex = 2;
            this.rtbAnswer.Text = "";
            // 
            // lstFiles
            // 
            this.lstFiles.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstFiles.FormattingEnabled = true;
            this.lstFiles.ItemHeight = 24;
            this.lstFiles.Location = new System.Drawing.Point(299, 312);
            this.lstFiles.Name = "lstFiles";
            this.lstFiles.Size = new System.Drawing.Size(308, 52);
            this.lstFiles.TabIndex = 3;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnOpenFile.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenFile.ForeColor = System.Drawing.Color.White;
            this.btnOpenFile.Location = new System.Drawing.Point(601, 312);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(150, 52);
            this.btnOpenFile.TabIndex = 4;
            this.btnOpenFile.Text = "فتح المرفق";
            this.btnOpenFile.UseVisualStyleBackColor = false;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // numScore
            // 
            this.numScore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.numScore.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.numScore.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.numScore.Location = new System.Drawing.Point(299, 373);
            this.numScore.Name = "numScore";
            this.numScore.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.numScore.Size = new System.Drawing.Size(261, 38);
            this.numScore.TabIndex = 5;
            this.numScore.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // rtbFeedback
            // 
            this.rtbFeedback.BackColor = System.Drawing.Color.LightGray;
            this.rtbFeedback.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbFeedback.Location = new System.Drawing.Point(12, 182);
            this.rtbFeedback.Name = "rtbFeedback";
            this.rtbFeedback.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbFeedback.Size = new System.Drawing.Size(268, 229);
            this.rtbFeedback.TabIndex = 6;
            this.rtbFeedback.Text = "";
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.Color.Black;
            this.btnClose.Location = new System.Drawing.Point(12, 429);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(268, 50);
            this.btnClose.TabIndex = 7;
            this.btnClose.Text = "إغلاق";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.SystemColors.Info;
            this.btnSave.Location = new System.Drawing.Point(299, 414);
            this.btnSave.Name = "btnSave";
            this.btnSave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSave.Size = new System.Drawing.Size(452, 65);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "حفظ الدرجة  💾";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(566, 370);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(185, 41);
            this.label1.TabIndex = 9;
            this.label1.Text = "درجة التكليف :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(189, 155);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label2.Size = new System.Drawing.Size(95, 24);
            this.label2.TabIndex = 10;
            this.label2.Text = "ملاحظة :";
            // 
            // GradeSubmissionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(777, 491);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.rtbFeedback);
            this.Controls.Add(this.numScore);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lstFiles);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.lblSubmittedAt);
            this.Controls.Add(this.lblStudent);
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Name = "GradeSubmissionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "GradeSubmissionForm";
            this.Load += new System.EventHandler(this.GradeSubmissionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.numScore)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblStudent;
        private System.Windows.Forms.Label lblSubmittedAt;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.ListBox lstFiles;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.RichTextBox rtbFeedback;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.NumericUpDown numScore;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}