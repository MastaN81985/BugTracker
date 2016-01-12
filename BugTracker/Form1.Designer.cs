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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.bugsLB = new System.Windows.Forms.ListBox();
            this.bugDatabaseDataSet = new BugTracker.BugDatabaseDataSet();
            this.bugsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bugsTableAdapter = new BugTracker.BugDatabaseDataSetTableAdapters.BugsTableAdapter();
            this.tableAdapterManager = new BugTracker.BugDatabaseDataSetTableAdapters.TableAdapterManager();
            this.bugsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bugsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.bugDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingNavigator)).BeginInit();
            this.bugsBindingNavigator.SuspendLayout();
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
            // bugsLB
            // 
            this.bugsLB.FormattingEnabled = true;
            this.bugsLB.Location = new System.Drawing.Point(468, 29);
            this.bugsLB.Name = "bugsLB";
            this.bugsLB.Size = new System.Drawing.Size(368, 290);
            this.bugsLB.TabIndex = 18;
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
            // bugsBindingNavigator
            // 
            this.bugsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.bugsBindingNavigator.BindingSource = this.bugsBindingSource;
            this.bugsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.bugsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.bugsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.bugsBindingNavigatorSaveItem});
            this.bugsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bugsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.bugsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.bugsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.bugsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.bugsBindingNavigator.Name = "bugsBindingNavigator";
            this.bugsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.bugsBindingNavigator.Size = new System.Drawing.Size(865, 25);
            this.bugsBindingNavigator.TabIndex = 19;
            this.bugsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Move first";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Move previous";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Position";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Current position";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(35, 15);
            this.bindingNavigatorCountItem.Text = "of {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Total number of items";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveNextItem.Text = "Move next";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorMoveLastItem.Text = "Move last";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 6);
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Add new";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 20);
            this.bindingNavigatorDeleteItem.Text = "Delete";
            // 
            // bugsBindingNavigatorSaveItem
            // 
            this.bugsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bugsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("bugsBindingNavigatorSaveItem.Image")));
            this.bugsBindingNavigatorSaveItem.Name = "bugsBindingNavigatorSaveItem";
            this.bugsBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 23);
            this.bugsBindingNavigatorSaveItem.Text = "Save Data";
            this.bugsBindingNavigatorSaveItem.Click += new System.EventHandler(this.bugsBindingNavigatorSaveItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 662);
            this.Controls.Add(this.bugsBindingNavigator);
            this.Controls.Add(this.bugsLB);
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
            ((System.ComponentModel.ISupportInitialize)(this.bugsBindingNavigator)).EndInit();
            this.bugsBindingNavigator.ResumeLayout(false);
            this.bugsBindingNavigator.PerformLayout();
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
        private System.Windows.Forms.ListBox bugsLB;
        private BugDatabaseDataSet bugDatabaseDataSet;
        private System.Windows.Forms.BindingSource bugsBindingSource;
        private BugDatabaseDataSetTableAdapters.BugsTableAdapter bugsTableAdapter;
        private BugDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bugsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton bugsBindingNavigatorSaveItem;
    }
}

