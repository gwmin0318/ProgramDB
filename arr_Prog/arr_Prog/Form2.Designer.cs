namespace arr_Prog
{
    partial class Form2
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
            this.IDB_IMGUP = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.IDC_ADD_SEL = new System.Windows.Forms.ComboBox();
            this.IDC_ADD_NAME = new System.Windows.Forms.TextBox();
            this.IDB_DATAUP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.IDC_ADD_COMMENT = new System.Windows.Forms.TextBox();
            this.IDC_ADD_DATE = new System.Windows.Forms.DateTimePicker();
            this.IDB_CANCLE = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // IDB_IMGUP
            // 
            this.IDB_IMGUP.Location = new System.Drawing.Point(173, 192);
            this.IDB_IMGUP.Name = "IDB_IMGUP";
            this.IDB_IMGUP.Size = new System.Drawing.Size(99, 23);
            this.IDB_IMGUP.TabIndex = 0;
            this.IDB_IMGUP.Text = "이미지 업로드";
            this.IDB_IMGUP.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(12, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "이름";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "작성일";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 79);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 16);
            this.label3.TabIndex = 3;
            this.label3.Text = "사용 언어";
            // 
            // IDC_ADD_SEL
            // 
            this.IDC_ADD_SEL.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IDC_ADD_SEL.FormattingEnabled = true;
            this.IDC_ADD_SEL.Items.AddRange(new object[] {
            "C Language",
            "C++ / MFC",
            "C# Language",
            "JAVA / Android",
            "Object-C / iOS",
            "Web Language"});
            this.IDC_ADD_SEL.Location = new System.Drawing.Point(89, 77);
            this.IDC_ADD_SEL.Name = "IDC_ADD_SEL";
            this.IDC_ADD_SEL.Size = new System.Drawing.Size(183, 20);
            this.IDC_ADD_SEL.TabIndex = 4;
            // 
            // IDC_ADD_NAME
            // 
            this.IDC_ADD_NAME.Location = new System.Drawing.Point(89, 13);
            this.IDC_ADD_NAME.Name = "IDC_ADD_NAME";
            this.IDC_ADD_NAME.Size = new System.Drawing.Size(183, 21);
            this.IDC_ADD_NAME.TabIndex = 5;
            // 
            // IDB_DATAUP
            // 
            this.IDB_DATAUP.Location = new System.Drawing.Point(116, 227);
            this.IDB_DATAUP.Name = "IDB_DATAUP";
            this.IDB_DATAUP.Size = new System.Drawing.Size(75, 23);
            this.IDB_DATAUP.TabIndex = 7;
            this.IDB_DATAUP.Text = "업로드";
            this.IDB_DATAUP.UseVisualStyleBackColor = true;
            this.IDB_DATAUP.Click += new System.EventHandler(this.IDB_DATAUP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(12, 109);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "설명";
            // 
            // IDC_ADD_COMMENT
            // 
            this.IDC_ADD_COMMENT.Location = new System.Drawing.Point(89, 109);
            this.IDC_ADD_COMMENT.Multiline = true;
            this.IDC_ADD_COMMENT.Name = "IDC_ADD_COMMENT";
            this.IDC_ADD_COMMENT.Size = new System.Drawing.Size(183, 73);
            this.IDC_ADD_COMMENT.TabIndex = 9;
            // 
            // IDC_ADD_DATE
            // 
            this.IDC_ADD_DATE.Location = new System.Drawing.Point(89, 43);
            this.IDC_ADD_DATE.Name = "IDC_ADD_DATE";
            this.IDC_ADD_DATE.Size = new System.Drawing.Size(183, 21);
            this.IDC_ADD_DATE.TabIndex = 10;
            // 
            // IDB_CANCLE
            // 
            this.IDB_CANCLE.Location = new System.Drawing.Point(197, 227);
            this.IDB_CANCLE.Name = "IDB_CANCLE";
            this.IDB_CANCLE.Size = new System.Drawing.Size(75, 23);
            this.IDB_CANCLE.TabIndex = 11;
            this.IDB_CANCLE.Text = "취소";
            this.IDB_CANCLE.UseVisualStyleBackColor = true;
            this.IDB_CANCLE.Click += new System.EventHandler(this.IDB_CANCLE_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.IDB_CANCLE);
            this.Controls.Add(this.IDC_ADD_DATE);
            this.Controls.Add(this.IDC_ADD_COMMENT);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.IDB_DATAUP);
            this.Controls.Add(this.IDC_ADD_NAME);
            this.Controls.Add(this.IDC_ADD_SEL);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.IDB_IMGUP);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button IDB_IMGUP;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox IDC_ADD_SEL;
        private System.Windows.Forms.TextBox IDC_ADD_NAME;
        private System.Windows.Forms.Button IDB_DATAUP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox IDC_ADD_COMMENT;
        private System.Windows.Forms.DateTimePicker IDC_ADD_DATE;
        private System.Windows.Forms.Button IDB_CANCLE;
    }
}