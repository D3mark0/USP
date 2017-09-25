namespace Laboratory_7
{
    partial class UFM
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBoxInput = new System.Windows.Forms.TextBox();
            this.textBoxFolder = new System.Windows.Forms.TextBox();
            this.buttonDisplay = new System.Windows.Forms.Button();
            this.buttonUp = new System.Windows.Forms.Button();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.listBoxFolders = new System.Windows.Forms.ListBox();
            this.textBoxFileName = new System.Windows.Forms.TextBox();
            this.textBoxCreationTime = new System.Windows.Forms.TextBox();
            this.textBoxLastAccessTime = new System.Windows.Forms.TextBox();
            this.textBoxLastWriteTime = new System.Windows.Forms.TextBox();
            this.textBoxFileSize = new System.Windows.Forms.TextBox();
            this.buttonMoveTo = new System.Windows.Forms.Button();
            this.buttonCopyTo = new System.Windows.Forms.Button();
            this.buttonDelete = new System.Windows.Forms.Button();
            this.textBoxNewPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.checkBoxExceptions = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // textBoxInput
            // 
            this.textBoxInput.Location = new System.Drawing.Point(12, 25);
            this.textBoxInput.Name = "textBoxInput";
            this.textBoxInput.Size = new System.Drawing.Size(336, 20);
            this.textBoxInput.TabIndex = 0;
            this.textBoxInput.Text = "C:\\";
            // 
            // textBoxFolder
            // 
            this.textBoxFolder.Location = new System.Drawing.Point(12, 52);
            this.textBoxFolder.Name = "textBoxFolder";
            this.textBoxFolder.ReadOnly = true;
            this.textBoxFolder.Size = new System.Drawing.Size(336, 20);
            this.textBoxFolder.TabIndex = 1;
            // 
            // buttonDisplay
            // 
            this.buttonDisplay.Location = new System.Drawing.Point(351, 23);
            this.buttonDisplay.Name = "buttonDisplay";
            this.buttonDisplay.Size = new System.Drawing.Size(75, 23);
            this.buttonDisplay.TabIndex = 2;
            this.buttonDisplay.Text = "Show";
            this.buttonDisplay.UseVisualStyleBackColor = true;
            this.buttonDisplay.Click += new System.EventHandler(this.OnDisplayButtonClick);
            // 
            // buttonUp
            // 
            this.buttonUp.Location = new System.Drawing.Point(351, 50);
            this.buttonUp.Name = "buttonUp";
            this.buttonUp.Size = new System.Drawing.Size(75, 23);
            this.buttonUp.TabIndex = 3;
            this.buttonUp.Text = "Up";
            this.buttonUp.UseVisualStyleBackColor = true;
            this.buttonUp.Click += new System.EventHandler(this.OnUpButtonClick);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.FormattingEnabled = true;
            this.listBoxFiles.Location = new System.Drawing.Point(12, 91);
            this.listBoxFiles.Name = "listBoxFiles";
            this.listBoxFiles.Size = new System.Drawing.Size(200, 186);
            this.listBoxFiles.TabIndex = 4;
            this.listBoxFiles.Click += new System.EventHandler(this.OnListBoxFilesSelected);
            // 
            // listBoxFolders
            // 
            this.listBoxFolders.FormattingEnabled = true;
            this.listBoxFolders.Location = new System.Drawing.Point(231, 91);
            this.listBoxFolders.Name = "listBoxFolders";
            this.listBoxFolders.Size = new System.Drawing.Size(195, 186);
            this.listBoxFolders.TabIndex = 5;
            this.listBoxFolders.Click += new System.EventHandler(this.OnListBoxFoldersSelected);
            // 
            // textBoxFileName
            // 
            this.textBoxFileName.Location = new System.Drawing.Point(55, 308);
            this.textBoxFileName.Name = "textBoxFileName";
            this.textBoxFileName.ReadOnly = true;
            this.textBoxFileName.Size = new System.Drawing.Size(335, 20);
            this.textBoxFileName.TabIndex = 6;
            // 
            // textBoxCreationTime
            // 
            this.textBoxCreationTime.Location = new System.Drawing.Point(290, 347);
            this.textBoxCreationTime.Name = "textBoxCreationTime";
            this.textBoxCreationTime.ReadOnly = true;
            this.textBoxCreationTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxCreationTime.TabIndex = 7;
            // 
            // textBoxLastAccessTime
            // 
            this.textBoxLastAccessTime.Location = new System.Drawing.Point(290, 386);
            this.textBoxLastAccessTime.Name = "textBoxLastAccessTime";
            this.textBoxLastAccessTime.ReadOnly = true;
            this.textBoxLastAccessTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastAccessTime.TabIndex = 8;
            // 
            // textBoxLastWriteTime
            // 
            this.textBoxLastWriteTime.Location = new System.Drawing.Point(55, 386);
            this.textBoxLastWriteTime.Name = "textBoxLastWriteTime";
            this.textBoxLastWriteTime.ReadOnly = true;
            this.textBoxLastWriteTime.Size = new System.Drawing.Size(100, 20);
            this.textBoxLastWriteTime.TabIndex = 9;
            // 
            // textBoxFileSize
            // 
            this.textBoxFileSize.Location = new System.Drawing.Point(55, 347);
            this.textBoxFileSize.Name = "textBoxFileSize";
            this.textBoxFileSize.ReadOnly = true;
            this.textBoxFileSize.Size = new System.Drawing.Size(100, 20);
            this.textBoxFileSize.TabIndex = 10;
            // 
            // buttonMoveTo
            // 
            this.buttonMoveTo.Location = new System.Drawing.Point(55, 458);
            this.buttonMoveTo.Name = "buttonMoveTo";
            this.buttonMoveTo.Size = new System.Drawing.Size(75, 23);
            this.buttonMoveTo.TabIndex = 11;
            this.buttonMoveTo.Text = "Move";
            this.buttonMoveTo.UseVisualStyleBackColor = true;
            this.buttonMoveTo.Click += new System.EventHandler(this.OnMoveButtonClick);
            // 
            // buttonCopyTo
            // 
            this.buttonCopyTo.Location = new System.Drawing.Point(185, 458);
            this.buttonCopyTo.Name = "buttonCopyTo";
            this.buttonCopyTo.Size = new System.Drawing.Size(75, 23);
            this.buttonCopyTo.TabIndex = 12;
            this.buttonCopyTo.Text = "Copy";
            this.buttonCopyTo.UseVisualStyleBackColor = true;
            this.buttonCopyTo.Click += new System.EventHandler(this.OnCopyButtonClick);
            // 
            // buttonDelete
            // 
            this.buttonDelete.Location = new System.Drawing.Point(316, 458);
            this.buttonDelete.Name = "buttonDelete";
            this.buttonDelete.Size = new System.Drawing.Size(75, 23);
            this.buttonDelete.TabIndex = 13;
            this.buttonDelete.Text = "Delete";
            this.buttonDelete.UseVisualStyleBackColor = true;
            this.buttonDelete.Click += new System.EventHandler(this.OnDeleteButtonClick);
            // 
            // textBoxNewPath
            // 
            this.textBoxNewPath.Location = new System.Drawing.Point(55, 432);
            this.textBoxNewPath.Name = "textBoxNewPath";
            this.textBoxNewPath.Size = new System.Drawing.Size(336, 20);
            this.textBoxNewPath.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "Path";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(28, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Files";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(228, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Folders";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(199, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "File Info";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(52, 292);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(52, 331);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 13);
            this.label6.TabIndex = 20;
            this.label6.Text = "Size";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(287, 331);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 13);
            this.label7.TabIndex = 21;
            this.label7.Text = "Creation time";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(52, 370);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(74, 13);
            this.label8.TabIndex = 22;
            this.label8.Text = "Last write time";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(287, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 13);
            this.label9.TabIndex = 23;
            this.label9.Text = "Last access time";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 416);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 24;
            this.label10.Text = "New path";
            // 
            // checkBoxExceptions
            // 
            this.checkBoxExceptions.AutoSize = true;
            this.checkBoxExceptions.Location = new System.Drawing.Point(171, 495);
            this.checkBoxExceptions.Name = "checkBoxExceptions";
            this.checkBoxExceptions.Size = new System.Drawing.Size(107, 17);
            this.checkBoxExceptions.TabIndex = 25;
            this.checkBoxExceptions.Text = "Show exceptions";
            this.checkBoxExceptions.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 524);
            this.Controls.Add(this.checkBoxExceptions);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxNewPath);
            this.Controls.Add(this.buttonDelete);
            this.Controls.Add(this.buttonCopyTo);
            this.Controls.Add(this.buttonMoveTo);
            this.Controls.Add(this.textBoxFileSize);
            this.Controls.Add(this.textBoxLastWriteTime);
            this.Controls.Add(this.textBoxLastAccessTime);
            this.Controls.Add(this.textBoxCreationTime);
            this.Controls.Add(this.textBoxFileName);
            this.Controls.Add(this.listBoxFolders);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.buttonUp);
            this.Controls.Add(this.buttonDisplay);
            this.Controls.Add(this.textBoxFolder);
            this.Controls.Add(this.textBoxInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Main";
            this.Text = "Useless File Manager";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxInput;
        private System.Windows.Forms.TextBox textBoxFolder;
        private System.Windows.Forms.Button buttonDisplay;
        private System.Windows.Forms.Button buttonUp;
        private System.Windows.Forms.ListBox listBoxFiles;
        private System.Windows.Forms.ListBox listBoxFolders;
        private System.Windows.Forms.TextBox textBoxFileName;
        private System.Windows.Forms.TextBox textBoxCreationTime;
        private System.Windows.Forms.TextBox textBoxLastAccessTime;
        private System.Windows.Forms.TextBox textBoxLastWriteTime;
        private System.Windows.Forms.TextBox textBoxFileSize;
        private System.Windows.Forms.Button buttonMoveTo;
        private System.Windows.Forms.Button buttonCopyTo;
        private System.Windows.Forms.Button buttonDelete;
        private System.Windows.Forms.TextBox textBoxNewPath;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox checkBoxExceptions;
    }
}

