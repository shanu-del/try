
namespace KeywordSearch
{
    partial class FormSearch
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSearch));
            this.buttonFindMatches = new System.Windows.Forms.Button();
            this.textBoxKeywords = new System.Windows.Forms.TextBox();
            this.labelFileLoadTime = new System.Windows.Forms.Label();
            this.textBoxFilePath = new System.Windows.Forms.TextBox();
            this.labelComparsionTime = new System.Windows.Forms.Label();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.listViewResults = new BrightIdeasSoftware.ObjectListView();
            this.olvColumn1 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            this.olvColumn2 = ((BrightIdeasSoftware.OLVColumn)(new BrightIdeasSoftware.OLVColumn()));
            ((System.ComponentModel.ISupportInitialize)(this.listViewResults)).BeginInit();
            this.SuspendLayout();
            // 
            // buttonFindMatches
            // 
            this.buttonFindMatches.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonFindMatches.Enabled = false;
            this.buttonFindMatches.Location = new System.Drawing.Point(923, 12);
            this.buttonFindMatches.Name = "buttonFindMatches";
            this.buttonFindMatches.Size = new System.Drawing.Size(100, 30);
            this.buttonFindMatches.TabIndex = 0;
            this.buttonFindMatches.Text = "Search";
            this.buttonFindMatches.UseVisualStyleBackColor = true;
            this.buttonFindMatches.Click += new System.EventHandler(this.buttonFindMatches_Click);
            // 
            // textBoxKeywords
            // 
            this.textBoxKeywords.Location = new System.Drawing.Point(12, 38);
            this.textBoxKeywords.Multiline = true;
            this.textBoxKeywords.Name = "textBoxKeywords";
            this.textBoxKeywords.Size = new System.Drawing.Size(130, 58);
            this.textBoxKeywords.TabIndex = 1;
            this.textBoxKeywords.Text = "Version";
            // 
            // labelFileLoadTime
            // 
            this.labelFileLoadTime.AutoSize = true;
            this.labelFileLoadTime.Location = new System.Drawing.Point(443, 15);
            this.labelFileLoadTime.Name = "labelFileLoadTime";
            this.labelFileLoadTime.Size = new System.Drawing.Size(144, 13);
            this.labelFileLoadTime.TabIndex = 3;
            this.labelFileLoadTime.Text = "File Load Time: Not Selected";
            // 
            // textBoxFilePath
            // 
            this.textBoxFilePath.Location = new System.Drawing.Point(12, 12);
            this.textBoxFilePath.Name = "textBoxFilePath";
            this.textBoxFilePath.Size = new System.Drawing.Size(347, 20);
            this.textBoxFilePath.TabIndex = 4;
            // 
            // labelComparsionTime
            // 
            this.labelComparsionTime.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.labelComparsionTime.AutoSize = true;
            this.labelComparsionTime.Location = new System.Drawing.Point(769, 15);
            this.labelComparsionTime.Name = "labelComparsionTime";
            this.labelComparsionTime.Size = new System.Drawing.Size(148, 13);
            this.labelComparsionTime.TabIndex = 5;
            this.labelComparsionTime.Text = "Comparsion Time: Not Started";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(365, 12);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(72, 20);
            this.buttonSearch.TabIndex = 6;
            this.buttonSearch.Text = "Browse File";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.buttonSearch_Click);
            // 
            // listViewResults
            // 
            this.listViewResults.AllColumns.Add(this.olvColumn1);
            this.listViewResults.AllColumns.Add(this.olvColumn2);
            this.listViewResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listViewResults.CellEditUseWholeCell = false;
            this.listViewResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.olvColumn1,
            this.olvColumn2});
            this.listViewResults.Cursor = System.Windows.Forms.Cursors.Default;
            this.listViewResults.FullRowSelect = true;
            this.listViewResults.GridLines = true;
            this.listViewResults.HideSelection = false;
            this.listViewResults.Location = new System.Drawing.Point(12, 102);
            this.listViewResults.MultiSelect = false;
            this.listViewResults.Name = "listViewResults";
            this.listViewResults.Size = new System.Drawing.Size(1011, 405);
            this.listViewResults.TabIndex = 8;
            this.listViewResults.UseCompatibleStateImageBehavior = false;
            this.listViewResults.View = System.Windows.Forms.View.Details;
            this.listViewResults.SelectedIndexChanged += new System.EventHandler(this.listViewResults_SelectedIndexChanged);
            // 
            // olvColumn1
            // 
            this.olvColumn1.AspectName = "Line";
            this.olvColumn1.IsEditable = false;
            this.olvColumn1.Searchable = false;
            this.olvColumn1.Sortable = false;
            this.olvColumn1.Text = "Line";
            this.olvColumn1.Width = 80;
            // 
            // olvColumn2
            // 
            this.olvColumn2.AspectName = "Context";
            this.olvColumn2.IsEditable = false;
            this.olvColumn2.Searchable = false;
            this.olvColumn2.Sortable = false;
            this.olvColumn2.Text = "Context";
            this.olvColumn2.Width = 32767;
            // 
            // FormSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1035, 519);
            this.Controls.Add(this.listViewResults);
            this.Controls.Add(this.buttonSearch);
            this.Controls.Add(this.labelComparsionTime);
            this.Controls.Add(this.textBoxFilePath);
            this.Controls.Add(this.labelFileLoadTime);
            this.Controls.Add(this.textBoxKeywords);
            this.Controls.Add(this.buttonFindMatches);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormSearch";
            this.Text = "Log Info Utility";
            ((System.ComponentModel.ISupportInitialize)(this.listViewResults)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonFindMatches;
        private System.Windows.Forms.TextBox textBoxKeywords;
        private System.Windows.Forms.Label labelFileLoadTime;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Label labelComparsionTime;
        private System.Windows.Forms.Button buttonSearch;
        private BrightIdeasSoftware.ObjectListView listViewResults;
        private BrightIdeasSoftware.OLVColumn olvColumn1;
        private BrightIdeasSoftware.OLVColumn olvColumn2;
    }
}

