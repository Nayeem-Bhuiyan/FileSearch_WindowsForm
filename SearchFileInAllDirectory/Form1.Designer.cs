﻿namespace SearchFileInAllDirectory
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
            this.txtSearchKeyWord.Location = new System.Drawing.Point(47, 48);
            this.txtSearchKeyWord.Name = "txtSearchKeyWord";
            this.txtSearchKeyWord.Size = new System.Drawing.Size(597, 20);
            this.txtSearchKeyWord.TabIndex = 0;
            // 
            // list_SearchFileDisplay
            // 
            this.list_SearchFileDisplay.FormattingEnabled = true;
            this.list_SearchFileDisplay.Location = new System.Drawing.Point(47, 73);
            this.list_SearchFileDisplay.Name = "list_SearchFileDisplay";
            this.list_SearchFileDisplay.Size = new System.Drawing.Size(721, 121);
            this.list_SearchFileDisplay.TabIndex = 1;
            this.list_SearchFileDisplay.SelectedIndexChanged += new System.EventHandler(this.list_SearchFileDisplay_SelectedIndexChanged);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(651, 48);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 23);
            this.btnSearch.TabIndex = 2;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtFolderDirectory
            // 
            this.txtFolderDirectory.Location = new System.Drawing.Point(47, 22);
            this.txtFolderDirectory.Name = "txtFolderDirectory";
            this.txtFolderDirectory.Size = new System.Drawing.Size(597, 20);
            this.txtFolderDirectory.TabIndex = 3;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(651, 22);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(117, 23);
            this.btnBrowse.TabIndex = 4;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // grid_ShowFilePath
            // 
            this.grid_ShowFilePath.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grid_ShowFilePath.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid_ShowFilePath.Location = new System.Drawing.Point(47, 201);
            this.grid_ShowFilePath.Name = "grid_ShowFilePath";
            this.grid_ShowFilePath.Size = new System.Drawing.Size(721, 150);
            this.grid_ShowFilePath.TabIndex = 5;
            this.grid_ShowFilePath.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grid_ShowFilePath_CellClick_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grid_ShowFilePath);
            this.Controls.Add(this.btnBrowse);
            this.Controls.Add(this.txtFolderDirectory);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.list_SearchFileDisplay);
            this.Controls.Add(this.txtSearchKeyWord);
            this.Name = "Form1";
            this.Text = "Form1";
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
