namespace TestWebAPIFromService
{
    partial class FrmMain
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
            this.txtInfo = new System.Windows.Forms.TextBox();
            this.btnCallAPI = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtInfo
            // 
            this.txtInfo.Location = new System.Drawing.Point(36, 40);
            this.txtInfo.Multiline = true;
            this.txtInfo.Name = "txtInfo";
            this.txtInfo.Size = new System.Drawing.Size(803, 240);
            this.txtInfo.TabIndex = 0;
            // 
            // btnCallAPI
            // 
            this.btnCallAPI.Location = new System.Drawing.Point(36, 286);
            this.btnCallAPI.Name = "btnCallAPI";
            this.btnCallAPI.Size = new System.Drawing.Size(803, 39);
            this.btnCallAPI.TabIndex = 1;
            this.btnCallAPI.Text = "调用WebAPI(基于JSON传递对象为参数，并返回数据)";
            this.btnCallAPI.UseVisualStyleBackColor = true;
            this.btnCallAPI.Click += new System.EventHandler(this.btnCallAPI_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 450);
            this.Controls.Add(this.btnCallAPI);
            this.Controls.Add(this.txtInfo);
            this.Name = "FrmMain";
            this.Text = "在服务器端(后台)调用WebAPI";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtInfo;
        private System.Windows.Forms.Button btnCallAPI;
    }
}

