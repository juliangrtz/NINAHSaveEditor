namespace NINAHSaveEditor {
    partial class Start {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Start));
            this.openSavBtn = new System.Windows.Forms.Button();
            this.findBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // openSavBtn
            // 
            this.openSavBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.openSavBtn.Location = new System.Drawing.Point(13, 13);
            this.openSavBtn.Name = "openSavBtn";
            this.openSavBtn.Size = new System.Drawing.Size(180, 47);
            this.openSavBtn.TabIndex = 0;
            this.openSavBtn.Text = "Open save file manually";
            this.openSavBtn.UseVisualStyleBackColor = true;
            this.openSavBtn.Click += new System.EventHandler(this.OpenSavBtn_Click);
            // 
            // findBtn
            // 
            this.findBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.findBtn.Location = new System.Drawing.Point(199, 12);
            this.findBtn.Name = "findBtn";
            this.findBtn.Size = new System.Drawing.Size(174, 47);
            this.findBtn.TabIndex = 1;
            this.findBtn.Text = "Find automatically\r\n(Steam Cloud)";
            this.findBtn.UseVisualStyleBackColor = true;
            this.findBtn.Click += new System.EventHandler(this.FindBtn_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(385, 26);
            this.label1.TabIndex = 2;
            this.label1.Text = "Supported game version: v1.1.18";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Start
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(385, 89);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.findBtn);
            this.Controls.Add(this.openSavBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Start";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "No, I\'m not a Human Save Editor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button openSavBtn;
        private System.Windows.Forms.Button findBtn;
        private System.Windows.Forms.Label label1;
    }
}

