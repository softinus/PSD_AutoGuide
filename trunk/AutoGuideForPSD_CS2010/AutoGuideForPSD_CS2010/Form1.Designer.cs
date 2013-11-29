namespace WindowsFormsApplication1
{
    partial class frmMain
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
            this.button1 = new System.Windows.Forms.Button();
            this.lstLayers = new System.Windows.Forms.ListBox();
            this.txtLoadPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.picLayerImage = new System.Windows.Forms.PictureBox();
            this.group1 = new System.Windows.Forms.GroupBox();
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLayerCount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRescount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDataCount = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtRows = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDepth = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picLayerImage)).BeginInit();
            this.group1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(533, 11);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Load PSD";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // lstLayers
            // 
            this.lstLayers.FormattingEnabled = true;
            this.lstLayers.ItemHeight = 12;
            this.lstLayers.Location = new System.Drawing.Point(533, 66);
            this.lstLayers.Name = "lstLayers";
            this.lstLayers.Size = new System.Drawing.Size(94, 352);
            this.lstLayers.TabIndex = 1;
            this.lstLayers.SelectedIndexChanged += new System.EventHandler(this.lstLayers_SelectedIndexChanged);
            // 
            // txtLoadPath
            // 
            this.txtLoadPath.Location = new System.Drawing.Point(66, 13);
            this.txtLoadPath.MaxLength = 512;
            this.txtLoadPath.Name = "txtLoadPath";
            this.txtLoadPath.ReadOnly = true;
            this.txtLoadPath.Size = new System.Drawing.Size(461, 21);
            this.txtLoadPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(546, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Layer List";
            // 
            // picLayerImage
            // 
            this.picLayerImage.Location = new System.Drawing.Point(149, 46);
            this.picLayerImage.Name = "picLayerImage";
            this.picLayerImage.Size = new System.Drawing.Size(378, 345);
            this.picLayerImage.TabIndex = 5;
            this.picLayerImage.TabStop = false;
            // 
            // group1
            // 
            this.group1.Controls.Add(this.txtDepth);
            this.group1.Controls.Add(this.label6);
            this.group1.Controls.Add(this.txtRows);
            this.group1.Controls.Add(this.label5);
            this.group1.Controls.Add(this.txtDataCount);
            this.group1.Controls.Add(this.label4);
            this.group1.Controls.Add(this.txtRescount);
            this.group1.Controls.Add(this.label3);
            this.group1.Controls.Add(this.txtLayerCount);
            this.group1.Controls.Add(this.label2);
            this.group1.Location = new System.Drawing.Point(12, 46);
            this.group1.Name = "group1";
            this.group1.Size = new System.Drawing.Size(131, 376);
            this.group1.TabIndex = 6;
            this.group1.TabStop = false;
            this.group1.Text = "Property";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(149, 397);
            this.txtInfo.MaxLength = 128;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(378, 21);
            this.txtInfo.TabIndex = 7;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Layer Count : ";
            // 
            // txtLayerCount
            // 
            this.txtLayerCount.Location = new System.Drawing.Point(90, 28);
            this.txtLayerCount.Name = "txtLayerCount";
            this.txtLayerCount.Size = new System.Drawing.Size(35, 21);
            this.txtLayerCount.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 12);
            this.label3.TabIndex = 0;
            this.label3.Text = "Res Count : ";
            // 
            // txtRescount
            // 
            this.txtRescount.Location = new System.Drawing.Point(90, 55);
            this.txtRescount.Name = "txtRescount";
            this.txtRescount.Size = new System.Drawing.Size(35, 21);
            this.txtRescount.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "Data Count : ";
            // 
            // txtDataCount
            // 
            this.txtDataCount.Location = new System.Drawing.Point(90, 82);
            this.txtDataCount.Name = "txtDataCount";
            this.txtDataCount.Size = new System.Drawing.Size(35, 21);
            this.txtDataCount.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 112);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 12);
            this.label5.TabIndex = 0;
            this.label5.Text = "Rows : ";
            // 
            // txtRows
            // 
            this.txtRows.Location = new System.Drawing.Point(90, 109);
            this.txtRows.Name = "txtRows";
            this.txtRows.Size = new System.Drawing.Size(35, 21);
            this.txtRows.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 139);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 12);
            this.label6.TabIndex = 0;
            this.label6.Text = "Depth : ";
            // 
            // txtDepth
            // 
            this.txtDepth.Location = new System.Drawing.Point(90, 136);
            this.txtDepth.Name = "txtDepth";
            this.txtDepth.Size = new System.Drawing.Size(35, 21);
            this.txtDepth.TabIndex = 1;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 12);
            this.label7.TabIndex = 2;
            this.label7.Text = "Path : ";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 427);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtInfo);
            this.Controls.Add(this.group1);
            this.Controls.Add(this.picLayerImage);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLoadPath);
            this.Controls.Add(this.lstLayers);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "frmMain";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Auto Guide";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.picLayerImage)).EndInit();
            this.group1.ResumeLayout(false);
            this.group1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstLayers;
        private System.Windows.Forms.TextBox txtLoadPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picLayerImage;
        private System.Windows.Forms.GroupBox group1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.TextBox txtLayerCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDepth;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRows;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDataCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtRescount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
    }
}

