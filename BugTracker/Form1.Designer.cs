namespace BugTracker
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.bugLineTb = new System.Windows.Forms.TextBox();
            this.BugNameLbl = new System.Windows.Forms.Label();
            this.bugLineEndTB = new System.Windows.Forms.TextBox();
            this.bugDescTB = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.projNameTb = new System.Windows.Forms.TextBox();
            this.classTB = new System.Windows.Forms.TextBox();
            this.methodTB = new System.Windows.Forms.TextBox();
            this.bugDatabaseDataSet = new BugTracker.BugDatabaseDataSet();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugsTableAdapter = new BugTracker.BugDatabaseDataSetTableAdapters.BugsTableAdapter();
            this.tableAdapterManager = new BugTracker.BugDatabaseDataSetTableAdapters.TableAdapterManager();
            ((System.ComponentModel.ISupportInitialize)(this.bugDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(283, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bug Line End";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 181);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Bug Description";
            // 
            // bugLineTb
            // 
            this.bugLineTb.Location = new System.Drawing.Point(112, 55);
            this.bugLineTb.Name = "bugLineTb";
            this.bugLineTb.Size = new System.Drawing.Size(100, 20);
            this.bugLineTb.TabIndex = 0;
            // 
            // BugNameLbl
            // 
            this.BugNameLbl.AutoSize = true;
            this.BugNameLbl.Location = new System.Drawing.Point(9, 58);
            this.BugNameLbl.Name = "BugNameLbl";
            this.BugNameLbl.Size = new System.Drawing.Size(77, 13);
            this.BugNameLbl.TabIndex = 1;
            this.BugNameLbl.Text = "Bug Line Start:";
            // 
            // bugLineEndTB
            // 
            this.bugLineEndTB.Location = new System.Drawing.Point(373, 55);
            this.bugLineEndTB.Name = "bugLineEndTB";
            this.bugLineEndTB.Size = new System.Drawing.Size(66, 20);
            this.bugLineEndTB.TabIndex = 5;
            // 
            // bugDescTB
            // 
            this.bugDescTB.Location = new System.Drawing.Point(12, 197);
            this.bugDescTB.Multiline = true;
            this.bugDescTB.Name = "bugDescTB";
            this.bugDescTB.Size = new System.Drawing.Size(427, 123);
            this.bugDescTB.TabIndex = 6;
            // 
            // submitButton
            // 
            this.submitButton.Location = new System.Drawing.Point(183, 335);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(75, 23);
            this.submitButton.TabIndex = 7;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = true;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(97, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Programmer Name:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(112, 26);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(327, 20);
            this.nameTB.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 89);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Class";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 124);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Method";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Project:";
            // 
            // projNameTb
            // 
            this.projNameTb.Location = new System.Drawing.Point(112, 153);
            this.projNameTb.Name = "projNameTb";
            this.projNameTb.Size = new System.Drawing.Size(327, 20);
            this.projNameTb.TabIndex = 15;
            this.projNameTb.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // classTB
            // 
            this.classTB.Location = new System.Drawing.Point(112, 86);
            this.classTB.Name = "classTB";
            this.classTB.Size = new System.Drawing.Size(327, 20);
            this.classTB.TabIndex = 16;
            // 
            // methodTB
            // 
            this.methodTB.Location = new System.Drawing.Point(112, 117);
            this.methodTB.Name = "methodTB";
            this.methodTB.Size = new System.Drawing.Size(327, 20);
            this.methodTB.TabIndex = 17;
            // 
            // bugDatabaseDataSet
            // 
            this.bugDatabaseDataSet.DataSetName = "BugDatabaseDataSet";
            this.bugDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // bugsBindingSource
            // 
            this.bugsBindingSource.DataMember = "Bugs";
            this.bugsBindingSource.DataSource = this.bugDatabaseDataSet;
            // 
            // bugsTableAdapter
            // 
            this.bugsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.BugsTableAdapter = this.bugsTableAdapter;
            this.tableAdapterManager.UpdateOrder = BugTracker.BugDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 365);
            this.Controls.Add(this.methodTB);
            this.Controls.Add(this.classTB);
            this.Controls.Add(this.projNameTb);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.submitButton);
            this.Controls.Add(this.bugDescTB);
            this.Controls.Add(this.bugLineEndTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BugNameLbl);
            this.Controls.Add(this.bugLineTb);
            this.Name = "Form1";
            this.Text = "Report A Bug";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bugDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox bugLineTb;
        private System.Windows.Forms.Label BugNameLbl;
        private System.Windows.Forms.TextBox bugLineEndTB;
        private System.Windows.Forms.TextBox bugDescTB;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox projNameTb;
        private System.Windows.Forms.TextBox classTB;
        private System.Windows.Forms.TextBox methodTB;
        private BugDatabaseDataSet bugDatabaseDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private BugDatabaseDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private BugDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
    }
}

