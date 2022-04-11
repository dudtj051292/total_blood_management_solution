namespace total_blood_management_solution
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.text_Input_ID = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.text_input_PWD = new DevExpress.XtraEditors.TextEdit();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.chk_saveid = new System.Windows.Forms.CheckBox();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chk_savepwd = new System.Windows.Forms.CheckBox();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.chk_autoLogin = new System.Windows.Forms.CheckBox();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Input_ID.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_input_PWD.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.chk_autoLogin);
            this.layoutControl1.Controls.Add(this.chk_savepwd);
            this.layoutControl1.Controls.Add(this.chk_saveid);
            this.layoutControl1.Controls.Add(this.text_input_PWD);
            this.layoutControl1.Controls.Add(this.text_Input_ID);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(284, 361);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.emptySpaceItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(284, 361);
            this.Root.TextVisible = false;
            // 
            // text_Input_ID
            // 
            this.text_Input_ID.Location = new System.Drawing.Point(64, 130);
            this.text_Input_ID.Name = "text_Input_ID";
            this.text_Input_ID.Size = new System.Drawing.Size(208, 20);
            this.text_Input_ID.StyleController = this.layoutControl1;
            this.text_Input_ID.TabIndex = 4;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.text_Input_ID;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 118);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem1.Text = "ID";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(40, 14);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 214);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(264, 127);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // text_input_PWD
            // 
            this.text_input_PWD.Location = new System.Drawing.Point(64, 154);
            this.text_input_PWD.Name = "text_input_PWD";
            this.text_input_PWD.Size = new System.Drawing.Size(208, 20);
            this.text_input_PWD.StyleController = this.layoutControl1;
            this.text_input_PWD.TabIndex = 5;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.text_input_PWD;
            this.layoutControlItem2.Location = new System.Drawing.Point(0, 142);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem2.Text = "비밀번호";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(40, 14);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(264, 118);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // chk_saveid
            // 
            this.chk_saveid.Location = new System.Drawing.Point(12, 178);
            this.chk_saveid.Name = "chk_saveid";
            this.chk_saveid.Size = new System.Drawing.Size(128, 20);
            this.chk_saveid.TabIndex = 6;
            this.chk_saveid.Text = "아이디 저장";
            this.chk_saveid.UseVisualStyleBackColor = true;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.chk_saveid;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 166);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(132, 24);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // chk_savepwd
            // 
            this.chk_savepwd.Location = new System.Drawing.Point(144, 178);
            this.chk_savepwd.Name = "chk_savepwd";
            this.chk_savepwd.Size = new System.Drawing.Size(128, 20);
            this.chk_savepwd.TabIndex = 7;
            this.chk_savepwd.Text = "비밀번호 저장";
            this.chk_savepwd.UseVisualStyleBackColor = true;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.chk_savepwd;
            this.layoutControlItem4.Location = new System.Drawing.Point(132, 166);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(132, 24);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // chk_autoLogin
            // 
            this.chk_autoLogin.Location = new System.Drawing.Point(12, 202);
            this.chk_autoLogin.Name = "chk_autoLogin";
            this.chk_autoLogin.Size = new System.Drawing.Size(260, 20);
            this.chk_autoLogin.TabIndex = 8;
            this.chk_autoLogin.Text = "자동로그인";
            this.chk_autoLogin.UseVisualStyleBackColor = true;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.chk_autoLogin;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 190);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(264, 24);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 361);
            this.Controls.Add(this.layoutControl1);
            this.Name = "Form1";
            this.Text = "Login";
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_Input_ID.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.text_input_PWD.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private System.Windows.Forms.CheckBox chk_savepwd;
        private System.Windows.Forms.CheckBox chk_saveid;
        private DevExpress.XtraEditors.TextEdit text_input_PWD;
        private DevExpress.XtraEditors.TextEdit text_Input_ID;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private System.Windows.Forms.CheckBox chk_autoLogin;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
    }
}

