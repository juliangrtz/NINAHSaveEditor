using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NINAHSaveEditor {
    public partial class Start : Form {
        private const string AppID = "3180070";

        public Start() {
            InitializeComponent();
        }

        private string DetermineSaveFilePath() {
            var path = Registry.GetValue(
                "HKEY_LOCAL_MACHINE\\SOFTWARE\\WOW6432Node\\Valve\\Steam", "InstallPath", null);

            if (path == null) {
                MessageBox.Show("Steam is not installed on this computer!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return "";
            } else {
                string ninahDir = "";
                foreach (var dir in Directory.GetDirectories(path + "\\userdata")) {
                    var subDirs = Directory.GetDirectories(dir);
                    if (subDirs.Any(s => s.EndsWith(AppID))) {
                        ninahDir = dir + "\\" + AppID;
                    }
                }

                if (ninahDir == String.Empty) {
                    MessageBox.Show("'No, I'm not a human' is not installed on this computer!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    return "";
                } else {
                    return ninahDir + "\\remote";
                }
            }
        }

        private void OpenSavBtn_Click(object sender, EventArgs e) {
            var saveFilePath = DetermineSaveFilePath();
            if (saveFilePath == String.Empty) 
                return;

            var ofd = new OpenFileDialog() {
                Title = "Select save file",
                Filter = "Save file (*.sav)|*.sav",
                InitialDirectory = saveFilePath,
                RestoreDirectory = true
            };

            if (ofd.ShowDialog() == DialogResult.OK) {
                var file = ofd.FileName;
                ShowEditor(new Editor(file));
            }
        }

        private void FindBtn_Click(object sender, EventArgs e) {
            var saveFilePath = DetermineSaveFilePath();
            if (saveFilePath == String.Empty)
                return;

            ShowEditor(new Editor(saveFilePath + "\\GameSaveData.sav"));
        }

        private void ShowEditor(Editor editor) {
            Hide();
            editor.Closed += (s, args) => this.Close();
            editor.Show();
        }
    }
}
