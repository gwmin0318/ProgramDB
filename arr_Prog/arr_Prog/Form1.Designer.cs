﻿namespace arr_Prog
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.IDB_EXIT = new System.Windows.Forms.Button();
            this.ID_REFRESH = new System.Windows.Forms.Button();
            this.IDB_ADD = new System.Windows.Forms.Button();
            this.IDB_DELETE = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // IDB_EXIT
            // 
            this.IDB_EXIT.Location = new System.Drawing.Point(145, 443);
            this.IDB_EXIT.Name = "IDB_EXIT";
            this.IDB_EXIT.Size = new System.Drawing.Size(75, 23);
            this.IDB_EXIT.TabIndex = 0;
            this.IDB_EXIT.Text = "종료";
            this.IDB_EXIT.UseVisualStyleBackColor = true;
            // 
            // ID_REFRESH
            // 
            this.ID_REFRESH.Location = new System.Drawing.Point(145, 414);
            this.ID_REFRESH.Name = "ID_REFRESH";
            this.ID_REFRESH.Size = new System.Drawing.Size(75, 23);
            this.ID_REFRESH.TabIndex = 1;
            this.ID_REFRESH.Text = "갱신";
            this.ID_REFRESH.UseVisualStyleBackColor = true;
            // 
            // IDB_ADD
            // 
            this.IDB_ADD.Location = new System.Drawing.Point(64, 414);
            this.IDB_ADD.Name = "IDB_ADD";
            this.IDB_ADD.Size = new System.Drawing.Size(75, 23);
            this.IDB_ADD.TabIndex = 2;
            this.IDB_ADD.Text = "추가";
            this.IDB_ADD.UseVisualStyleBackColor = true;
            // 
            // IDB_DELETE
            // 
            this.IDB_DELETE.Location = new System.Drawing.Point(64, 443);
            this.IDB_DELETE.Name = "IDB_DELETE";
            this.IDB_DELETE.Size = new System.Drawing.Size(75, 23);
            this.IDB_DELETE.TabIndex = 3;
            this.IDB_DELETE.Text = "삭제";
            this.IDB_DELETE.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 12;
            this.listBox1.Location = new System.Drawing.Point(6, 20);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(271, 364);
            this.listBox1.TabIndex = 4;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Controls.Add(this.IDB_DELETE);
            this.groupBox1.Controls.Add(this.IDB_EXIT);
            this.groupBox1.Controls.Add(this.IDB_ADD);
            this.groupBox1.Controls.Add(this.ID_REFRESH);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(286, 472);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(304, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(577, 472);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(6, 356);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(565, 110);
            this.dataGridView1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(7, 20);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(564, 330);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 497);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button IDB_EXIT;
        private System.Windows.Forms.Button ID_REFRESH;
        private System.Windows.Forms.Button IDB_ADD;
        private System.Windows.Forms.Button IDB_DELETE;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

