namespace WindowsFormsDemo1
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
            this.txtRead = new System.Windows.Forms.Button();
            this.IniRead = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtRead
            // 
            this.txtRead.Location = new System.Drawing.Point(83, 43);
            this.txtRead.Name = "txtRead";
            this.txtRead.Size = new System.Drawing.Size(86, 31);
            this.txtRead.TabIndex = 0;
            this.txtRead.Text = "txt读取";
            this.txtRead.UseVisualStyleBackColor = true;
            this.txtRead.Click += new System.EventHandler(this.txtRead_Click);
            // 
            // IniRead
            // 
            this.IniRead.Location = new System.Drawing.Point(299, 36);
            this.IniRead.Name = "IniRead";
            this.IniRead.Size = new System.Drawing.Size(107, 45);
            this.IniRead.TabIndex = 1;
            this.IniRead.Text = "Ini读取";
            this.IniRead.UseVisualStyleBackColor = true;
            this.IniRead.Click += new System.EventHandler(this.IniRead_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.IniRead);
            this.Controls.Add(this.txtRead);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button txtRead;
        private System.Windows.Forms.Button IniRead;
    }
}

