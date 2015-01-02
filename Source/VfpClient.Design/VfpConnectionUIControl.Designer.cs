namespace VfpClient.Design {
    partial class VfpConnectionUIControl {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.fileNameTableLayoutPanel = new System.Windows.Forms.TableLayoutPanel();
            this.fileNameTextBox = new System.Windows.Forms.TextBox();
            this.browseButton = new System.Windows.Forms.Button();
            this.dataSourceLabel = new System.Windows.Forms.Label();
            this.fileNameTableLayoutPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // fileNameTableLayoutPanel
            // 
            this.fileNameTableLayoutPanel.AutoSize = true;
            this.fileNameTableLayoutPanel.ColumnCount = 2;
            this.fileNameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fileNameTableLayoutPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.fileNameTableLayoutPanel.Controls.Add(this.fileNameTextBox, 0, 0);
            this.fileNameTableLayoutPanel.Controls.Add(this.browseButton, 1, 0);
            this.fileNameTableLayoutPanel.Location = new System.Drawing.Point(0, 0);
            this.fileNameTableLayoutPanel.Name = "fileNameTableLayoutPanel";
            this.fileNameTableLayoutPanel.RowCount = 1;
            this.fileNameTableLayoutPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.fileNameTableLayoutPanel.Size = new System.Drawing.Size(318, 35);
            this.fileNameTableLayoutPanel.TabIndex = 3;
            // 
            // fileNameTextBox
            // 
            this.fileNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.fileNameTextBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.fileNameTextBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.FileSystem;
            this.fileNameTextBox.Location = new System.Drawing.Point(0, 5);
            this.fileNameTextBox.Margin = new System.Windows.Forms.Padding(0, 5, 3, 3);
            this.fileNameTextBox.Name = "fileNameTextBox";
            this.fileNameTextBox.Size = new System.Drawing.Size(225, 20);
            this.fileNameTextBox.TabIndex = 2;
            this.fileNameTextBox.TextChanged += new System.EventHandler(this.SetFileName);
            // 
            // browseButton
            // 
            this.browseButton.Location = new System.Drawing.Point(243, 3);
            this.browseButton.Margin = new System.Windows.Forms.Padding(15, 3, 0, 3);
            this.browseButton.Name = "browseButton";
            this.browseButton.Size = new System.Drawing.Size(75, 25);
            this.browseButton.TabIndex = 1;
            this.browseButton.Text = "&Browse...";
            this.browseButton.UseVisualStyleBackColor = true;
            this.browseButton.Click += new System.EventHandler(this.Browse);
            // 
            // dataSourceLabel
            // 
            this.dataSourceLabel.AutoSize = true;
            this.dataSourceLabel.Location = new System.Drawing.Point(3, 10);
            this.dataSourceLabel.Name = "dataSourceLabel";
            this.dataSourceLabel.Size = new System.Drawing.Size(0, 13);
            this.dataSourceLabel.TabIndex = 0;
            // 
            // VfpConnectionUIControl
            // 
            this.Controls.Add(this.fileNameTableLayoutPanel);
            this.Controls.Add(this.dataSourceLabel);
            this.Name = "VfpConnectionUIControl";
            this.Size = new System.Drawing.Size(500, 35);
            this.fileNameTableLayoutPanel.ResumeLayout(false);
            this.fileNameTableLayoutPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel fileNameTableLayoutPanel;
        private System.Windows.Forms.TextBox fileNameTextBox;
        private System.Windows.Forms.Button browseButton;
        private System.Windows.Forms.Label dataSourceLabel;
    }
}
