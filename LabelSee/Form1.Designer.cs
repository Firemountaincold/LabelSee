
namespace LabelSee
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
            this.buttoncxml = new System.Windows.Forms.Button();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.buttonlast = new System.Windows.Forms.Button();
            this.buttonstart = new System.Windows.Forms.Button();
            this.buttonnext = new System.Windows.Forms.Button();
            this.textBoxinfo = new System.Windows.Forms.TextBox();
            this.buttonexit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // buttoncxml
            // 
            this.buttoncxml.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.buttoncxml.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttoncxml.Location = new System.Drawing.Point(12, 13);
            this.buttoncxml.Name = "buttoncxml";
            this.buttoncxml.Size = new System.Drawing.Size(136, 68);
            this.buttoncxml.TabIndex = 0;
            this.buttoncxml.Text = "选择xml文件";
            this.buttoncxml.UseVisualStyleBackColor = false;
            this.buttoncxml.Click += new System.EventHandler(this.buttoncxml_Click);
            // 
            // pictureBox
            // 
            this.pictureBox.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pictureBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox.Location = new System.Drawing.Point(154, 13);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(1024, 576);
            this.pictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox.TabIndex = 1;
            this.pictureBox.TabStop = false;
            // 
            // buttonlast
            // 
            this.buttonlast.BackColor = System.Drawing.Color.Linen;
            this.buttonlast.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonlast.Location = new System.Drawing.Point(12, 216);
            this.buttonlast.Name = "buttonlast";
            this.buttonlast.Size = new System.Drawing.Size(136, 31);
            this.buttonlast.TabIndex = 0;
            this.buttonlast.Text = "上一张";
            this.buttonlast.UseVisualStyleBackColor = false;
            this.buttonlast.Click += new System.EventHandler(this.buttonlast_Click);
            // 
            // buttonstart
            // 
            this.buttonstart.BackColor = System.Drawing.Color.Linen;
            this.buttonstart.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonstart.Location = new System.Drawing.Point(12, 253);
            this.buttonstart.Name = "buttonstart";
            this.buttonstart.Size = new System.Drawing.Size(136, 31);
            this.buttonstart.TabIndex = 0;
            this.buttonstart.Text = "开始观看";
            this.buttonstart.UseVisualStyleBackColor = false;
            this.buttonstart.Click += new System.EventHandler(this.buttonstart_Click);
            // 
            // buttonnext
            // 
            this.buttonnext.BackColor = System.Drawing.Color.Linen;
            this.buttonnext.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonnext.Location = new System.Drawing.Point(12, 290);
            this.buttonnext.Name = "buttonnext";
            this.buttonnext.Size = new System.Drawing.Size(136, 31);
            this.buttonnext.TabIndex = 0;
            this.buttonnext.Text = "下一张";
            this.buttonnext.UseVisualStyleBackColor = false;
            this.buttonnext.Click += new System.EventHandler(this.buttonnext_Click);
            // 
            // textBoxinfo
            // 
            this.textBoxinfo.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.textBoxinfo.Location = new System.Drawing.Point(12, 327);
            this.textBoxinfo.Multiline = true;
            this.textBoxinfo.Name = "textBoxinfo";
            this.textBoxinfo.ReadOnly = true;
            this.textBoxinfo.Size = new System.Drawing.Size(136, 225);
            this.textBoxinfo.TabIndex = 2;
            // 
            // buttonexit
            // 
            this.buttonexit.BackColor = System.Drawing.Color.LavenderBlush;
            this.buttonexit.CausesValidation = false;
            this.buttonexit.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.buttonexit.Location = new System.Drawing.Point(12, 558);
            this.buttonexit.Name = "buttonexit";
            this.buttonexit.Size = new System.Drawing.Size(136, 31);
            this.buttonexit.TabIndex = 3;
            this.buttonexit.Text = "退出软件";
            this.buttonexit.UseVisualStyleBackColor = false;
            this.buttonexit.Click += new System.EventHandler(this.buttonexit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(1188, 597);
            this.Controls.Add(this.buttonexit);
            this.Controls.Add(this.textBoxinfo);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.buttonnext);
            this.Controls.Add(this.buttonstart);
            this.Controls.Add(this.buttonlast);
            this.Controls.Add(this.buttoncxml);
            this.Name = "Form1";
            this.Text = "LabelSee";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttoncxml;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.Button buttonlast;
        private System.Windows.Forms.Button buttonstart;
        private System.Windows.Forms.Button buttonnext;
        private System.Windows.Forms.TextBox textBoxinfo;
        private System.Windows.Forms.Button buttonexit;
    }
}

