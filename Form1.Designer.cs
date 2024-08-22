namespace A2
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.BTNRunCode = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.TextBoxNumber1 = new System.Windows.Forms.TextBox();
            this.TextBoxNumber2 = new System.Windows.Forms.TextBox();
            this.ListBoxOutput = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // BTNRunCode
            // 
            this.BTNRunCode.Location = new System.Drawing.Point(223, 44);
            this.BTNRunCode.Name = "BTNRunCode";
            this.BTNRunCode.Size = new System.Drawing.Size(219, 66);
            this.BTNRunCode.TabIndex = 0;
            this.BTNRunCode.Text = "Run Code";
            this.BTNRunCode.UseVisualStyleBackColor = true;
            this.BTNRunCode.Click += new System.EventHandler(this.BTNRunCode_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(37, 147);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(50, 13);
            this.lbl1.TabIndex = 1;
            this.lbl1.Text = "Number1";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(35, 186);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(50, 13);
            this.lbl2.TabIndex = 2;
            this.lbl2.Text = "Number2";
            // 
            // TextBoxNumber1
            // 
            this.TextBoxNumber1.Location = new System.Drawing.Point(134, 150);
            this.TextBoxNumber1.Name = "TextBoxNumber1";
            this.TextBoxNumber1.Size = new System.Drawing.Size(241, 20);
            this.TextBoxNumber1.TabIndex = 3;
            // 
            // TextBoxNumber2
            // 
            this.TextBoxNumber2.Location = new System.Drawing.Point(133, 188);
            this.TextBoxNumber2.Name = "TextBoxNumber2";
            this.TextBoxNumber2.Size = new System.Drawing.Size(241, 20);
            this.TextBoxNumber2.TabIndex = 4;
            // 
            // ListBoxOutput
            // 
            this.ListBoxOutput.FormattingEnabled = true;
            this.ListBoxOutput.Location = new System.Drawing.Point(49, 243);
            this.ListBoxOutput.Name = "ListBoxOutput";
            this.ListBoxOutput.Size = new System.Drawing.Size(367, 134);
            this.ListBoxOutput.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ListBoxOutput);
            this.Controls.Add(this.TextBoxNumber2);
            this.Controls.Add(this.TextBoxNumber1);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.BTNRunCode);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BTNRunCode;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.TextBox TextBoxNumber1;
        private System.Windows.Forms.TextBox TextBoxNumber2;
        private System.Windows.Forms.ListBox ListBoxOutput;
    }
}

