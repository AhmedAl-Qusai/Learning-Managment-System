namespace UniTaskSystem.UI.Forms
{
    partial class StudentTaskDetailsForm
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDeadline = new System.Windows.Forms.Label();
            this.rtbBody = new System.Windows.Forms.RichTextBox();
            this.lstTaskAttachments = new System.Windows.Forms.ListBox();
            this.btnOpenTaskAttachment = new System.Windows.Forms.Button();
            this.rtbAnswer = new System.Windows.Forms.RichTextBox();
            this.lstAnswerAttachments = new System.Windows.Forms.ListBox();
            this.btnAddAttachment = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.ofd = new System.Windows.Forms.OpenFileDialog();
            this.btnOpenAnswerAttachment = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(0, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(914, 63);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDeadline
            // 
            this.lblDeadline.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblDeadline.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDeadline.Location = new System.Drawing.Point(0, 63);
            this.lblDeadline.Name = "lblDeadline";
            this.lblDeadline.Size = new System.Drawing.Size(914, 36);
            this.lblDeadline.TabIndex = 1;
            this.lblDeadline.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // rtbBody
            // 
            this.rtbBody.BackColor = System.Drawing.Color.OldLace;
            this.rtbBody.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbBody.Location = new System.Drawing.Point(476, 117);
            this.rtbBody.Name = "rtbBody";
            this.rtbBody.ReadOnly = true;
            this.rtbBody.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbBody.Size = new System.Drawing.Size(426, 222);
            this.rtbBody.TabIndex = 2;
            this.rtbBody.Text = "";
            // 
            // lstTaskAttachments
            // 
            this.lstTaskAttachments.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstTaskAttachments.FormattingEnabled = true;
            this.lstTaskAttachments.ItemHeight = 28;
            this.lstTaskAttachments.Location = new System.Drawing.Point(476, 322);
            this.lstTaskAttachments.Name = "lstTaskAttachments";
            this.lstTaskAttachments.Size = new System.Drawing.Size(322, 60);
            this.lstTaskAttachments.TabIndex = 3;
            // 
            // btnOpenTaskAttachment
            // 
            this.btnOpenTaskAttachment.BackColor = System.Drawing.Color.Blue;
            this.btnOpenTaskAttachment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenTaskAttachment.ForeColor = System.Drawing.Color.White;
            this.btnOpenTaskAttachment.Location = new System.Drawing.Point(797, 322);
            this.btnOpenTaskAttachment.Name = "btnOpenTaskAttachment";
            this.btnOpenTaskAttachment.Size = new System.Drawing.Size(105, 60);
            this.btnOpenTaskAttachment.TabIndex = 4;
            this.btnOpenTaskAttachment.Text = "فتح المرفق";
            this.btnOpenTaskAttachment.UseVisualStyleBackColor = false;
            this.btnOpenTaskAttachment.Click += new System.EventHandler(this.btnOpenTaskAttachment_Click);
            // 
            // rtbAnswer
            // 
            this.rtbAnswer.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.rtbAnswer.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtbAnswer.Location = new System.Drawing.Point(8, 153);
            this.rtbAnswer.Name = "rtbAnswer";
            this.rtbAnswer.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.rtbAnswer.Size = new System.Drawing.Size(427, 261);
            this.rtbAnswer.TabIndex = 5;
            this.rtbAnswer.Text = "";
            // 
            // lstAnswerAttachments
            // 
            this.lstAnswerAttachments.Font = new System.Drawing.Font("Segoe UI Historic", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstAnswerAttachments.FormattingEnabled = true;
            this.lstAnswerAttachments.ItemHeight = 25;
            this.lstAnswerAttachments.Location = new System.Drawing.Point(86, 380);
            this.lstAnswerAttachments.Name = "lstAnswerAttachments";
            this.lstAnswerAttachments.Size = new System.Drawing.Size(242, 54);
            this.lstAnswerAttachments.TabIndex = 6;
            // 
            // btnAddAttachment
            // 
            this.btnAddAttachment.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnAddAttachment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddAttachment.ForeColor = System.Drawing.Color.White;
            this.btnAddAttachment.Location = new System.Drawing.Point(316, 380);
            this.btnAddAttachment.Name = "btnAddAttachment";
            this.btnAddAttachment.Size = new System.Drawing.Size(119, 55);
            this.btnAddAttachment.TabIndex = 7;
            this.btnAddAttachment.Text = "إضافة ملف ";
            this.btnAddAttachment.UseVisualStyleBackColor = false;
            this.btnAddAttachment.Click += new System.EventHandler(this.btnAddAttachment_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.Navy;
            this.btnSubmit.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnSubmit.Location = new System.Drawing.Point(286, 440);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(149, 54);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "إرسال⇧الحل";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnBack.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBack.Location = new System.Drawing.Point(12, 451);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(101, 43);
            this.btnBack.TabIndex = 9;
            this.btnBack.Text = "↩ رجوع";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // ofd
            // 
            this.ofd.FileName = "openFileDialog1";
            // 
            // btnOpenAnswerAttachment
            // 
            this.btnOpenAnswerAttachment.BackColor = System.Drawing.Color.Blue;
            this.btnOpenAnswerAttachment.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOpenAnswerAttachment.ForeColor = System.Drawing.Color.White;
            this.btnOpenAnswerAttachment.Location = new System.Drawing.Point(12, 380);
            this.btnOpenAnswerAttachment.Name = "btnOpenAnswerAttachment";
            this.btnOpenAnswerAttachment.Size = new System.Drawing.Size(77, 55);
            this.btnOpenAnswerAttachment.TabIndex = 10;
            this.btnOpenAnswerAttachment.Text = "فتح ";
            this.btnOpenAnswerAttachment.UseVisualStyleBackColor = false;
            this.btnOpenAnswerAttachment.Click += new System.EventHandler(this.btnOpenAnswerAttachment_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.SteelBlue;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(286, 122);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(149, 28);
            this.label1.TabIndex = 11;
            this.label1.Text = "ادخل الحل هنا :";
            // 
            // StudentTaskDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(914, 506);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddAttachment);
            this.Controls.Add(this.lstAnswerAttachments);
            this.Controls.Add(this.btnOpenAnswerAttachment);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.rtbAnswer);
            this.Controls.Add(this.btnOpenTaskAttachment);
            this.Controls.Add(this.lstTaskAttachments);
            this.Controls.Add(this.rtbBody);
            this.Controls.Add(this.lblDeadline);
            this.Controls.Add(this.lblTitle);
            this.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "StudentTaskDetailsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "StudentTaskDetailsForm";
            this.Load += new System.EventHandler(this.StudentTaskDetailsForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblDeadline;
        private System.Windows.Forms.RichTextBox rtbBody;
        private System.Windows.Forms.ListBox lstTaskAttachments;
        private System.Windows.Forms.Button btnOpenTaskAttachment;
        private System.Windows.Forms.RichTextBox rtbAnswer;
        private System.Windows.Forms.ListBox lstAnswerAttachments;
        private System.Windows.Forms.Button btnAddAttachment;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.OpenFileDialog ofd;
        private System.Windows.Forms.Button btnOpenAnswerAttachment;
        private System.Windows.Forms.Label label1;
    }
}