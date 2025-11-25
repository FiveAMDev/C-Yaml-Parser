namespace C__Yaml_Parser
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblFolder = new Label();
            txtFolder = new TextBox();
            chkMarkdown = new CheckBox();
            tableLayoutPanel1 = new TableLayoutPanel();
            btnBrowse = new Button();
            listFiles = new ListBox();
            txtFileName = new TextBox();
            lblFileName = new Label();
            tableLayoutPanel2 = new TableLayoutPanel();
            groupBox1 = new GroupBox();
            btnClear = new Button();
            btnDefaults = new Button();
            txtDate = new TextBox();
            txtLayout = new TextBox();
            txtAuthor = new TextBox();
            txtTitle = new TextBox();
            lblYamlDate = new Label();
            chkListCategories = new CheckedListBox();
            lblYamlCategs = new Label();
            lblYamlLayout = new Label();
            lblYamlAuthor = new Label();
            lblYamlTitle = new Label();
            textBox1 = new TextBox();
            lblContents = new Label();
            btnSave = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // lblFolder
            // 
            lblFolder.AutoSize = true;
            lblFolder.Location = new Point(3, 0);
            lblFolder.Name = "lblFolder";
            lblFolder.Size = new Size(43, 15);
            lblFolder.TabIndex = 0;
            lblFolder.Text = "Folder:";
            lblFolder.Click += lblFolder_Click;
            // 
            // txtFolder
            // 
            txtFolder.Location = new Point(57, 3);
            txtFolder.Name = "txtFolder";
            txtFolder.Size = new Size(318, 23);
            txtFolder.TabIndex = 1;
            // 
            // chkMarkdown
            // 
            chkMarkdown.AutoSize = true;
            chkMarkdown.Location = new Point(468, 3);
            chkMarkdown.Name = "chkMarkdown";
            chkMarkdown.Size = new Size(148, 19);
            chkMarkdown.TabIndex = 3;
            chkMarkdown.Text = "Markdown Only (*.md)";
            chkMarkdown.UseVisualStyleBackColor = true;
            chkMarkdown.CheckedChanged += chkMarkdown_CheckedChanged;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 4;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 325F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 86F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 184F));
            tableLayoutPanel1.Controls.Add(chkMarkdown, 3, 0);
            tableLayoutPanel1.Controls.Add(txtFolder, 1, 0);
            tableLayoutPanel1.Controls.Add(lblFolder, 0, 0);
            tableLayoutPanel1.Controls.Add(btnBrowse, 2, 0);
            tableLayoutPanel1.Location = new Point(12, 12);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 1;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Size = new Size(649, 36);
            tableLayoutPanel1.TabIndex = 4;
            // 
            // btnBrowse
            // 
            btnBrowse.Location = new Point(382, 3);
            btnBrowse.Name = "btnBrowse";
            btnBrowse.Size = new Size(75, 23);
            btnBrowse.TabIndex = 4;
            btnBrowse.Text = "Browse..";
            btnBrowse.UseVisualStyleBackColor = true;
            btnBrowse.Click += btnBrowse_Click;
            // 
            // listFiles
            // 
            listFiles.FormattingEnabled = true;
            listFiles.Location = new Point(15, 73);
            listFiles.Name = "listFiles";
            listFiles.Size = new Size(292, 439);
            listFiles.TabIndex = 5;
            listFiles.SelectedIndexChanged += listFiles_SelectedIndexChanged;
            // 
            // txtFileName
            // 
            txtFileName.Location = new Point(76, 3);
            txtFileName.Name = "txtFileName";
            txtFileName.Size = new Size(321, 23);
            txtFileName.TabIndex = 6;
            // 
            // lblFileName
            // 
            lblFileName.AutoSize = true;
            lblFileName.Location = new Point(3, 0);
            lblFileName.Name = "lblFileName";
            lblFileName.Size = new Size(63, 15);
            lblFileName.TabIndex = 7;
            lblFileName.Text = "File Name:";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.63285F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 82.36715F));
            tableLayoutPanel2.Controls.Add(lblFileName, 0, 0);
            tableLayoutPanel2.Controls.Add(txtFileName, 1, 0);
            tableLayoutPanel2.Location = new Point(331, 73);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(414, 54);
            tableLayoutPanel2.TabIndex = 8;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnClear);
            groupBox1.Controls.Add(btnDefaults);
            groupBox1.Controls.Add(txtDate);
            groupBox1.Controls.Add(txtLayout);
            groupBox1.Controls.Add(txtAuthor);
            groupBox1.Controls.Add(txtTitle);
            groupBox1.Controls.Add(lblYamlDate);
            groupBox1.Controls.Add(chkListCategories);
            groupBox1.Controls.Add(lblYamlCategs);
            groupBox1.Controls.Add(lblYamlLayout);
            groupBox1.Controls.Add(lblYamlAuthor);
            groupBox1.Controls.Add(lblYamlTitle);
            groupBox1.Location = new Point(331, 133);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(417, 208);
            groupBox1.TabIndex = 9;
            groupBox1.TabStop = false;
            groupBox1.Text = "Yaml Data (FrontMatter)";
            // 
            // btnClear
            // 
            btnClear.Location = new Point(304, 168);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(75, 23);
            btnClear.TabIndex = 12;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            // 
            // btnDefaults
            // 
            btnDefaults.Location = new Point(222, 168);
            btnDefaults.Name = "btnDefaults";
            btnDefaults.Size = new Size(75, 23);
            btnDefaults.TabIndex = 11;
            btnDefaults.Text = "Defaults";
            btnDefaults.UseVisualStyleBackColor = true;
            // 
            // txtDate
            // 
            txtDate.Location = new Point(85, 127);
            txtDate.Name = "txtDate";
            txtDate.Size = new Size(100, 23);
            txtDate.TabIndex = 10;
            // 
            // txtLayout
            // 
            txtLayout.Location = new Point(86, 94);
            txtLayout.Name = "txtLayout";
            txtLayout.Size = new Size(100, 23);
            txtLayout.TabIndex = 9;
            // 
            // txtAuthor
            // 
            txtAuthor.Location = new Point(86, 65);
            txtAuthor.Name = "txtAuthor";
            txtAuthor.Size = new Size(100, 23);
            txtAuthor.TabIndex = 8;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(86, 33);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(100, 23);
            txtTitle.TabIndex = 7;
            // 
            // lblYamlDate
            // 
            lblYamlDate.AutoSize = true;
            lblYamlDate.Location = new Point(15, 135);
            lblYamlDate.Name = "lblYamlDate";
            lblYamlDate.Size = new Size(34, 15);
            lblYamlDate.TabIndex = 6;
            lblYamlDate.Text = "Date:";
            // 
            // chkListCategories
            // 
            chkListCategories.FormattingEnabled = true;
            chkListCategories.Location = new Point(243, 41);
            chkListCategories.Name = "chkListCategories";
            chkListCategories.Size = new Size(120, 94);
            chkListCategories.TabIndex = 4;
            // 
            // lblYamlCategs
            // 
            lblYamlCategs.AutoSize = true;
            lblYamlCategs.Location = new Point(243, 23);
            lblYamlCategs.Name = "lblYamlCategs";
            lblYamlCategs.Size = new Size(66, 15);
            lblYamlCategs.TabIndex = 3;
            lblYamlCategs.Text = "Categories:";
            // 
            // lblYamlLayout
            // 
            lblYamlLayout.AutoSize = true;
            lblYamlLayout.Location = new Point(16, 102);
            lblYamlLayout.Name = "lblYamlLayout";
            lblYamlLayout.Size = new Size(46, 15);
            lblYamlLayout.TabIndex = 2;
            lblYamlLayout.Text = "Layout:";
            // 
            // lblYamlAuthor
            // 
            lblYamlAuthor.AutoSize = true;
            lblYamlAuthor.Location = new Point(16, 73);
            lblYamlAuthor.Name = "lblYamlAuthor";
            lblYamlAuthor.Size = new Size(47, 15);
            lblYamlAuthor.TabIndex = 1;
            lblYamlAuthor.Text = "Author:";
            // 
            // lblYamlTitle
            // 
            lblYamlTitle.AutoSize = true;
            lblYamlTitle.Location = new Point(15, 41);
            lblYamlTitle.Name = "lblYamlTitle";
            lblYamlTitle.Size = new Size(59, 15);
            lblYamlTitle.TabIndex = 0;
            lblYamlTitle.Text = "Post Title:";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(334, 383);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(414, 128);
            textBox1.TabIndex = 10;
            // 
            // lblContents
            // 
            lblContents.AutoSize = true;
            lblContents.Location = new Point(332, 365);
            lblContents.Name = "lblContents";
            lblContents.Size = new Size(58, 15);
            lblContents.TabIndex = 11;
            lblContents.Text = "Contents:";
            // 
            // btnSave
            // 
            btnSave.Location = new Point(670, 517);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 12;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(757, 554);
            Controls.Add(btnSave);
            Controls.Add(lblContents);
            Controls.Add(textBox1);
            Controls.Add(groupBox1);
            Controls.Add(tableLayoutPanel2);
            Controls.Add(listFiles);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblFolder;
        private TextBox txtFolder;
        private CheckBox chkMarkdown;
        private TableLayoutPanel tableLayoutPanel1;
        private Button btnBrowse;
        private ListBox listFiles;
        private TextBox txtFileName;
        private Label lblFileName;
        private TableLayoutPanel tableLayoutPanel2;
        private GroupBox groupBox1;
        private MaskedTextBox maskedTextBox1;
        private CheckedListBox chkListCategories;
        private Label lblYamlCategs;
        private Label lblYamlLayout;
        private Label lblYamlAuthor;
        private Label lblYamlTitle;
        private Label lblYamlDate;
        private Button btnClear;
        private Button btnDefaults;
        private TextBox txtDate;
        private TextBox txtLayout;
        private TextBox txtAuthor;
        private TextBox txtTitle;
        private TextBox textBox1;
        private Label lblContents;
        private Button btnSave;
    }
}
