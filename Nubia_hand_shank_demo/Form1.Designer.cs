namespace Nubia_hand_shank_demo
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.skinSplitContainer1 = new CCWin.SkinControl.SkinSplitContainer();
            this.skbtnStart = new CCWin.SkinControl.SkinButton();
            this.skinSplitContainer2 = new CCWin.SkinControl.SkinSplitContainer();
            this.skpbHandShank = new CCWin.SkinControl.SkinPictureBox();
            this.skrtbLog = new CCWin.SkinControl.SkinChatRichTextBox();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.sktbThd = new CCWin.SkinControl.SkinTextBox();
            this.skbtnSetThd = new CCWin.SkinControl.SkinButton();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).BeginInit();
            this.skinSplitContainer1.Panel1.SuspendLayout();
            this.skinSplitContainer1.Panel2.SuspendLayout();
            this.skinSplitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).BeginInit();
            this.skinSplitContainer2.Panel1.SuspendLayout();
            this.skinSplitContainer2.Panel2.SuspendLayout();
            this.skinSplitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.skpbHandShank)).BeginInit();
            this.SuspendLayout();
            // 
            // skinSplitContainer1
            // 
            this.skinSplitContainer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer1.Location = new System.Drawing.Point(4, 28);
            this.skinSplitContainer1.Name = "skinSplitContainer1";
            // 
            // skinSplitContainer1.Panel1
            // 
            this.skinSplitContainer1.Panel1.Controls.Add(this.skbtnSetThd);
            this.skinSplitContainer1.Panel1.Controls.Add(this.sktbThd);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skinLabel1);
            this.skinSplitContainer1.Panel1.Controls.Add(this.skbtnStart);
            // 
            // skinSplitContainer1.Panel2
            // 
            this.skinSplitContainer1.Panel2.Controls.Add(this.skinSplitContainer2);
            this.skinSplitContainer1.Size = new System.Drawing.Size(792, 568);
            this.skinSplitContainer1.SplitterDistance = 280;
            this.skinSplitContainer1.SplitterWidth = 10;
            this.skinSplitContainer1.TabIndex = 0;
            // 
            // skbtnStart
            // 
            this.skbtnStart.BackColor = System.Drawing.Color.Transparent;
            this.skbtnStart.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnStart.DownBack = null;
            this.skbtnStart.Location = new System.Drawing.Point(54, 31);
            this.skbtnStart.MouseBack = null;
            this.skbtnStart.Name = "skbtnStart";
            this.skbtnStart.NormlBack = null;
            this.skbtnStart.Size = new System.Drawing.Size(168, 73);
            this.skbtnStart.TabIndex = 0;
            this.skbtnStart.Text = "Activate";
            this.skbtnStart.UseVisualStyleBackColor = false;
            this.skbtnStart.Click += new System.EventHandler(this.skbtnStart_Click);
            // 
            // skinSplitContainer2
            // 
            this.skinSplitContainer2.Cursor = System.Windows.Forms.Cursors.Default;
            this.skinSplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinSplitContainer2.Location = new System.Drawing.Point(0, 0);
            this.skinSplitContainer2.Name = "skinSplitContainer2";
            this.skinSplitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // skinSplitContainer2.Panel1
            // 
            this.skinSplitContainer2.Panel1.Controls.Add(this.skpbHandShank);
            // 
            // skinSplitContainer2.Panel2
            // 
            this.skinSplitContainer2.Panel2.Controls.Add(this.skrtbLog);
            this.skinSplitContainer2.Size = new System.Drawing.Size(502, 568);
            this.skinSplitContainer2.SplitterDistance = 346;
            this.skinSplitContainer2.TabIndex = 0;
            // 
            // skpbHandShank
            // 
            this.skpbHandShank.BackColor = System.Drawing.Color.Transparent;
            this.skpbHandShank.BackgroundImage = global::Nubia_hand_shank_demo.Properties.Resources.HandShank;
            this.skpbHandShank.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.skpbHandShank.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skpbHandShank.Location = new System.Drawing.Point(0, 0);
            this.skpbHandShank.Name = "skpbHandShank";
            this.skpbHandShank.Size = new System.Drawing.Size(502, 346);
            this.skpbHandShank.TabIndex = 0;
            this.skpbHandShank.TabStop = false;
            // 
            // skrtbLog
            // 
            this.skrtbLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skrtbLog.Location = new System.Drawing.Point(0, 0);
            this.skrtbLog.Name = "skrtbLog";
            this.skrtbLog.ReadOnly = true;
            this.skrtbLog.SelectControl = null;
            this.skrtbLog.SelectControlIndex = 0;
            this.skrtbLog.SelectControlPoint = new System.Drawing.Point(0, 0);
            this.skrtbLog.Size = new System.Drawing.Size(502, 218);
            this.skrtbLog.TabIndex = 0;
            this.skrtbLog.Text = "";
            // 
            // skinLabel1
            // 
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.Location = new System.Drawing.Point(23, 275);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(229, 120);
            this.skinLabel1.TabIndex = 1;
            this.skinLabel1.Text = "Sensitivity Threshold\r\nA.S: 1-255\r\nR.S: 2-16 (recommended)\r\n\r\n\r\n";
            // 
            // sktbThd
            // 
            this.sktbThd.BackColor = System.Drawing.Color.Transparent;
            this.sktbThd.DownBack = null;
            this.sktbThd.Icon = null;
            this.sktbThd.IconIsButton = false;
            this.sktbThd.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.sktbThd.IsPasswordChat = '\0';
            this.sktbThd.IsSystemPasswordChar = false;
            this.sktbThd.Lines = new string[] {
        "0"};
            this.sktbThd.Location = new System.Drawing.Point(27, 367);
            this.sktbThd.Margin = new System.Windows.Forms.Padding(0);
            this.sktbThd.MaxLength = 32767;
            this.sktbThd.MinimumSize = new System.Drawing.Size(28, 28);
            this.sktbThd.MouseBack = null;
            this.sktbThd.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.sktbThd.Multiline = false;
            this.sktbThd.Name = "sktbThd";
            this.sktbThd.NormlBack = null;
            this.sktbThd.Padding = new System.Windows.Forms.Padding(5);
            this.sktbThd.ReadOnly = false;
            this.sktbThd.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.sktbThd.Size = new System.Drawing.Size(64, 28);
            // 
            // 
            // 
            this.sktbThd.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.sktbThd.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sktbThd.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.sktbThd.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.sktbThd.SkinTxt.Name = "BaseText";
            this.sktbThd.SkinTxt.Size = new System.Drawing.Size(54, 26);
            this.sktbThd.SkinTxt.TabIndex = 0;
            this.sktbThd.SkinTxt.Text = "0";
            this.sktbThd.SkinTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sktbThd.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sktbThd.SkinTxt.WaterText = "";
            this.sktbThd.TabIndex = 2;
            this.sktbThd.Text = "0";
            this.sktbThd.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.sktbThd.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.sktbThd.WaterText = "";
            this.sktbThd.WordWrap = true;
            // 
            // skbtnSetThd
            // 
            this.skbtnSetThd.BackColor = System.Drawing.Color.Transparent;
            this.skbtnSetThd.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skbtnSetThd.DownBack = null;
            this.skbtnSetThd.Location = new System.Drawing.Point(137, 367);
            this.skbtnSetThd.MouseBack = null;
            this.skbtnSetThd.Name = "skbtnSetThd";
            this.skbtnSetThd.NormlBack = null;
            this.skbtnSetThd.Size = new System.Drawing.Size(85, 28);
            this.skbtnSetThd.TabIndex = 3;
            this.skbtnSetThd.Text = "Set";
            this.skbtnSetThd.UseVisualStyleBackColor = false;
            this.skbtnSetThd.Click += new System.EventHandler(this.skbtnSetThd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.ClientSize = new System.Drawing.Size(800, 600);
            this.Controls.Add(this.skinSplitContainer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NDT Hand Shank Demo, y.wang@newdegreetech.com, v0.3";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.skinSplitContainer1.Panel1.ResumeLayout(false);
            this.skinSplitContainer1.Panel1.PerformLayout();
            this.skinSplitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer1)).EndInit();
            this.skinSplitContainer1.ResumeLayout(false);
            this.skinSplitContainer2.Panel1.ResumeLayout(false);
            this.skinSplitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skinSplitContainer2)).EndInit();
            this.skinSplitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.skpbHandShank)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer1;
        private CCWin.SkinControl.SkinSplitContainer skinSplitContainer2;
        private CCWin.SkinControl.SkinPictureBox skpbHandShank;
        private CCWin.SkinControl.SkinChatRichTextBox skrtbLog;
        private CCWin.SkinControl.SkinButton skbtnStart;
        private CCWin.SkinControl.SkinTextBox sktbThd;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinButton skbtnSetThd;
    }
}

