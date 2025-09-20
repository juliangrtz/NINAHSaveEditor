using System;
using System.IO;
using System.Reflection;
using System.Windows.Forms;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using NINAHSaveEditor.Crypto;

namespace NINAHSaveEditor {
    public partial class Editor : Form {
        private readonly string chosenFilePath;

        private readonly string version =
            Assembly.GetExecutingAssembly().GetName().Version.ToString().Substring(0, 3);

        private JObject save;

        public Editor() {
            InitializeComponent();
            Text += " | v" + version;
        }

        public Editor(string filePath) {
            InitializeComponent();
            Text += " | v" + version;
            chosenFilePath = filePath;

            try {
                ReadData(chosenFilePath);
            } catch (Exception ex) {
                MessageBox.Show("Something failed during the decryption:\n" + ex, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void ReadData(string path, bool decrypt = true) {
            var json = decrypt ? AES.Decrypt(File.ReadAllText(path)) : File.ReadAllText(path);

            save = JsonConvert.DeserializeObject<JObject>(json);
            var values = (JObject)save["Values"];
            jsonTreeView.SetObjectAsJson(values);
            jsonTreeView.ExpandAll();

            // Consumables
            var consumables = values[Types.ConsumablesSavesData]["Storage"];
            bobeerCtrl.Value = (int)consumables["Bobeer"];
            cigsCtrl.Value = (int)consumables["Cigarette"];
            coffeeCtrl.Value = (int)consumables["Coffee"];
            enerjekaCtrl.Value = (int)consumables["Enerjeka"];
            pillsCtrl.Value = (int)consumables["Pills"];
            cockroachesCtrl.Value = (int)consumables["Cockroach"];
            catFoodCtrl.Value = (int)consumables["CatFood"];
            mushroomsCtrl.Value = (int)consumables["Mushroom"];
            povistkaCtrl.Value = (int)consumables["Povistka"];
            kombuchaCtrl.Value = (int)consumables["Kombucha"];
            photoCtrl.Value = (int)consumables["Photo"];

            // Object states
            var objectStates = values[Types.StateObjectSavesData]["ObjectsStates"];
            stateCarpetCtrl.Checked = Int2Bool((int)objectStates["Carpet"]);
            stateGroundCtrl.Checked = Int2Bool((int)objectStates["Ground"]);
            stateWindowCtrl.Checked = Int2Bool((int)objectStates["WindowBoardsTriggers"]);
            statePeepholeCtrl.Checked = Int2Bool((int)objectStates["PeepholeEndingTrigger"]);
            stateHatchCtrl.Checked = Int2Bool((int)objectStates["HatchEnter"]);
            stateAppleCtrl.Checked = Int2Bool((int)objectStates["Apple"]);
            stateClockCtrl.Checked = Int2Bool((int)objectStates["Clock"]);
            stateCultistSheetsCtrl.Checked = Int2Bool((int)objectStates["CultistsSheets"]);
            stateHusbandCtrl.Checked = Int2Bool((int)objectStates["Husband"]);
            stateTunnelBlockerCtrl.Checked = Int2Bool((int)objectStates["TunnelBlocker"]);
            stateBlackHoleCtrl.Checked = Int2Bool((int)objectStates["BlackHole"]);
            stateHoleInteractCtrl.Checked = Int2Bool((int)objectStates["HoleInteract"]);
        }

        private bool Int2Bool(int i) => i == 1;
        private int Checkbox2Int(CheckBox cb) => cb.Checked ? 1 : 0;

        private void ApplyChangesBtn_Click(object sender, EventArgs e) {
            try {
                WriteChanges();
            } catch (Exception ex) {
                MessageBox.Show("Something failed during the encryption:\n" + ex, "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void WriteChanges() {
            // Consumables
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Bobeer"] = (int)bobeerCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Cigarette"] = (int)cigsCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Coffee"] = (int)coffeeCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Enerjeka"] = (int)enerjekaCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Pills"] = (int)pillsCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Cockroach"] = (int)cockroachesCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["CatFood"] = (int)catFoodCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Mushroom"] = (int)mushroomsCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Povistka"] = (int)povistkaCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Kombucha"] = (int)kombuchaCtrl.Value;
            save["Values"][Types.ConsumablesSavesData]["Storage"]["Photo"] = (int)photoCtrl.Value;

            var controllerStr = (string)save["_jsonValues"][Types.ConsumablesController];
            var controllerObj = JsonConvert.DeserializeObject<JObject>(controllerStr);
            var storageObj = (JObject)controllerObj["Storage"];

            storageObj["Bobeer"] = (int)bobeerCtrl.Value;
            storageObj["Cigarette"] = (int)cigsCtrl.Value;
            storageObj["Coffee"] = (int)coffeeCtrl.Value;
            storageObj["Enerjeka"] = (int)enerjekaCtrl.Value;
            storageObj["Pills"] = (int)pillsCtrl.Value;
            storageObj["Mushroom"] = (int)mushroomsCtrl.Value;
            storageObj["CatFood"] = (int)catFoodCtrl.Value;
            storageObj["Povistka"] = (int)povistkaCtrl.Value;
            storageObj["Kombucha"] = (int)kombuchaCtrl.Value;
            storageObj["Photo"] = (int)photoCtrl.Value;
            storageObj["Cockroach"] = (int)cockroachesCtrl.Value;

            save["_jsonValues"][Types.ConsumablesController] = JsonConvert.SerializeObject(controllerObj);

            // Object states
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["Carpet"] = Checkbox2Int(stateCarpetCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["Ground"] = Checkbox2Int(stateGroundCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["WindowBoardsTriggers"] = Checkbox2Int(stateWindowCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["PeepholeEndingTrigger"] = Checkbox2Int(statePeepholeCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["HatchEnter"] = Checkbox2Int(stateHatchCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["Apple"] = stateAppleCtrl.Checked ? 1 : 0;
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["Clock"] = Checkbox2Int(stateClockCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["CultistsSheets"] = Checkbox2Int(stateCultistSheetsCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["Husband"] = Checkbox2Int(stateHusbandCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["TunnelBlocker"] = Checkbox2Int(stateTunnelBlockerCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["BlackHole"] = Checkbox2Int(stateBlackHoleCtrl);
            save["Values"][Types.StateObjectSavesData]["ObjectsStates"]["HoleInteract"] = Checkbox2Int(stateHoleInteractCtrl);

            var stateControllerStr = (string)save["_jsonValues"][Types.StateObjectController];
            var stateControllerObj = JsonConvert.DeserializeObject<JObject>(stateControllerStr);
            var objectsStatesObj = (JObject)stateControllerObj["ObjectsStates"];

            objectsStatesObj["Carpet"] = Checkbox2Int(stateCarpetCtrl);
            objectsStatesObj["Ground"] = Checkbox2Int(stateGroundCtrl);
            objectsStatesObj["WindowBoardsTriggers"] = Checkbox2Int(stateWindowCtrl);
            objectsStatesObj["PeepholeEndingTrigger"] = Checkbox2Int(statePeepholeCtrl);
            objectsStatesObj["HatchEnter"] = Checkbox2Int(stateHatchCtrl);
            objectsStatesObj["Apple"] = Checkbox2Int(stateAppleCtrl);
            objectsStatesObj["Clock"] = Checkbox2Int(stateClockCtrl);
            objectsStatesObj["CultistsSheets"] = Checkbox2Int(stateCultistSheetsCtrl);
            objectsStatesObj["Husband"] = Checkbox2Int(stateHusbandCtrl);
            objectsStatesObj["TunnelBlocker"] = Checkbox2Int(stateTunnelBlockerCtrl);
            objectsStatesObj["BlackHole"] = Checkbox2Int(stateBlackHoleCtrl);
            objectsStatesObj["HoleInteract"] = Checkbox2Int(stateHoleInteractCtrl);

            save["_jsonValues"][Types.StateObjectController] = JsonConvert.SerializeObject(stateControllerObj);

            var json = JsonConvert.SerializeObject(save);
            var encrypted = AES.Encrypt(json);
            File.WriteAllText(chosenFilePath, encrypted);

            MessageBox.Show(
                "Please restart the game and click 'Continue'.",
                "Changes applied!",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }

        private void ImportJSONToolStripMenuItem_Click(object sender, EventArgs e) {
            var ofd = new OpenFileDialog {
                Title = "Import edited JSON file into editor",
                InitialDirectory = Utils.DetermineSaveFilePath(),
                Filter = "JSON file (*.json)|*.json"
            };

            if (ofd.ShowDialog() == DialogResult.OK) {
                ReadData(ofd.FileName, false);
                MessageBox.Show("Imported successfully.");
            }
        }

        private void ExportJSONToolStripMenuItem_Click(object sender, EventArgs e) {
            var sfd = new SaveFileDialog {
                Title = "Export current save file as JSON",
                FileName = "GameSaveData.json",
                InitialDirectory = Utils.DetermineSaveFilePath(),
                Filter = "JSON file (*.json)|*.json"
            };

            if (sfd.ShowDialog() == DialogResult.OK) {
                File.WriteAllText(sfd.FileName, JsonConvert.SerializeObject(save, Formatting.Indented));
                MessageBox.Show("File saved.");
            }
        }

        private void ExitToolStripMenuItem_Click(object sender, EventArgs e) {
            Application.Exit();
        }

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e) {
            MessageBox.Show(
                "Programmed by juliangrtz with explicit permission from the Trioskaz team.",
                Text,
                MessageBoxButtons.OK,
                MessageBoxIcon.Information
            );
        }
    }
}