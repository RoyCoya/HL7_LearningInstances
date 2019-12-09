namespace RegexFunction
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
            this.Regex_RegexRule = new System.Windows.Forms.RichTextBox();
            this.Regex_OriginalText = new System.Windows.Forms.RichTextBox();
            this.Regex_Result = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Regex_Find = new System.Windows.Forms.Button();
            this.Regex_Replace = new System.Windows.Forms.Button();
            this.Regex_ClassName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Regex_AutoCodeResult = new System.Windows.Forms.RichTextBox();
            this.Regex_MakeCode = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Regex_RegexRule
            // 
            this.Regex_RegexRule.Location = new System.Drawing.Point(12, 22);
            this.Regex_RegexRule.Name = "Regex_RegexRule";
            this.Regex_RegexRule.Size = new System.Drawing.Size(750, 64);
            this.Regex_RegexRule.TabIndex = 0;
            this.Regex_RegexRule.Text = "";
            // 
            // Regex_OriginalText
            // 
            this.Regex_OriginalText.Location = new System.Drawing.Point(12, 116);
            this.Regex_OriginalText.Name = "Regex_OriginalText";
            this.Regex_OriginalText.Size = new System.Drawing.Size(414, 202);
            this.Regex_OriginalText.TabIndex = 1;
            this.Regex_OriginalText.Text = "";
            // 
            // Regex_Result
            // 
            this.Regex_Result.Location = new System.Drawing.Point(12, 349);
            this.Regex_Result.Name = "Regex_Result";
            this.Regex_Result.Size = new System.Drawing.Size(414, 223);
            this.Regex_Result.TabIndex = 2;
            this.Regex_Result.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "正则表达式";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "原文本";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 334);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "匹配结果";
            // 
            // Regex_Find
            // 
            this.Regex_Find.Location = new System.Drawing.Point(768, 20);
            this.Regex_Find.Name = "Regex_Find";
            this.Regex_Find.Size = new System.Drawing.Size(75, 23);
            this.Regex_Find.TabIndex = 6;
            this.Regex_Find.Text = "查找";
            this.Regex_Find.UseVisualStyleBackColor = true;
            this.Regex_Find.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Regex_Replace
            // 
            this.Regex_Replace.Location = new System.Drawing.Point(768, 63);
            this.Regex_Replace.Name = "Regex_Replace";
            this.Regex_Replace.Size = new System.Drawing.Size(75, 23);
            this.Regex_Replace.TabIndex = 7;
            this.Regex_Replace.Text = "替换";
            this.Regex_Replace.UseVisualStyleBackColor = true;
            this.Regex_Replace.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Regex_ClassName
            // 
            this.Regex_ClassName.Location = new System.Drawing.Point(444, 92);
            this.Regex_ClassName.Name = "Regex_ClassName";
            this.Regex_ClassName.Size = new System.Drawing.Size(111, 21);
            this.Regex_ClassName.TabIndex = 8;
            this.Regex_ClassName.Text = "输入类名";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(812, 101);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 12);
            this.label4.TabIndex = 9;
            this.label4.Text = "代码";
            // 
            // Regex_AutoCodeResult
            // 
            this.Regex_AutoCodeResult.Location = new System.Drawing.Point(444, 116);
            this.Regex_AutoCodeResult.Name = "Regex_AutoCodeResult";
            this.Regex_AutoCodeResult.Size = new System.Drawing.Size(399, 456);
            this.Regex_AutoCodeResult.TabIndex = 10;
            this.Regex_AutoCodeResult.Text = "";
            // 
            // Regex_MakeCode
            // 
            this.Regex_MakeCode.Location = new System.Drawing.Point(575, 90);
            this.Regex_MakeCode.Name = "Regex_MakeCode";
            this.Regex_MakeCode.Size = new System.Drawing.Size(75, 23);
            this.Regex_MakeCode.TabIndex = 11;
            this.Regex_MakeCode.Text = "生成代码";
            this.Regex_MakeCode.UseVisualStyleBackColor = true;
            this.Regex_MakeCode.Click += new System.EventHandler(this.Regex_MakeCode_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 584);
            this.Controls.Add(this.Regex_MakeCode);
            this.Controls.Add(this.Regex_AutoCodeResult);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.Regex_ClassName);
            this.Controls.Add(this.Regex_Replace);
            this.Controls.Add(this.Regex_Find);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Regex_Result);
            this.Controls.Add(this.Regex_OriginalText);
            this.Controls.Add(this.Regex_RegexRule);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox Regex_RegexRule;
        private System.Windows.Forms.RichTextBox Regex_OriginalText;
        private System.Windows.Forms.RichTextBox Regex_Result;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button Regex_Find;
        private System.Windows.Forms.Button Regex_Replace;
        private System.Windows.Forms.TextBox Regex_ClassName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox Regex_AutoCodeResult;
        private System.Windows.Forms.Button Regex_MakeCode;
    }
}

