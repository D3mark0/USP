using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Laboratory_7
{
    public partial class UFM : Form
    {
        private string currentFolderPath;
        
        public UFM()
        { InitializeComponent(); }

        protected void ClearAllFields()
        {
            listBoxFolders.Items.Clear();
            listBoxFiles.Items.Clear();
            textBoxFolder.Text = "";
            textBoxFolder.Text = "";
            textBoxFileName.Text = "";
            textBoxCreationTime.Text = "";
            textBoxLastAccessTime.Text = "";
            textBoxLastWriteTime.Text = "";
            textBoxFileSize.Text = "";
        }

        protected void DisplayFileInfo(string fileFullName)
        {
            FileInfo theFile = new FileInfo(fileFullName);
            if (!theFile.Exists)
                throw new FileNotFoundException("File not found: " + fileFullName);

            textBoxFileName.Text = theFile.Name;
            textBoxCreationTime.Text = theFile.CreationTime.ToLongTimeString();
            textBoxLastAccessTime.Text = theFile.LastAccessTime.ToLongDateString();
            textBoxLastWriteTime.Text = theFile.LastWriteTime.ToLongDateString();
            textBoxFileSize.Text = theFile.Length.ToString() + "bytes";
            
            textBoxNewPath.Text = theFile.FullName;
            textBoxNewPath.Enabled = true;
            buttonCopyTo.Enabled = true;
            buttonDelete.Enabled = true;
            buttonMoveTo.Enabled = true;
        }

        protected void DisplayFolderList(string folderFullName)
        {
            DirectoryInfo theFolder = new DirectoryInfo(folderFullName);

            if (!theFolder.Exists)
                throw new DirectoryNotFoundException("Folder not found: " + folderFullName);

            ClearAllFields();
            DisableMoveFeatures();
            textBoxFolder.Text = theFolder.FullName;
            currentFolderPath = theFolder.FullName;
            
            foreach (DirectoryInfo nextFolder in theFolder.GetDirectories())
                listBoxFolders.Items.Add(nextFolder.Name);
            
            foreach (FileInfo nextFile in theFolder.GetFiles())
                listBoxFiles.Items.Add(nextFile.Name);
        }

        protected void OnDisplayButtonClick(object sender, EventArgs e)
        {
            try
            {
                string folderPath = textBoxInput.Text;
                DirectoryInfo theFolder = new DirectoryInfo(folderPath);
                FileInfo theFile = new FileInfo(folderPath);

                if (theFolder.Exists)
                {
                    DisplayFolderList(theFolder.FullName);
                    return;
                }
                
                if (theFile.Exists)
                {
                    DisplayFolderList(theFile.Directory.FullName);
                    int index = listBoxFiles.Items.IndexOf(theFile.Name);
                    listBoxFiles.SetSelected(index, true);
                    return;
                }
                throw new FileNotFoundException("There is no file or folder with" + "this name: " + textBoxInput.Text);
            }
            catch (Exception ex)
            {
                if(checkBoxExceptions.Checked)
                    MessageBox.Show(ex.Message);
            }
        }

        void DisableMoveFeatures()
        {
            textBoxNewPath.Text = "";
            textBoxNewPath.Enabled = false;
            buttonCopyTo.Enabled = false;
            buttonDelete.Enabled = false;
            buttonMoveTo.Enabled = false;
        }
        
        protected void OnListBoxFilesSelected(object sender, EventArgs e)
        {
            try
            {
                string selectedString = listBoxFiles.SelectedItem.ToString();
                string fullFileName = Path.Combine(currentFolderPath, selectedString);
                DisplayFileInfo(fullFileName);
            }
            catch (Exception ex)
            {
                if (checkBoxExceptions.Checked)
                    MessageBox.Show(ex.Message);
            }
        }
        
        protected void OnListBoxFoldersSelected(object sender, EventArgs e)
        {
            try
            {
                string selectedString = listBoxFolders.SelectedItem.ToString();
                string fullPathName = Path.Combine(currentFolderPath, selectedString);
                DisplayFolderList(fullPathName);
            }
            catch (Exception ex)
            {
                if (checkBoxExceptions.Checked)
                    MessageBox.Show(ex.Message);
            }
        }

        protected void OnUpButtonClick(object sender, EventArgs e)
        {
            try
            {
                string folderPath = new
                FileInfo(currentFolderPath).DirectoryName;
                DisplayFolderList(folderPath);
            }
            catch (Exception ex)
            {
                if (checkBoxExceptions.Checked)
                    MessageBox.Show(ex.Message);
            }
        }

        protected void OnDeleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(currentFolderPath, textBoxFileName.Text);
                string query = "Really delete the file\n" + filePath + "?";
                if (MessageBox.Show(query, "Delete File?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Delete(filePath);
                    DisplayFolderList(currentFolderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete file. The following exception" + "occurred:\n" + ex.Message, "Failed");
            }
        }

        protected void OnMoveButtonClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(currentFolderPath, textBoxFileName.Text);
                string query = "Really move the file\n" + filePath + "\nto " + textBoxNewPath.Text + "?";
                if (MessageBox.Show(query, "Move the file?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Move(filePath, textBoxNewPath.Text);
                    DisplayFolderList(currentFolderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to move file. The following exception" + "occurred:\n" + ex.Message, "Failed");
            }
        }

        protected void OnCopyButtonClick(object sender, EventArgs e)
        {
            try
            {
                string filePath = Path.Combine(currentFolderPath, textBoxFileName.Text);
                string query = "Really copy the file\n" + filePath + "\nto"
                + textBoxNewPath.Text + "?";
                if (MessageBox.Show(query, "Copy the file?", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    File.Copy(filePath, textBoxNewPath.Text);
                    DisplayFolderList(currentFolderPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to copy file. The following exception" + "occurred:\n" + ex.Message, "Failed");
            }
        }
    }
}