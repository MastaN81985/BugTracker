namespace BugTracker
{
    partial class ReportFixForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.submitFixBtn = new System.Windows.Forms.Button();
            this.bugIDTb = new System.Windows.Forms.TextBox();
            this.progNameTB = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bug ID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 70);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(97, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Programmer Name:";
            // 
            // submitFixBtn
            // 
            this.submitFixBtn.Location = new System.Drawing.Point(173, 104);
            this.submitFixBtn.Name = "submitFixBtn";
            this.submitFixBtn.Size = new System.Drawing.Size(75, 23);
            this.submitFixBtn.TabIndex = 2;
            this.submitFixBtn.Text = "Submit";
            this.submitFixBtn.UseVisualStyleBackColor = true;
            // 
            // bugIDTb
            // 
            this.bugIDTb.Location = new System.Drawing.Point(133, 34);
            this.bugIDTb.Name = "bugIDTb";
            this.bugIDTb.Size = new System.Drawing.Size(274, 20);
            this.bugIDTb.TabIndex = 3;
            // 
            // progNameTB
            // 
            this.progNameTB.Location = new System.Drawing.Point(133, 70);
            this.progNameTB.Name = "progNameTB";
            this.progNameTB.Size = new System.Drawing.Size(274, 20);
            this.progNameTB.TabIndex = 4;
            // 
            // ReportFixForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 139);
            this.Controls.Add(this.progNameTB);
            this.Controls.Add(this.bugIDTb);
            this.Controls.Add(this.submitFixBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReportFixForm";
            this.Text = "Report A Fixed Bug";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button submitFixBtn;
        private System.Windows.Forms.TextBox bugIDTb;
        private System.Windows.Forms.TextBox progNameTB;
    }
}