
namespace FileCopyApp
{
    partial class FrmMain
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
            this.TxtSource = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtTarget = new System.Windows.Forms.TextBox();
            this.BtnSource = new System.Windows.Forms.Button();
            this.BtnTarget = new System.Windows.Forms.Button();
            this.BtnAsyncCopy = new System.Windows.Forms.Button();
            this.BtnSyncCopy = new System.Windows.Forms.Button();
            this.BtnCancel = new System.Windows.Forms.Button();
            this.PrbCopy = new System.Windows.Forms.ProgressBar();
            this.SuspendLayout();
            // 
            // TxtSource
            // 
            this.TxtSource.Location = new System.Drawing.Point(66, 6);
            this.TxtSource.Name = "TxtSource";
            this.TxtSource.Size = new System.Drawing.Size(244, 21);
            this.TxtSource.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "Source :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "Target :";
            // 
            // TxtTarget
            // 
            this.TxtTarget.Location = new System.Drawing.Point(66, 37);
            this.TxtTarget.Name = "TxtTarget";
            this.TxtTarget.Size = new System.Drawing.Size(244, 21);
            this.TxtTarget.TabIndex = 3;
            // 
            // BtnSource
            // 
            this.BtnSource.Location = new System.Drawing.Point(316, 6);
            this.BtnSource.Name = "BtnSource";
            this.BtnSource.Size = new System.Drawing.Size(30, 24);
            this.BtnSource.TabIndex = 4;
            this.BtnSource.Text = "...";
            this.BtnSource.UseVisualStyleBackColor = true;
            this.BtnSource.Click += new System.EventHandler(this.BtnSource_Click);
            // 
            // BtnTarget
            // 
            this.BtnTarget.Location = new System.Drawing.Point(316, 36);
            this.BtnTarget.Name = "BtnTarget";
            this.BtnTarget.Size = new System.Drawing.Size(30, 24);
            this.BtnTarget.TabIndex = 5;
            this.BtnTarget.Text = "...";
            this.BtnTarget.UseVisualStyleBackColor = true;
            this.BtnTarget.Click += new System.EventHandler(this.BtnTarget_Click);
            // 
            // BtnAsyncCopy
            // 
            this.BtnAsyncCopy.Location = new System.Drawing.Point(12, 78);
            this.BtnAsyncCopy.Name = "BtnAsyncCopy";
            this.BtnAsyncCopy.Size = new System.Drawing.Size(99, 25);
            this.BtnAsyncCopy.TabIndex = 6;
            this.BtnAsyncCopy.Text = "Async Copy";
            this.BtnAsyncCopy.UseVisualStyleBackColor = true;
            this.BtnAsyncCopy.Click += new System.EventHandler(this.BtnAsyncCopy_Click);
            // 
            // BtnSyncCopy
            // 
            this.BtnSyncCopy.Location = new System.Drawing.Point(129, 78);
            this.BtnSyncCopy.Name = "BtnSyncCopy";
            this.BtnSyncCopy.Size = new System.Drawing.Size(99, 25);
            this.BtnSyncCopy.TabIndex = 7;
            this.BtnSyncCopy.Text = "Sync Copy";
            this.BtnSyncCopy.UseVisualStyleBackColor = true;
            this.BtnSyncCopy.Click += new System.EventHandler(this.BtnSyncCopy_Click);
            // 
            // BtnCancel
            // 
            this.BtnCancel.Location = new System.Drawing.Point(246, 78);
            this.BtnCancel.Name = "BtnCancel";
            this.BtnCancel.Size = new System.Drawing.Size(99, 25);
            this.BtnCancel.TabIndex = 8;
            this.BtnCancel.Text = "Cancel";
            this.BtnCancel.UseVisualStyleBackColor = true;
            this.BtnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // PrbCopy
            // 
            this.PrbCopy.Location = new System.Drawing.Point(12, 119);
            this.PrbCopy.Name = "PrbCopy";
            this.PrbCopy.Size = new System.Drawing.Size(332, 23);
            this.PrbCopy.TabIndex = 9;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(357, 153);
            this.Controls.Add(this.PrbCopy);
            this.Controls.Add(this.BtnCancel);
            this.Controls.Add(this.BtnSyncCopy);
            this.Controls.Add(this.BtnAsyncCopy);
            this.Controls.Add(this.BtnTarget);
            this.Controls.Add(this.BtnSource);
            this.Controls.Add(this.TxtTarget);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TxtSource);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Async File Copy App";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtSource;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtTarget;
        private System.Windows.Forms.Button BtnSource;
        private System.Windows.Forms.Button BtnTarget;
        private System.Windows.Forms.Button BtnAsyncCopy;
        private System.Windows.Forms.Button BtnSyncCopy;
        private System.Windows.Forms.Button BtnCancel;
        private System.Windows.Forms.ProgressBar PrbCopy;
    }
}

