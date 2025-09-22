using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;

namespace NINAHSaveEditor.Forms {
    public partial class ObjectTreeView : Form {
        public ObjectTreeView(JObject obj) {
            InitializeComponent();
            jsonTreeView.SetObjectAsJson(obj);
            jsonTreeView.ExpandAll();

            this.WindowState = FormWindowState.Maximized;
        }
    }
}
