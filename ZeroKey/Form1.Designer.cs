namespace ZeroKey
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCtrl1Stop = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.pnCtrl1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnLoad = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnSave);
            this.splitContainer1.Panel2.Controls.Add(this.btnLoad);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.btnClear);
            this.splitContainer1.Panel2.Controls.Add(this.btnRecord);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Padding = new System.Windows.Forms.Padding(0, 8, 4, 0);
            this.splitContainer1.Size = new System.Drawing.Size(1133, 615);
            this.splitContainer1.SplitterDistance = 872;
            this.splitContainer1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(872, 615);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCtrl1Stop);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.pnCtrl1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 320);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(253, 47);
            this.panel1.TabIndex = 7;
            // 
            // btnCtrl1Stop
            // 
            this.btnCtrl1Stop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btnCtrl1Stop.Enabled = false;
            this.btnCtrl1Stop.Location = new System.Drawing.Point(0, 23);
            this.btnCtrl1Stop.Name = "btnCtrl1Stop";
            this.btnCtrl1Stop.Size = new System.Drawing.Size(253, 24);
            this.btnCtrl1Stop.TabIndex = 2;
            this.btnCtrl1Stop.Text = "중지";
            this.btnCtrl1Stop.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(25, 4);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ctrl+1";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // pnCtrl1
            // 
            this.pnCtrl1.BackColor = System.Drawing.Color.DarkGray;
            this.pnCtrl1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnCtrl1.Location = new System.Drawing.Point(1, 3);
            this.pnCtrl1.Name = "pnCtrl1";
            this.pnCtrl1.Size = new System.Drawing.Size(18, 18);
            this.pnCtrl1.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.Dock = System.Windows.Forms.DockStyle.Top;
            this.label3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label3.Location = new System.Drawing.Point(0, 284);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label3.Size = new System.Drawing.Size(253, 36);
            this.label3.TabIndex = 6;
            this.label3.Text = "동작";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnSave
            // 
            this.btnSave.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSave.Location = new System.Drawing.Point(0, 229);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(253, 55);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnLoad
            // 
            this.btnLoad.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnLoad.Location = new System.Drawing.Point(0, 174);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(253, 55);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "불러오기";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);
            // 
            // label2
            // 
            this.label2.Dock = System.Windows.Forms.DockStyle.Top;
            this.label2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label2.Location = new System.Drawing.Point(0, 138);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.label2.Size = new System.Drawing.Size(253, 36);
            this.label2.TabIndex = 5;
            this.label2.Text = "통신";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            // 
            // btnClear
            // 
            this.btnClear.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnClear.Location = new System.Drawing.Point(0, 83);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(253, 55);
            this.btnClear.TabIndex = 2;
            this.btnClear.Text = "초기화";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // btnRecord
            // 
            this.btnRecord.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRecord.Location = new System.Drawing.Point(0, 28);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(253, 55);
            this.btnRecord.TabIndex = 1;
            this.btnRecord.Text = "녹화시작";
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(0, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "키 녹화";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1133, 615);
            this.Controls.Add(this.splitContainer1);
            this.Name = "Form1";
            this.Text = "ZeroKey";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnLoad;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnCtrl1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnCtrl1Stop;
    }
}

