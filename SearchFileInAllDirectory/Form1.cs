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
    public partial class App : Form
    {
        public App()
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
            
                string[] filesList = Directory.GetFiles(txtFolderDirectory.Text.Trim().ToString()!=""? txtFolderDirectory.Text.Trim().ToString(): @"C:\", "*.*", SearchOption.AllDirectories);
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
            Cursor.Current = Cursors.WaitCursor;
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
                string SearchKeyWord = txtSearchKeyWord.Text.Trim().ToLower().ToString();
                foreach (var path in filePathList)
                {
                    string fileName = Path.GetFileName(path);
                 
                    if (fileName.ToLower().StartsWith(SearchKeyWord))
                    {
                        list_SearchFileDisplay.Items.Add(path);

                        dt.Rows.Add(new object[] { path });

                    }

                }


                grid_ShowFilePath.DataSource = dt;

                btnSearch.Text="Search";
                Cursor.Current = Cursors.Default;
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

            OpenFileDialog openFolder = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(grid_ShowFilePath.Rows[e.RowIndex].Cells[1].Value.ToString()),
                Title = "Browse Files",
                
                CheckFileExists = true,
                CheckPathExists = true,

                //DefaultExt = "txt",
                Filter = "Image Files(*.jpg;*.tif;*.psd; *.jpeg; *.gif; *.bmp)|*.jpg;*.tif;*.psd; *.jpeg; *.gif; *.bmp",
                FilterIndex = 2,
                RestoreDirectory = true,

                ReadOnlyChecked = true,
                ShowReadOnly = true,
                FileName=txtSearchKeyWord.Text.Trim().ToLower().ToString(),
                
            };

            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                Cursor.Current = Cursors.WaitCursor;
                pictureBox1.Image = new Bitmap(openFolder.FileName);
                txtFolderDirectory.Text = openFolder.FileName;
                Cursor.Current = Cursors.Default;

            }
        }
        private void App_Load_1(object sender, EventArgs e)
        {
            txtFolderDirectory.Text=@"Y:\";
        }

    }

}
