using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NINAHSaveEditor {
    public class Utils {
        private const string AppID = "3180070";

        public static string DetermineSaveFilePath() {
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
    }
}
