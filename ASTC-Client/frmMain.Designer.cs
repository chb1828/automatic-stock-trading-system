﻿namespace ASTC_Client
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
			this.axKHOpenAPI = new AxKHOpenAPILib.AxKHOpenAPI();
			this.btnLoginTest = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).BeginInit();
			this.SuspendLayout();
			// 
			// axKHOpenAPI
			// 
			this.axKHOpenAPI.Enabled = true;
			this.axKHOpenAPI.Location = new System.Drawing.Point(92, 38);
			this.axKHOpenAPI.Name = "axKHOpenAPI";
			this.axKHOpenAPI.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axKHOpenAPI.OcxState")));
			this.axKHOpenAPI.Size = new System.Drawing.Size(100, 50);
			this.axKHOpenAPI.TabIndex = 0;
			// 
			// btnLoginTest
			// 
			this.btnLoginTest.Location = new System.Drawing.Point(92, 94);
			this.btnLoginTest.Name = "btnLoginTest";
			this.btnLoginTest.Size = new System.Drawing.Size(147, 47);
			this.btnLoginTest.TabIndex = 1;
			this.btnLoginTest.Text = "로그인 테스트";
			this.btnLoginTest.UseVisualStyleBackColor = true;
			this.btnLoginTest.Click += new System.EventHandler(this.BtnLoginTest_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnLoginTest);
			this.Controls.Add(this.axKHOpenAPI);
			this.Name = "Form1";
			this.Text = "ASTS-Client";
			((System.ComponentModel.ISupportInitialize)(this.axKHOpenAPI)).EndInit();
			this.ResumeLayout(false);

        }

		#endregion

		private AxKHOpenAPILib.AxKHOpenAPI axKHOpenAPI;
		private System.Windows.Forms.Button btnLoginTest;
	}
}

