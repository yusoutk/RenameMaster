
namespace RenameMaster
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.execute_button = new System.Windows.Forms.Button();
            this.excelPath_textBox = new System.Windows.Forms.TextBox();
            this.overwrite_check = new System.Windows.Forms.CheckBox();
            this.LogTextBox = new System.Windows.Forms.TextBox();
            this.openExcel_button = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // execute_button
            // 
            this.execute_button.Location = new System.Drawing.Point(163, 39);
            this.execute_button.Name = "execute_button";
            this.execute_button.Size = new System.Drawing.Size(75, 23);
            this.execute_button.TabIndex = 0;
            this.execute_button.Text = "実行";
            this.execute_button.UseVisualStyleBackColor = true;
            this.execute_button.Click += new System.EventHandler(this.execute_button_Click);
            // 
            // excelPath_textBox
            // 
            this.excelPath_textBox.Location = new System.Drawing.Point(12, 12);
            this.excelPath_textBox.Name = "excelPath_textBox";
            this.excelPath_textBox.Size = new System.Drawing.Size(186, 19);
            this.excelPath_textBox.TabIndex = 1;
            // 
            // overwrite_check
            // 
            this.overwrite_check.AutoSize = true;
            this.overwrite_check.Location = new System.Drawing.Point(81, 43);
            this.overwrite_check.Name = "overwrite_check";
            this.overwrite_check.Size = new System.Drawing.Size(76, 16);
            this.overwrite_check.TabIndex = 2;
            this.overwrite_check.Text = "上書きする";
            this.overwrite_check.UseVisualStyleBackColor = true;
            // 
            // LogTextBox
            // 
            this.LogTextBox.AcceptsReturn = true;
            this.LogTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LogTextBox.Location = new System.Drawing.Point(12, 77);
            this.LogTextBox.Multiline = true;
            this.LogTextBox.Name = "LogTextBox";
            this.LogTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.LogTextBox.Size = new System.Drawing.Size(236, 90);
            this.LogTextBox.TabIndex = 3;
            // 
            // openExcel_button
            // 
            this.openExcel_button.Location = new System.Drawing.Point(204, 10);
            this.openExcel_button.Name = "openExcel_button";
            this.openExcel_button.Size = new System.Drawing.Size(47, 23);
            this.openExcel_button.TabIndex = 4;
            this.openExcel_button.Text = "参照";
            this.openExcel_button.UseVisualStyleBackColor = true;
            this.openExcel_button.Click += new System.EventHandler(this.openExcel_button_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(264, 194);
            this.Controls.Add(this.openExcel_button);
            this.Controls.Add(this.LogTextBox);
            this.Controls.Add(this.overwrite_check);
            this.Controls.Add(this.excelPath_textBox);
            this.Controls.Add(this.execute_button);
            this.Name = "Form1";
            this.Text = "命名名人";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button execute_button;
        private System.Windows.Forms.TextBox excelPath_textBox;
        private System.Windows.Forms.CheckBox overwrite_check;
        private System.Windows.Forms.TextBox LogTextBox;
        private System.Windows.Forms.Button openExcel_button;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}

