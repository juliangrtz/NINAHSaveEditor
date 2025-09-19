using Microsoft.Win32;
using System;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace NINAHSaveEditor {
    public partial class Start : Form {
        public Start() {
            InitializeComponent();
        }

        private void OpenSavBtn_Click(object sender, EventArgs e) {
            var saveFilePath = Utils.DetermineSaveFilePath();
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
            var saveFilePath = Utils.DetermineSaveFilePath();
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
