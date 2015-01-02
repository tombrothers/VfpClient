/*
 * VFP Client for ADO.Net
 * http://vfpclient.codeplex.com/
 * http://www.randomdevnotes.com/tag/VfpClient/
 * 
 * Written by Tom Brothers (trbrothers@hotmail.com)
 * 
 * Released to the public domain, use at your own risk!
 */
using System;
using System.Windows.Forms;
using Microsoft.VisualStudio.Data;

namespace VfpClient.Design {
    public partial class VfpConnectionUIControl : DataConnectionUIControl {
        private bool _loading;

        public VfpConnectionUIControl() {
            InitializeComponent();
        }

        public override void LoadProperties() {
            this._loading = true;

            try {
                this.fileNameTextBox.Text = ConnectionProperties["Data Source"] as string;
            }
            finally {
                this._loading = false;
            }
        }

        private void SetFileName(object sender, EventArgs e) {
            if (!_loading) {
                this.ConnectionProperties["Data Source"] = this.fileNameTextBox.Text;
            }
        }

        private void Browse(object sender, EventArgs e) {
            using (var openFileDialog = new OpenFileDialog()) {
                openFileDialog.Multiselect = false;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "Microsoft Visual FoxPro Database (*.dbc)|*.dbc";

                if (this.Container != null) {
                    this.Container.Add(openFileDialog);
                }

                try {
                    var result = openFileDialog.ShowDialog(this.ParentForm);

                    if (result == DialogResult.OK) {
                        fileNameTextBox.Text = openFileDialog.FileName.Trim();
                    }
                }
                finally {
                    if (this.Container != null) {
                        this.Container.Remove(openFileDialog);
                    }

                    openFileDialog.Dispose();
                }
            }
        }
    }
}