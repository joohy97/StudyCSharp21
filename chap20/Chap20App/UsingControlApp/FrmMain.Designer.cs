
namespace UsingControlApp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ChkItalic = new System.Windows.Forms.CheckBox();
            this.TxtResult = new System.Windows.Forms.TextBox();
            this.ChkBold = new System.Windows.Forms.CheckBox();
            this.CboFont = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TrbHandle = new System.Windows.Forms.TrackBar();
            this.PrbDisplay = new System.Windows.Forms.ProgressBar();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ChkItalic);
            this.groupBox1.Controls.Add(this.TxtResult);
            this.groupBox1.Controls.Add(this.ChkBold);
            this.groupBox1.Controls.Add(this.CboFont);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(410, 100);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "ComboBox, CheckBox, TextBox";
            // 
            // ChkItalic
            // 
            this.ChkItalic.AutoSize = true;
            this.ChkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkItalic.Location = new System.Drawing.Point(343, 30);
            this.ChkItalic.Name = "ChkItalic";
            this.ChkItalic.Size = new System.Drawing.Size(60, 16);
            this.ChkItalic.TabIndex = 5;
            this.ChkItalic.Text = "이탤릭";
            this.ChkItalic.UseVisualStyleBackColor = true;
            this.ChkItalic.CheckedChanged += new System.EventHandler(this.ChkItalic_CheckedChanged);
            // 
            // TxtResult
            // 
            this.TxtResult.Location = new System.Drawing.Point(20, 63);
            this.TxtResult.Name = "TxtResult";
            this.TxtResult.Size = new System.Drawing.Size(373, 21);
            this.TxtResult.TabIndex = 4;
            // 
            // ChkBold
            // 
            this.ChkBold.AutoSize = true;
            this.ChkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.ChkBold.Location = new System.Drawing.Point(293, 30);
            this.ChkBold.Name = "ChkBold";
            this.ChkBold.Size = new System.Drawing.Size(50, 16);
            this.ChkBold.TabIndex = 3;
            this.ChkBold.Text = "굵게";
            this.ChkBold.UseVisualStyleBackColor = true;
            this.ChkBold.CheckedChanged += new System.EventHandler(this.ChkBold_CheckedChanged);
            // 
            // CboFont
            // 
            this.CboFont.FormattingEnabled = true;
            this.CboFont.Location = new System.Drawing.Point(60, 28);
            this.CboFont.Name = "CboFont";
            this.CboFont.Size = new System.Drawing.Size(222, 20);
            this.CboFont.TabIndex = 1;
            this.CboFont.SelectedIndexChanged += new System.EventHandler(this.CboFont_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Font : ";
            // 
            // TrbHandle
            // 
            this.TrbHandle.Location = new System.Drawing.Point(18, 20);
            this.TrbHandle.Maximum = 20;
            this.TrbHandle.Name = "TrbHandle";
            this.TrbHandle.Size = new System.Drawing.Size(373, 45);
            this.TrbHandle.TabIndex = 1;
            this.TrbHandle.Scroll += new System.EventHandler(this.TrbHandle_Scroll);
            // 
            // PrbDisplay
            // 
            this.PrbDisplay.Location = new System.Drawing.Point(18, 71);
            this.PrbDisplay.Maximum = 20;
            this.PrbDisplay.Name = "PrbDisplay";
            this.PrbDisplay.Size = new System.Drawing.Size(373, 23);
            this.PrbDisplay.TabIndex = 2;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.TrbHandle);
            this.groupBox2.Controls.Add(this.PrbDisplay);
            this.groupBox2.Location = new System.Drawing.Point(14, 123);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(410, 120);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "TrackBar, ProgressBar";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 385);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmMain";
            this.Text = "UsingControlApp";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TrbHandle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox TxtResult;
        private System.Windows.Forms.CheckBox ChkBold;
        private System.Windows.Forms.ComboBox CboFont;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox ChkItalic;
        private System.Windows.Forms.TrackBar TrbHandle;
        private System.Windows.Forms.ProgressBar PrbDisplay;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}

