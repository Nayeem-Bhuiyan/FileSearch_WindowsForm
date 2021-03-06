namespace SearchFileInAllDirectory
{
    partial class App
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
            this.txtSearchKeyWord = new System.Windows.Forms.TextBox();
            this.list_SearchFileDisplay = new System.Windows.Forms.ListBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtFolderDirectory = new System.Windows.Forms.TextBox();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.grid_ShowFilePath = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ShowFilePath)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchKeyWord
            // 
            this.txtSearchKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeyWord.Location = new System.Drawing.Point(752, 22);
            this.txtSearchKeyWord.Multiline = true;
            this.txtSearchKeyWord.Name = "txtSearchKeyWord";
            this.txtSearchKeyWord.Size = new System.Drawing.Size(185, 34);
            this.txtSearchKeyWord.TabIndex = 0;
           
            // 
            // list_SearchFileDisplay
            // 
            this.list_SearchFileDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_SearchFileDisplay.FormattingEnabled = true;
            this.list_SearchFileDisplay.ItemHeight = 20;
            this.list_SearchFileDisplay.Location = new System.Drawing.Point(47, 60);
            this.list_SearchFileDisplay.Name = "list_SearchFileDisplay";
            this.list_SearchFileDisplay.Size = new System.Drawing.Size(1011, 124);
            this.list_SearchFileDisplay.TabIndex = 1;
            this.list_SearchFileDisplay.SelectedIndexChanged += new System.EventHandler(this.list_SearchFileDisplay_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(940, 22);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFolderDirectory
            // 
            this.txtFolderDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderDirectory.Location = new System.Drawing.Point(47, 22);
            this.txtFolderDirectory.Multiline = true;
            this.txtFolderDirectory.Name = "txtFolderDirectory";
            this.txtFolderDirectory.Size = new System.Drawing.Size(466, 30);
            this.txtFolderDirectory.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(515, 20);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(117, 33);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grid_ShowFilePath
            // 
            this.grid_ShowFilePath.AllowUserToAddRows = false;
            this.grid_ShowFilePath.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ShowFilePath.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_ShowFilePath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ShowFilePath.Location = new System.Drawing.Point(47, 201);
            this.grid_ShowFilePath.Name = "grid_ShowFilePath";
            this.grid_ShowFilePath.Size = new System.Drawing.Size(1011, 290);
            this.grid_ShowFilePath.TabIndex = 5;
            this.grid_ShowFilePath.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ShowFilePath_CellClick_1);
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1080, 503);
            this.Controls.Add(this.grid_ShowFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolderDirectory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.list_SearchFileDisplay);
            this.Controls.Add(this.txtSearchKeyWord);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "App";
            this.Load += new System.EventHandler(this.App_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ShowFilePath)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSearchKeyWord;
        private System.Windows.Forms.ListBox list_SearchFileDisplay;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox txtFolderDirectory;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridView grid_ShowFilePath;
    }
}

