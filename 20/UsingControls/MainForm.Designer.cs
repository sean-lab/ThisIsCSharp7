namespace UsingControls
{
    partial class MainForm
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
            this.grpFont = new System.Windows.Forms.GroupBox();
            this.txtSampleText = new System.Windows.Forms.TextBox();
            this.lblFont = new System.Windows.Forms.Label();
            this.cboFont = new System.Windows.Forms.ComboBox();
            this.chkItalic = new System.Windows.Forms.CheckBox();
            this.chkBold = new System.Windows.Forms.CheckBox();
            this.pgDummy = new System.Windows.Forms.ProgressBar();
            this.tbDummy = new System.Windows.Forms.TrackBar();
            this.grpBar = new System.Windows.Forms.GroupBox();
            this.btnModal = new System.Windows.Forms.Button();
            this.btnModaless = new System.Windows.Forms.Button();
            this.btnMsgBox = new System.Windows.Forms.Button();
            this.grpForm = new System.Windows.Forms.GroupBox();
            this.btnAddRoot = new System.Windows.Forms.Button();
            this.btnAddChild = new System.Windows.Forms.Button();
            this.tvDummy = new System.Windows.Forms.TreeView();
            this.lvDummy = new System.Windows.Forms.ListView();
            this.grpTreeList = new System.Windows.Forms.GroupBox();
            this.grpFont.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).BeginInit();
            this.grpBar.SuspendLayout();
            this.grpForm.SuspendLayout();
            this.grpTreeList.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpFont
            // 
            this.grpFont.Controls.Add(this.txtSampleText);
            this.grpFont.Controls.Add(this.lblFont);
            this.grpFont.Controls.Add(this.cboFont);
            this.grpFont.Controls.Add(this.chkItalic);
            this.grpFont.Controls.Add(this.chkBold);
            this.grpFont.Location = new System.Drawing.Point(16, 14);
            this.grpFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFont.Name = "grpFont";
            this.grpFont.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpFont.Size = new System.Drawing.Size(379, 115);
            this.grpFont.TabIndex = 9;
            this.grpFont.TabStop = false;
            this.grpFont.Text = "ComboBox, CheckBox, TextBox";
            // 
            // txtSampleText
            // 
            this.txtSampleText.Location = new System.Drawing.Point(18, 65);
            this.txtSampleText.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtSampleText.Name = "txtSampleText";
            this.txtSampleText.Size = new System.Drawing.Size(323, 25);
            this.txtSampleText.TabIndex = 9;
            this.txtSampleText.Text = "Hello, C#";
            // 
            // lblFont
            // 
            this.lblFont.AutoSize = true;
            this.lblFont.Location = new System.Drawing.Point(16, 40);
            this.lblFont.Name = "lblFont";
            this.lblFont.Size = new System.Drawing.Size(46, 15);
            this.lblFont.TabIndex = 8;
            this.lblFont.Text = "Font :";
            // 
            // cboFont
            // 
            this.cboFont.FormattingEnabled = true;
            this.cboFont.Location = new System.Drawing.Point(66, 32);
            this.cboFont.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cboFont.Name = "cboFont";
            this.cboFont.Size = new System.Drawing.Size(138, 23);
            this.cboFont.TabIndex = 7;
            this.cboFont.SelectedIndexChanged += new System.EventHandler(this.cboFont_SelectedIndexChanged);
            // 
            // chkItalic
            // 
            this.chkItalic.AutoSize = true;
            this.chkItalic.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkItalic.Location = new System.Drawing.Point(273, 35);
            this.chkItalic.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkItalic.Name = "chkItalic";
            this.chkItalic.Size = new System.Drawing.Size(74, 19);
            this.chkItalic.TabIndex = 6;
            this.chkItalic.Text = "이탤릭";
            this.chkItalic.UseVisualStyleBackColor = true;
            this.chkItalic.CheckedChanged += new System.EventHandler(this.chkItalic_CheckedChanged);
            // 
            // chkBold
            // 
            this.chkBold.AutoSize = true;
            this.chkBold.Font = new System.Drawing.Font("굴림", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.chkBold.Location = new System.Drawing.Point(211, 35);
            this.chkBold.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chkBold.Name = "chkBold";
            this.chkBold.Size = new System.Drawing.Size(61, 19);
            this.chkBold.TabIndex = 5;
            this.chkBold.Text = "굵게";
            this.chkBold.UseVisualStyleBackColor = true;
            this.chkBold.CheckedChanged += new System.EventHandler(this.chkBold_CheckedChanged);
            // 
            // pgDummy
            // 
            this.pgDummy.Location = new System.Drawing.Point(18, 90);
            this.pgDummy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pgDummy.Maximum = 20;
            this.pgDummy.Name = "pgDummy";
            this.pgDummy.Size = new System.Drawing.Size(338, 24);
            this.pgDummy.TabIndex = 8;
            // 
            // tbDummy
            // 
            this.tbDummy.Location = new System.Drawing.Point(18, 26);
            this.tbDummy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbDummy.Maximum = 20;
            this.tbDummy.Name = "tbDummy";
            this.tbDummy.Size = new System.Drawing.Size(338, 56);
            this.tbDummy.TabIndex = 9;
            this.tbDummy.Scroll += new System.EventHandler(this.tbDummy_Scroll);
            // 
            // grpBar
            // 
            this.grpBar.Controls.Add(this.tbDummy);
            this.grpBar.Controls.Add(this.pgDummy);
            this.grpBar.Location = new System.Drawing.Point(18, 136);
            this.grpBar.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBar.Name = "grpBar";
            this.grpBar.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpBar.Size = new System.Drawing.Size(379, 139);
            this.grpBar.TabIndex = 10;
            this.grpBar.TabStop = false;
            this.grpBar.Text = "TrackBar && ProgressBar";
            // 
            // btnModal
            // 
            this.btnModal.Location = new System.Drawing.Point(18, 21);
            this.btnModal.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModal.Name = "btnModal";
            this.btnModal.Size = new System.Drawing.Size(86, 29);
            this.btnModal.TabIndex = 7;
            this.btnModal.Text = "Modal";
            this.btnModal.UseVisualStyleBackColor = true;
            this.btnModal.Click += new System.EventHandler(this.btnModal_Click);
            // 
            // btnModaless
            // 
            this.btnModaless.Location = new System.Drawing.Point(111, 21);
            this.btnModaless.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnModaless.Name = "btnModaless";
            this.btnModaless.Size = new System.Drawing.Size(86, 29);
            this.btnModaless.TabIndex = 8;
            this.btnModaless.Text = "Modaless";
            this.btnModaless.UseVisualStyleBackColor = true;
            this.btnModaless.Click += new System.EventHandler(this.btnModaless_Click);
            // 
            // btnMsgBox
            // 
            this.btnMsgBox.Location = new System.Drawing.Point(203, 21);
            this.btnMsgBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnMsgBox.Name = "btnMsgBox";
            this.btnMsgBox.Size = new System.Drawing.Size(153, 29);
            this.btnMsgBox.TabIndex = 9;
            this.btnMsgBox.Text = "MessageBox";
            this.btnMsgBox.UseVisualStyleBackColor = true;
            this.btnMsgBox.Click += new System.EventHandler(this.btnMsgBox_Click);
            // 
            // grpForm
            // 
            this.grpForm.Controls.Add(this.btnMsgBox);
            this.grpForm.Controls.Add(this.btnModaless);
            this.grpForm.Controls.Add(this.btnModal);
            this.grpForm.Location = new System.Drawing.Point(18, 282);
            this.grpForm.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpForm.Name = "grpForm";
            this.grpForm.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpForm.Size = new System.Drawing.Size(379, 66);
            this.grpForm.TabIndex = 11;
            this.grpForm.TabStop = false;
            this.grpForm.Text = "Modal && Modaless";
            // 
            // btnAddRoot
            // 
            this.btnAddRoot.Location = new System.Drawing.Point(8, 176);
            this.btnAddRoot.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddRoot.Name = "btnAddRoot";
            this.btnAddRoot.Size = new System.Drawing.Size(86, 29);
            this.btnAddRoot.TabIndex = 15;
            this.btnAddRoot.Text = "루트 추가";
            this.btnAddRoot.UseVisualStyleBackColor = true;
            this.btnAddRoot.Click += new System.EventHandler(this.btnAddRoot_Click);
            // 
            // btnAddChild
            // 
            this.btnAddChild.Location = new System.Drawing.Point(101, 176);
            this.btnAddChild.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAddChild.Name = "btnAddChild";
            this.btnAddChild.Size = new System.Drawing.Size(86, 29);
            this.btnAddChild.TabIndex = 16;
            this.btnAddChild.Text = "자식 추가";
            this.btnAddChild.UseVisualStyleBackColor = true;
            this.btnAddChild.Click += new System.EventHandler(this.btnAddChild_Click);
            // 
            // tvDummy
            // 
            this.tvDummy.Location = new System.Drawing.Point(8, 28);
            this.tvDummy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tvDummy.Name = "tvDummy";
            this.tvDummy.Size = new System.Drawing.Size(178, 135);
            this.tvDummy.TabIndex = 17;
            // 
            // lvDummy
            // 
            this.lvDummy.Location = new System.Drawing.Point(193, 28);
            this.lvDummy.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.lvDummy.Name = "lvDummy";
            this.lvDummy.Size = new System.Drawing.Size(169, 135);
            this.lvDummy.TabIndex = 18;
            this.lvDummy.UseCompatibleStateImageBehavior = false;
            this.lvDummy.View = System.Windows.Forms.View.Details;
            // 
            // grpTreeList
            // 
            this.grpTreeList.Controls.Add(this.lvDummy);
            this.grpTreeList.Controls.Add(this.tvDummy);
            this.grpTreeList.Controls.Add(this.btnAddChild);
            this.grpTreeList.Controls.Add(this.btnAddRoot);
            this.grpTreeList.Location = new System.Drawing.Point(18, 356);
            this.grpTreeList.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTreeList.Name = "grpTreeList";
            this.grpTreeList.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.grpTreeList.Size = new System.Drawing.Size(379, 212);
            this.grpTreeList.TabIndex = 12;
            this.grpTreeList.TabStop = false;
            this.grpTreeList.Text = "TreeView && ListView";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(411, 570);
            this.Controls.Add(this.grpTreeList);
            this.Controls.Add(this.grpForm);
            this.Controls.Add(this.grpBar);
            this.Controls.Add(this.grpFont);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "MainForm";
            this.Text = "Control Test";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.grpFont.ResumeLayout(false);
            this.grpFont.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbDummy)).EndInit();
            this.grpBar.ResumeLayout(false);
            this.grpBar.PerformLayout();
            this.grpForm.ResumeLayout(false);
            this.grpTreeList.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpFont;
        private System.Windows.Forms.TextBox txtSampleText;
        private System.Windows.Forms.Label lblFont;
        private System.Windows.Forms.ComboBox cboFont;
        private System.Windows.Forms.CheckBox chkItalic;
        private System.Windows.Forms.CheckBox chkBold;
        private System.Windows.Forms.ProgressBar pgDummy;
        private System.Windows.Forms.TrackBar tbDummy;
        private System.Windows.Forms.GroupBox grpBar;
        private System.Windows.Forms.Button btnModal;
        private System.Windows.Forms.Button btnModaless;
        private System.Windows.Forms.Button btnMsgBox;
        private System.Windows.Forms.GroupBox grpForm;
        private System.Windows.Forms.Button btnAddRoot;
        private System.Windows.Forms.Button btnAddChild;
        private System.Windows.Forms.TreeView tvDummy;
        private System.Windows.Forms.ListView lvDummy;
        private System.Windows.Forms.GroupBox grpTreeList;
    }
}

