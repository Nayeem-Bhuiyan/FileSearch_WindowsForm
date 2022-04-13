using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace SearchFileInAllDirectory
{
    public partial class App : Form
    {
        static string CurrentDirectory = Directory.GetCurrentDirectory();
        static int RootDirectory = CurrentDirectory.IndexOf("SearchFileInAllDirectory");
        // static string DefaultImagePath = CurrentDirectory.Substring(0, RootDirectory)+"SearchFileInAllDirectory"+"\\"+"Image"+"\\"+"NoImage.jpg";
        static string DefaultImagePath = CurrentDirectory.Substring(0, RootDirectory)+"SearchFileInAllDirectory"+"\\"+"Image"+"\\"+"NoImage.jpg";
        public App()
        {

           
            InitializeComponent();

            //pictureBox1.Image = new Bitmap(DefaultImagePath);
        }


       


        List<String> files = new List<String>();
        private List<String> CollectAllFiles()
        {

            try
            {

                string[] filesList = Directory.GetFiles(txtFolderDirectory.Text.Trim().ToString()!="" ? txtFolderDirectory.Text.Trim().ToString() : @"Z:\", "*.*", SearchOption.AllDirectories);
                files.Clear();
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
            SearchFileEvent();

        }
        private void txtSearchKeyWord_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SearchFileEvent();
            }
        }

        private void SearchFileEvent()
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;
                pictureBox1.Image = new Bitmap(DefaultImagePath);
                btnSearch.Text="Loading";
                btnSearch.Enabled=true;

                grid_ShowFilePath.Columns.Clear();
                DataTable dt = new DataTable();
                dt.Columns.Add("File Name");


                DataGridViewButtonColumn btnBrowseColumn = new DataGridViewButtonColumn();
                btnBrowseColumn.UseColumnTextForButtonValue = true;
                btnBrowseColumn.Text = "Browse";
                btnBrowseColumn.Name = "btnBrowseFolder";
                btnBrowseColumn.HeaderText = "Action";
                grid_ShowFilePath.Columns.Add(btnBrowseColumn);



                if (files!=null)
                {
                    list_SearchFileDisplay.Items.Clear();
                    string SearchKeyWord = txtSearchKeyWord.Text.Trim().ToLower().ToString();
                    foreach (var path in files)
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }





        private void btnBrowse_Click(object sender, EventArgs e)
        {
            try
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    Cursor.Current = Cursors.WaitCursor;
                    txtSearchFilePath.Text=folderBrowser.SelectedPath;
                    CollectAllFiles();
                    Cursor.Current = Cursors.Default;
                }
                else
                    MessageBox.Show("please Select folder");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void list_SearchFileDisplay_SelectedIndexChanged(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(this.list_SearchFileDisplay.SelectedItem.ToString());
            Cursor.Current = Cursors.WaitCursor;
            pictureBox1.Image = new Bitmap(this.list_SearchFileDisplay.SelectedItem.ToString());
            Cursor.Current = Cursors.Default;
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

                Filter = "All files (*.*)|*.*",
                FilterIndex = 2,
                RestoreDirectory = true,
                ReadOnlyChecked = true,
                ShowReadOnly = true,
                FileName=Path.GetFileName(grid_ShowFilePath.Rows[e.RowIndex].Cells[1].Value.ToString()),

            };

            if (openFolder.ShowDialog() == DialogResult.OK)
            {
                try
                {

                    Cursor.Current = Cursors.WaitCursor;
                    
                    txtSearchFilePath.Text ="";
                    txtSearchFilePath.Text = openFolder.FileName;
                    //pictureBox1.Image = Image.FromFile(openFolder.FileName);
                    pictureBox1.Image = new Bitmap(openFolder.FileName);
                    Cursor.Current = Cursors.Default;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading image" + ex.Message);
                }


            }
        }
        private void App_Load_1(object sender, EventArgs e)
        {

            try
            {
                txtFolderDirectory.Text=@"Y:\";
                this.ActiveControl = txtSearchKeyWord;


                FileStream fs = new System.IO.FileStream(DefaultImagePath, FileMode.Open, FileAccess.Read);
                pictureBox1.Image = Image.FromStream(fs);
                fs.Close();

                Thread t = new Thread(new ThreadStart(Splash));
                t.Start();
                CollectAllFiles();
                t.Abort();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        void Splash()
        {
            //Open a splash screen form
            SplashScreen.SplashForm flashScreen = new SplashScreen.SplashForm();
            flashScreen.Font = new Font("Time New Romans", 7);
            flashScreen.AppName = "Please Wait Loading";
            //frm.Icon = Properties.Resources.app;//Load icon from resource
            //flashScreen.ShowIcon = false;
            flashScreen.ShowInTaskbar = true;
            Application.Run(flashScreen);
        }


    }

}
