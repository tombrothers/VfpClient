using System;
using System.Windows.Forms;
using Microsoft.Data.ConnectionUI;

namespace VfpClient.Design.ConnectionUI {
    public partial class VfpConnectionUIControl : UserControl, IDataConnectionUIControl {
        private bool _loading;
        public IDataConnectionProperties ConnectionProperties { get; private set; }

        public VfpConnectionUIControl() {
            InitializeComponent();
        }

        public void Initialize(IDataConnectionProperties connectionProperties) {
            ConnectionProperties = connectionProperties;
        }

        private void Browse(object sender, EventArgs e) {
            using (var openFileDialog = new OpenFileDialog()) {
                openFileDialog.Multiselect = false;
                openFileDialog.RestoreDirectory = true;
                openFileDialog.Filter = "Microsoft Visual FoxPro Database (*.dbc)|*.dbc";

                if (Container != null) {
                    Container.Add(openFileDialog);
                }

                try {
                    var result = openFileDialog.ShowDialog(ParentForm);

                    if (result == DialogResult.OK) {
                        fileNameTextBox.Text = openFileDialog.FileName.Trim();
                    }
                }
                finally {
                    if (Container != null) {
                        Container.Remove(openFileDialog);
                    }
                }
            }
        }

        public void LoadProperties() {
            _loading = true;

            try {
                fileNameTextBox.Text = ConnectionProperties["Data Source"] as string;
            }
            finally {
                _loading = false;
            }
        }

        private void SetFileName(object sender, EventArgs e) {
            if (!_loading) {
                ConnectionProperties["Data Source"] = fileNameTextBox.Text;
            }
        }
    }
}