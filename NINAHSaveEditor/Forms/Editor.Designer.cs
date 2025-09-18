namespace NINAHSaveEditor {
    partial class Editor {
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Editor));
            this.applyChangesBtn = new System.Windows.Forms.Button();
            this.catFoodCtrl = new System.Windows.Forms.NumericUpDown();
            this.catFoodLbl = new System.Windows.Forms.Label();
            this.jsonTreeView = new System.Windows.Forms.TreeView();
            this.bobeerLbl = new System.Windows.Forms.Label();
            this.bobeerCtrl = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.consumablesGroupBox = new System.Windows.Forms.GroupBox();
            this.photoCtrl = new System.Windows.Forms.NumericUpDown();
            this.photoLbl = new System.Windows.Forms.Label();
            this.kombuchaCtrl = new System.Windows.Forms.NumericUpDown();
            this.kombuchaLbl = new System.Windows.Forms.Label();
            this.povistkaCtrl = new System.Windows.Forms.NumericUpDown();
            this.povistkaLbl = new System.Windows.Forms.Label();
            this.mushroomsCtrl = new System.Windows.Forms.NumericUpDown();
            this.mushroomsLbl = new System.Windows.Forms.Label();
            this.cockroachesLbl = new System.Windows.Forms.Label();
            this.cockroachesCtrl = new System.Windows.Forms.NumericUpDown();
            this.pillsLbl = new System.Windows.Forms.Label();
            this.pillsCtrl = new System.Windows.Forms.NumericUpDown();
            this.enerjekaLbl = new System.Windows.Forms.Label();
            this.enerjekaCtrl = new System.Windows.Forms.NumericUpDown();
            this.coffeeCtrl = new System.Windows.Forms.NumericUpDown();
            this.coffeeLbl = new System.Windows.Forms.Label();
            this.cigsCtrl = new System.Windows.Forms.NumericUpDown();
            this.cigsLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportJSONToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.catFoodCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobeerCtrl)).BeginInit();
            this.consumablesGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kombuchaCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.povistkaCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomsCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cockroachesCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillsCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.enerjekaCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeCtrl)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigsCtrl)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // applyChangesBtn
            // 
            this.applyChangesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.applyChangesBtn.Location = new System.Drawing.Point(9, 283);
            this.applyChangesBtn.Name = "applyChangesBtn";
            this.applyChangesBtn.Size = new System.Drawing.Size(335, 43);
            this.applyChangesBtn.TabIndex = 0;
            this.applyChangesBtn.Text = "Apply changes";
            this.applyChangesBtn.UseVisualStyleBackColor = true;
            this.applyChangesBtn.Click += new System.EventHandler(this.ApplyChangesBtn_Click);
            // 
            // catFoodCtrl
            // 
            this.catFoodCtrl.Location = new System.Drawing.Point(276, 73);
            this.catFoodCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.catFoodCtrl.Name = "catFoodCtrl";
            this.catFoodCtrl.Size = new System.Drawing.Size(50, 20);
            this.catFoodCtrl.TabIndex = 1;
            // 
            // catFoodLbl
            // 
            this.catFoodLbl.AutoSize = true;
            this.catFoodLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.catFoodLbl.Location = new System.Drawing.Point(189, 76);
            this.catFoodLbl.Name = "catFoodLbl";
            this.catFoodLbl.Size = new System.Drawing.Size(57, 16);
            this.catFoodLbl.TabIndex = 2;
            this.catFoodLbl.Text = "Cat food";
            // 
            // jsonTreeView
            // 
            this.jsonTreeView.Location = new System.Drawing.Point(350, 27);
            this.jsonTreeView.Name = "jsonTreeView";
            this.jsonTreeView.Size = new System.Drawing.Size(524, 299);
            this.jsonTreeView.TabIndex = 3;
            // 
            // bobeerLbl
            // 
            this.bobeerLbl.AutoSize = true;
            this.bobeerLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bobeerLbl.Location = new System.Drawing.Point(7, 46);
            this.bobeerLbl.Name = "bobeerLbl";
            this.bobeerLbl.Size = new System.Drawing.Size(52, 16);
            this.bobeerLbl.TabIndex = 4;
            this.bobeerLbl.Text = "Bobeer";
            // 
            // bobeerCtrl
            // 
            this.bobeerCtrl.Location = new System.Drawing.Point(102, 44);
            this.bobeerCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.bobeerCtrl.Name = "bobeerCtrl";
            this.bobeerCtrl.Size = new System.Drawing.Size(50, 20);
            this.bobeerCtrl.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 6;
            this.label2.Text = "Consumables";
            // 
            // consumablesGroupBox
            // 
            this.consumablesGroupBox.Controls.Add(this.photoCtrl);
            this.consumablesGroupBox.Controls.Add(this.photoLbl);
            this.consumablesGroupBox.Controls.Add(this.kombuchaCtrl);
            this.consumablesGroupBox.Controls.Add(this.kombuchaLbl);
            this.consumablesGroupBox.Controls.Add(this.povistkaCtrl);
            this.consumablesGroupBox.Controls.Add(this.povistkaLbl);
            this.consumablesGroupBox.Controls.Add(this.mushroomsCtrl);
            this.consumablesGroupBox.Controls.Add(this.mushroomsLbl);
            this.consumablesGroupBox.Controls.Add(this.cockroachesLbl);
            this.consumablesGroupBox.Controls.Add(this.cockroachesCtrl);
            this.consumablesGroupBox.Controls.Add(this.pillsLbl);
            this.consumablesGroupBox.Controls.Add(this.pillsCtrl);
            this.consumablesGroupBox.Controls.Add(this.enerjekaLbl);
            this.consumablesGroupBox.Controls.Add(this.enerjekaCtrl);
            this.consumablesGroupBox.Controls.Add(this.coffeeCtrl);
            this.consumablesGroupBox.Controls.Add(this.coffeeLbl);
            this.consumablesGroupBox.Controls.Add(this.cigsCtrl);
            this.consumablesGroupBox.Controls.Add(this.cigsLbl);
            this.consumablesGroupBox.Controls.Add(this.label2);
            this.consumablesGroupBox.Controls.Add(this.catFoodCtrl);
            this.consumablesGroupBox.Controls.Add(this.bobeerCtrl);
            this.consumablesGroupBox.Controls.Add(this.catFoodLbl);
            this.consumablesGroupBox.Controls.Add(this.bobeerLbl);
            this.consumablesGroupBox.Location = new System.Drawing.Point(12, 27);
            this.consumablesGroupBox.Name = "consumablesGroupBox";
            this.consumablesGroupBox.Size = new System.Drawing.Size(332, 250);
            this.consumablesGroupBox.TabIndex = 7;
            this.consumablesGroupBox.TabStop = false;
            // 
            // photoCtrl
            // 
            this.photoCtrl.Location = new System.Drawing.Point(276, 177);
            this.photoCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.photoCtrl.Name = "photoCtrl";
            this.photoCtrl.Size = new System.Drawing.Size(50, 20);
            this.photoCtrl.TabIndex = 25;
            // 
            // photoLbl
            // 
            this.photoLbl.AutoSize = true;
            this.photoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.photoLbl.Location = new System.Drawing.Point(189, 180);
            this.photoLbl.Name = "photoLbl";
            this.photoLbl.Size = new System.Drawing.Size(42, 16);
            this.photoLbl.TabIndex = 26;
            this.photoLbl.Text = "Photo";
            // 
            // kombuchaCtrl
            // 
            this.kombuchaCtrl.Location = new System.Drawing.Point(276, 142);
            this.kombuchaCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.kombuchaCtrl.Name = "kombuchaCtrl";
            this.kombuchaCtrl.Size = new System.Drawing.Size(50, 20);
            this.kombuchaCtrl.TabIndex = 23;
            // 
            // kombuchaLbl
            // 
            this.kombuchaLbl.AutoSize = true;
            this.kombuchaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kombuchaLbl.Location = new System.Drawing.Point(189, 145);
            this.kombuchaLbl.Name = "kombuchaLbl";
            this.kombuchaLbl.Size = new System.Drawing.Size(71, 16);
            this.kombuchaLbl.TabIndex = 24;
            this.kombuchaLbl.Text = "Kombucha";
            // 
            // povistkaCtrl
            // 
            this.povistkaCtrl.Location = new System.Drawing.Point(276, 109);
            this.povistkaCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.povistkaCtrl.Name = "povistkaCtrl";
            this.povistkaCtrl.Size = new System.Drawing.Size(50, 20);
            this.povistkaCtrl.TabIndex = 21;
            // 
            // povistkaLbl
            // 
            this.povistkaLbl.AutoSize = true;
            this.povistkaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.povistkaLbl.Location = new System.Drawing.Point(189, 112);
            this.povistkaLbl.Name = "povistkaLbl";
            this.povistkaLbl.Size = new System.Drawing.Size(59, 16);
            this.povistkaLbl.TabIndex = 22;
            this.povistkaLbl.Text = "Povistka";
            // 
            // mushroomsCtrl
            // 
            this.mushroomsCtrl.Location = new System.Drawing.Point(276, 43);
            this.mushroomsCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.mushroomsCtrl.Name = "mushroomsCtrl";
            this.mushroomsCtrl.Size = new System.Drawing.Size(50, 20);
            this.mushroomsCtrl.TabIndex = 19;
            // 
            // mushroomsLbl
            // 
            this.mushroomsLbl.AutoSize = true;
            this.mushroomsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mushroomsLbl.Location = new System.Drawing.Point(189, 45);
            this.mushroomsLbl.Name = "mushroomsLbl";
            this.mushroomsLbl.Size = new System.Drawing.Size(77, 16);
            this.mushroomsLbl.TabIndex = 20;
            this.mushroomsLbl.Text = "Mushrooms";
            // 
            // cockroachesLbl
            // 
            this.cockroachesLbl.AutoSize = true;
            this.cockroachesLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cockroachesLbl.Location = new System.Drawing.Point(7, 215);
            this.cockroachesLbl.Name = "cockroachesLbl";
            this.cockroachesLbl.Size = new System.Drawing.Size(87, 16);
            this.cockroachesLbl.TabIndex = 18;
            this.cockroachesLbl.Text = "Cockroaches";
            // 
            // cockroachesCtrl
            // 
            this.cockroachesCtrl.Location = new System.Drawing.Point(102, 213);
            this.cockroachesCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cockroachesCtrl.Name = "cockroachesCtrl";
            this.cockroachesCtrl.Size = new System.Drawing.Size(50, 20);
            this.cockroachesCtrl.TabIndex = 17;
            // 
            // pillsLbl
            // 
            this.pillsLbl.AutoSize = true;
            this.pillsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pillsLbl.Location = new System.Drawing.Point(7, 181);
            this.pillsLbl.Name = "pillsLbl";
            this.pillsLbl.Size = new System.Drawing.Size(32, 16);
            this.pillsLbl.TabIndex = 16;
            this.pillsLbl.Text = "Pills";
            // 
            // pillsCtrl
            // 
            this.pillsCtrl.Location = new System.Drawing.Point(102, 177);
            this.pillsCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.pillsCtrl.Name = "pillsCtrl";
            this.pillsCtrl.Size = new System.Drawing.Size(50, 20);
            this.pillsCtrl.TabIndex = 15;
            // 
            // enerjekaLbl
            // 
            this.enerjekaLbl.AutoSize = true;
            this.enerjekaLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enerjekaLbl.Location = new System.Drawing.Point(7, 145);
            this.enerjekaLbl.Name = "enerjekaLbl";
            this.enerjekaLbl.Size = new System.Drawing.Size(61, 16);
            this.enerjekaLbl.TabIndex = 14;
            this.enerjekaLbl.Text = "Enerjeka";
            // 
            // enerjekaCtrl
            // 
            this.enerjekaCtrl.Location = new System.Drawing.Point(102, 142);
            this.enerjekaCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.enerjekaCtrl.Name = "enerjekaCtrl";
            this.enerjekaCtrl.Size = new System.Drawing.Size(50, 20);
            this.enerjekaCtrl.TabIndex = 11;
            // 
            // coffeeCtrl
            // 
            this.coffeeCtrl.Location = new System.Drawing.Point(102, 109);
            this.coffeeCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.coffeeCtrl.Name = "coffeeCtrl";
            this.coffeeCtrl.Size = new System.Drawing.Size(50, 20);
            this.coffeeCtrl.TabIndex = 10;
            // 
            // coffeeLbl
            // 
            this.coffeeLbl.AutoSize = true;
            this.coffeeLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coffeeLbl.Location = new System.Drawing.Point(7, 113);
            this.coffeeLbl.Name = "coffeeLbl";
            this.coffeeLbl.Size = new System.Drawing.Size(46, 16);
            this.coffeeLbl.TabIndex = 9;
            this.coffeeLbl.Text = "Coffee";
            // 
            // cigsCtrl
            // 
            this.cigsCtrl.Location = new System.Drawing.Point(102, 75);
            this.cigsCtrl.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.cigsCtrl.Name = "cigsCtrl";
            this.cigsCtrl.Size = new System.Drawing.Size(50, 20);
            this.cigsCtrl.TabIndex = 8;
            // 
            // cigsLbl
            // 
            this.cigsLbl.AutoSize = true;
            this.cigsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cigsLbl.Location = new System.Drawing.Point(6, 78);
            this.cigsLbl.Name = "cigsLbl";
            this.cigsLbl.Size = new System.Drawing.Size(68, 16);
            this.cigsLbl.TabIndex = 7;
            this.cigsLbl.Text = "Cigarettes";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(877, 24);
            this.menuStrip1.TabIndex = 8;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.importJSONToolStripMenuItem,
            this.exportJSONToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // importJSONToolStripMenuItem
            // 
            this.importJSONToolStripMenuItem.Name = "importJSONToolStripMenuItem";
            this.importJSONToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.importJSONToolStripMenuItem.Text = "Import JSON";
            this.importJSONToolStripMenuItem.Click += new System.EventHandler(this.ImportJSONToolStripMenuItem_Click);
            // 
            // exportJSONToolStripMenuItem
            // 
            this.exportJSONToolStripMenuItem.Name = "exportJSONToolStripMenuItem";
            this.exportJSONToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exportJSONToolStripMenuItem.Text = "Export JSON";
            this.exportJSONToolStripMenuItem.Click += new System.EventHandler(this.ExportJSONToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // Editor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(877, 333);
            this.Controls.Add(this.consumablesGroupBox);
            this.Controls.Add(this.jsonTreeView);
            this.Controls.Add(this.applyChangesBtn);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "Editor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "\'No, I\'m not a Human\' Save Editor";
            ((System.ComponentModel.ISupportInitialize)(this.catFoodCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bobeerCtrl)).EndInit();
            this.consumablesGroupBox.ResumeLayout(false);
            this.consumablesGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.photoCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.kombuchaCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.povistkaCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mushroomsCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cockroachesCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pillsCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enerjekaCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.coffeeCtrl)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cigsCtrl)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button applyChangesBtn;
        private System.Windows.Forms.NumericUpDown catFoodCtrl;
        private System.Windows.Forms.Label catFoodLbl;
        private System.Windows.Forms.TreeView jsonTreeView;
        private System.Windows.Forms.Label bobeerLbl;
        private System.Windows.Forms.NumericUpDown bobeerCtrl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox consumablesGroupBox;
        private System.Windows.Forms.NumericUpDown cigsCtrl;
        private System.Windows.Forms.Label cigsLbl;
        private System.Windows.Forms.NumericUpDown photoCtrl;
        private System.Windows.Forms.Label photoLbl;
        private System.Windows.Forms.NumericUpDown kombuchaCtrl;
        private System.Windows.Forms.Label kombuchaLbl;
        private System.Windows.Forms.NumericUpDown povistkaCtrl;
        private System.Windows.Forms.Label povistkaLbl;
        private System.Windows.Forms.NumericUpDown mushroomsCtrl;
        private System.Windows.Forms.Label mushroomsLbl;
        private System.Windows.Forms.Label cockroachesLbl;
        private System.Windows.Forms.NumericUpDown cockroachesCtrl;
        private System.Windows.Forms.Label pillsLbl;
        private System.Windows.Forms.NumericUpDown pillsCtrl;
        private System.Windows.Forms.Label enerjekaLbl;
        private System.Windows.Forms.NumericUpDown enerjekaCtrl;
        private System.Windows.Forms.NumericUpDown coffeeCtrl;
        private System.Windows.Forms.Label coffeeLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportJSONToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

