namespace Pay_Increase
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
            this.initialCompensation = new System.Windows.Forms.Label();
            this.txt_input = new System.Windows.Forms.TextBox();
            this.list_TeacherPay = new System.Windows.Forms.ListBox();
            this.btn_ShowPay = new System.Windows.Forms.Button();
            this.btn_Exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // initialCompensation
            // 
            this.initialCompensation.AutoSize = true;
            this.initialCompensation.Location = new System.Drawing.Point(57, 22);
            this.initialCompensation.Name = "initialCompensation";
            this.initialCompensation.Size = new System.Drawing.Size(177, 13);
            this.initialCompensation.TabIndex = 0;
            this.initialCompensation.Text = "Enter teacher\'s intial compensation: ";
            // 
            // txt_input
            // 
            this.txt_input.Location = new System.Drawing.Point(355, 22);
            this.txt_input.Name = "txt_input";
            this.txt_input.Size = new System.Drawing.Size(100, 20);
            this.txt_input.TabIndex = 1;
            // 
            // list_TeacherPay
            // 
            this.list_TeacherPay.FormattingEnabled = true;
            this.list_TeacherPay.Items.AddRange(new object[] {
            ""});
            this.list_TeacherPay.Location = new System.Drawing.Point(60, 92);
            this.list_TeacherPay.Name = "list_TeacherPay";
            this.list_TeacherPay.Size = new System.Drawing.Size(205, 199);
            this.list_TeacherPay.TabIndex = 2;
            // 
            // btn_ShowPay
            // 
            this.btn_ShowPay.Location = new System.Drawing.Point(367, 71);
            this.btn_ShowPay.Name = "btn_ShowPay";
            this.btn_ShowPay.Size = new System.Drawing.Size(75, 23);
            this.btn_ShowPay.TabIndex = 3;
            this.btn_ShowPay.Text = "Show Pay";
            this.btn_ShowPay.UseVisualStyleBackColor = true;
            this.btn_ShowPay.Click += new System.EventHandler(this.btn_ShowPay_Click);
            // 
            // btn_Exit
            // 
            this.btn_Exit.Location = new System.Drawing.Point(367, 164);
            this.btn_Exit.Name = "btn_Exit";
            this.btn_Exit.Size = new System.Drawing.Size(75, 23);
            this.btn_Exit.TabIndex = 4;
            this.btn_Exit.Text = "Exit";
            this.btn_Exit.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 410);
            this.Controls.Add(this.btn_Exit);
            this.Controls.Add(this.btn_ShowPay);
            this.Controls.Add(this.list_TeacherPay);
            this.Controls.Add(this.txt_input);
            this.Controls.Add(this.initialCompensation);
            this.Name = "Form1";
            this.Text = "Teacher\'s Pay Increase";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label initialCompensation;
        private System.Windows.Forms.TextBox txt_input;
        private System.Windows.Forms.ListBox list_TeacherPay;
        private System.Windows.Forms.Button btn_ShowPay;
        private System.Windows.Forms.Button btn_Exit;
    }
}

