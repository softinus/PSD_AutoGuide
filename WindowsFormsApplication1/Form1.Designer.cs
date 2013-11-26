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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.picLayerImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picLayerImage)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(379, 12);
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
            this.lstLayers.Location = new System.Drawing.Point(379, 47);
            this.lstLayers.Name = "lstLayers";
            this.lstLayers.Size = new System.Drawing.Size(94, 376);
            this.lstLayers.TabIndex = 1;
            this.lstLayers.SelectedIndexChanged += new System.EventHandler(this.lstLayers_SelectedIndexChanged);
            // 
            // txtLoadPath
            // 
            this.txtLoadPath.Location = new System.Drawing.Point(12, 13);
            this.txtLoadPath.MaxLength = 512;
            this.txtLoadPath.Name = "txtLoadPath";
            this.txtLoadPath.ReadOnly = true;
            this.txtLoadPath.Size = new System.Drawing.Size(361, 21);
            this.txtLoadPath.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(393, 426);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "Layer List";
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(12, 47);
            this.txtInfo.MaxLength = 128;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.ReadOnly = true;
            this.txtInfo.Size = new System.Drawing.Size(361, 21);
            this.txtInfo.TabIndex = 4;
            // 
            // picLayerImage
            // 
            this.picLayerImage.Location = new System.Drawing.Point(12, 74);
            this.picLayerImage.Name = "picLayerImage";
            this.picLayerImage.Size = new System.Drawing.Size(361, 349);
            this.picLayerImage.TabIndex = 5;
            this.picLayerImage.TabStop = false;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 459);
            this.Controls.Add(this.picLayerImage);
            this.Controls.Add(this.txtInfo);
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
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListBox lstLayers;
        private System.Windows.Forms.TextBox txtLoadPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.PictureBox picLayerImage;
    }
}

