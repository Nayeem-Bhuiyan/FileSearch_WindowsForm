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
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtSearchFilePath = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid_ShowFilePath)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSearchKeyWord
            // 
            this.txtSearchKeyWord.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchKeyWord.Location = new System.Drawing.Point(680, 65);
            this.txtSearchKeyWord.Name = "txtSearchKeyWord";
            this.txtSearchKeyWord.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSearchKeyWord.Size = new System.Drawing.Size(246, 35);
            this.txtSearchKeyWord.TabIndex = 0;
            this.txtSearchKeyWord.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearchKeyWord_KeyUp);
            // 
            // list_SearchFileDisplay
            // 
            this.list_SearchFileDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.list_SearchFileDisplay.FormattingEnabled = true;
            this.list_SearchFileDisplay.HorizontalScrollbar = true;
            this.list_SearchFileDisplay.ItemHeight = 20;
            this.list_SearchFileDisplay.Location = new System.Drawing.Point(680, 106);
            this.list_SearchFileDisplay.Name = "list_SearchFileDisplay";
            this.list_SearchFileDisplay.Size = new System.Drawing.Size(369, 184);
            this.list_SearchFileDisplay.TabIndex = 1;
            this.list_SearchFileDisplay.SelectedIndexChanged += new System.EventHandler(this.list_SearchFileDisplay_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Green;
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.Location = new System.Drawing.Point(932, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 34);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFolderDirectory
            // 
            this.txtFolderDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolderDirectory.Location = new System.Drawing.Point(12, 65);
            this.txtFolderDirectory.Name = "txtFolderDirectory";
            this.txtFolderDirectory.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtFolderDirectory.Size = new System.Drawing.Size(526, 26);
            this.txtFolderDirectory.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.BackColor = System.Drawing.Color.DarkMagenta;
            this.btnBrowse.ForeColor = System.Drawing.Color.White;
            this.btnBrowse.Location = new System.Drawing.Point(544, 62);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(117, 33);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grid_ShowFilePath
            // 
            this.grid_ShowFilePath.AllowUserToAddRows = false;
            this.grid_ShowFilePath.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ShowFilePath.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.grid_ShowFilePath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ShowFilePath.Location = new System.Drawing.Point(12, 101);
            this.grid_ShowFilePath.Name = "grid_ShowFilePath";
            this.grid_ShowFilePath.Size = new System.Drawing.Size(649, 516);
            this.grid_ShowFilePath.TabIndex = 5;
            this.grid_ShowFilePath.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ShowFilePath_CellClick_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(374, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(262, 39);
            this.label1.TabIndex = 6;
            this.label1.Text = "Search File App";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(680, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(369, 297);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // txtSearchFilePath
            // 
            this.txtSearchFilePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchFilePath.Location = new System.Drawing.Point(680, 294);
            this.txtSearchFilePath.Name = "txtSearchFilePath";
            this.txtSearchFilePath.ReadOnly = true;
            this.txtSearchFilePath.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.txtSearchFilePath.Size = new System.Drawing.Size(369, 23);
            this.txtSearchFilePath.TabIndex = 8;
            this.txtSearchFilePath.Text = "Search File Path";
            this.txtSearchFilePath.Visible = false;
            // 
            // App
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Cyan;
            this.ClientSize = new System.Drawing.Size(1061, 642);
            this.Controls.Add(this.txtSearchFilePath);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grid_ShowFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolderDirectory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.list_SearchFileDisplay);
            this.Controls.Add(this.txtSearchKeyWord);
            this.Name = "App";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.App_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.grid_ShowFilePath)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtSearchFilePath;
    }
}

