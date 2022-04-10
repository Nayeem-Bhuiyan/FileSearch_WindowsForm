using Microsoft.WindowsAPICodePack.Dialogs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SearchFileInAllDirectory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }




        private IEnumerable<string> RecursiveFileSearch(string path, string pattern, ICollection<string> filePathCollector = null)
        {
            try
            {
                filePathCollector = filePathCollector ?? new LinkedList<string>();

                var matchingFilePaths = Directory.GetFiles(path, pattern);

                foreach (var matchingFile in matchingFilePaths)
                {
                    filePathCollector.Add(matchingFile);
                }

                var subDirectories = Directory.EnumerateDirectories(path);

                foreach (var subDirectory in subDirectories)
                {
                    RecursiveFileSearch(subDirectory, pattern, filePathCollector);
                }

                return filePathCollector;
            }
            catch (Exception error)
            {
                bool isIgnorableError = error is PathTooLongException ||
                    error is UnauthorizedAccessException;

                if (isIgnorableError)
                {
                    return Enumerable.Empty<string>();
                }

                throw error;
            }
        }

        private List<String> FileSearch()
        {
            List<String> files = new List<String>();
            try
            {
            
                string[] filesList = Directory.GetFiles(txtFolderDirectory.Text.ToString()!=""? txtFolderDirectory.Text.ToString(): @"C:\", "*.*", SearchOption.AllDirectories);
                files.AddRange(filesList);

            }
            catch (System.Exception excpt)
            {
                MessageBox.Show(excpt.Message);
            }

            return files;
            
        }
       

     



        private void btnSearch_Click(object sender, EventArgs e)
        {

            btnSearch.Text="Loading";

            grid_ShowFilePath.Columns.Clear();
            DataTable dt = new DataTable();
            dt.Columns.Add("File Name");
            

            DataGridViewButtonColumn btnBrowseColumn = new DataGridViewButtonColumn();
            btnBrowseColumn.UseColumnTextForButtonValue = true;
            btnBrowseColumn.Text = "Browse";
            btnBrowseColumn.Name = "btnBrowseFolder";
            btnBrowseColumn.HeaderText = "Action";
            grid_ShowFilePath.Columns.Add(btnBrowseColumn);


            IEnumerable<string> filePathList = FileSearch();
            if (filePathList!=null)
            {
                list_SearchFileDisplay.Items.Clear();

                foreach (var path in filePathList)
                {
                    string fileName=Path.GetFileName(path);
                    if (fileName.ToLower().StartsWith(txtSearchKeyWord.Text.ToLower().ToString()))
                    {
                        list_SearchFileDisplay.Items.Add(path);
                        
                        dt.Rows.Add(new object[] { path });

                    }
                    
                }

               
                grid_ShowFilePath.DataSource = dt;

                btnSearch.Text="Search";
                MessageBox.Show("Total "+list_SearchFileDisplay.Items.Count+" file found");
            }
            else
            {
                MessageBox.Show("No Match File Found");
            }
           
        }




   



        private void btnBrowse_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
            if (folderBrowser.ShowDialog() == DialogResult.OK)
                txtFolderDirectory.Text=folderBrowser.SelectedPath;
            else
                MessageBox.Show("please Select folder");
        }

        private void list_SearchFileDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.list_SearchFileDisplay.SelectedItem.ToString());
        }

        private void grid_ShowFilePath_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            grid_ShowFilePath.Rows[e.RowIndex].Selected = true;

            //System.Diagnostics.Process.Start(grid_ShowFilePath.Rows[e.RowIndex].Cells[1].Value.ToString());

            //CommonOpenFileDialog dialog = new CommonOpenFileDialog();
            //dialog.InitialDirectory = Path.GetDirectoryName(grid_ShowFilePath.Rows[e.RowIndex].Cells[1].Value.ToString());
            //dialog.IsFolderPicker = true;
            //dialog.ShowHiddenItems=true;
            //if (dialog.ShowDialog() == CommonFileDialogResult.Ok)
            //{
            //    txtFolderDirectory.Text = dialog.FileName;
            //}


            OpenFileDialog openFolder = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(grid_ShowFilePath.Rows[e.RowIndex].Cells[1].Value.ToString()),
                Title = "Browse Files",

                CheckFileExists = true,
                CheckPathExists = true,

                //DefaultExt = "txt",
                //Filter = "txt files (*.txt)|*.txt",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true
            };

            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                txtFolderDirectory.Text = openFolder.FileName;
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtFolderDirectory.Text=@"C:\Users\user\Desktop\RS";
        }
    }

    static class Helper
    {
        public static string FindCode(this string text, int codeLength=0)
        {

            string stopAt = String.Empty;
            var listOfSpecialCharecter = new[] { "_", "-", "~", "`", "!", "@", "#", "$", "%", "^", "&", "*", "(", ")", "+", "=", @"\" };
            bool isTrue = false;
            foreach (var specialCharecter in listOfSpecialCharecter)
            {
                isTrue=specialCharecter.Any(text.Contains);
                if (isTrue)
                {
                    stopAt=specialCharecter;
                }

            }

            if (!String.IsNullOrWhiteSpace(text))
            {
                int charLocation = text.IndexOf(stopAt, StringComparison.Ordinal);
                if (codeLength>0)
                {
                    if (charLocation > 0)
                    {
                        return text.Substring(0, codeLength);
                    }
                }
                else
                {
                    if (charLocation > 0)
                    {
                        return text.Substring(0, charLocation);
                    }
                }

            }

            return String.Empty;
        }
    }

}
