namespace lulu
{
    partial class mainForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(mainForm));
            this.inpUrl = new System.Windows.Forms.TextBox();
            this.btnAnalysis = new System.Windows.Forms.Button();
            this.inpShow = new System.Windows.Forms.TextBox();
            this.btnCopy = new System.Windows.Forms.Button();
            this.labelPs = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // inpUrl
            // 
            this.inpUrl.Location = new System.Drawing.Point(12, 42);
            this.inpUrl.Name = "inpUrl";
            this.inpUrl.Size = new System.Drawing.Size(355, 21);
            this.inpUrl.TabIndex = 0;
            // 
            // btnAnalysis
            // 
            this.btnAnalysis.Location = new System.Drawing.Point(385, 41);
            this.btnAnalysis.Name = "btnAnalysis";
            this.btnAnalysis.Size = new System.Drawing.Size(75, 23);
            this.btnAnalysis.TabIndex = 1;
            this.btnAnalysis.Text = "解析";
            this.btnAnalysis.UseVisualStyleBackColor = true;
            this.btnAnalysis.Click += new System.EventHandler(this.btnAnalysis_Click);
            // 
            // inpShow
            // 
            this.inpShow.Enabled = false;
            this.inpShow.Location = new System.Drawing.Point(12, 79);
            this.inpShow.Name = "inpShow";
            this.inpShow.Size = new System.Drawing.Size(355, 21);
            this.inpShow.TabIndex = 2;
            // 
            // btnCopy
            // 
            this.btnCopy.Enabled = false;
            this.btnCopy.Location = new System.Drawing.Point(385, 78);
            this.btnCopy.Name = "btnCopy";
            this.btnCopy.Size = new System.Drawing.Size(75, 23);
            this.btnCopy.TabIndex = 3;
            this.btnCopy.Text = "复制";
            this.btnCopy.UseVisualStyleBackColor = true;
            this.btnCopy.Click += new System.EventHandler(this.btnCopy_Click);
            // 
            // labelPs
            // 
            this.labelPs.AutoSize = true;
            this.labelPs.Location = new System.Drawing.Point(16, 17);
            this.labelPs.Name = "labelPs";
            this.labelPs.Size = new System.Drawing.Size(113, 12);
            this.labelPs.TabIndex = 4;
            this.labelPs.Text = "支持优酷、腾讯视频";
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(473, 122);
            this.Controls.Add(this.labelPs);
            this.Controls.Add(this.btnCopy);
            this.Controls.Add(this.inpShow);
            this.Controls.Add(this.btnAnalysis);
            this.Controls.Add(this.inpUrl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "mainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "视频提取工具箱";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inpUrl;
        private System.Windows.Forms.Button btnAnalysis;
        private System.Windows.Forms.TextBox inpShow;
        private System.Windows.Forms.Button btnCopy;
        private System.Windows.Forms.Label labelPs;
    }
}

