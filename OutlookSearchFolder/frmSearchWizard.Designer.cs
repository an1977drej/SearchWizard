namespace OutlookSearchWizard
{
    partial class frmSearchWizard
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSearchWizard));
            this.txtBetreff = new System.Windows.Forms.TextBox();
            this.txtVon = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnLoschenBetreff = new System.Windows.Forms.Button();
            this.btnLoschenVon = new System.Windows.Forms.Button();
            this.btnLoschenText = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.txInhalt = new System.Windows.Forms.TextBox();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.lblSuche = new System.Windows.Forms.Label();
            this.txtSucheName = new System.Windows.Forms.TextBox();
            this.btnSaveSearch = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.anwendenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.umbenenenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loschenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnLoscheAn = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAn = new System.Windows.Forms.TextBox();
            this.chkbAnlagen = new System.Windows.Forms.CheckBox();
            this.btnLoschenKategorie = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.txtKategorie = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtBetreff
            // 
            this.txtBetreff.Location = new System.Drawing.Point(54, 6);
            this.txtBetreff.Margin = new System.Windows.Forms.Padding(2);
            this.txtBetreff.Name = "txtBetreff";
            this.txtBetreff.Size = new System.Drawing.Size(201, 20);
            this.txtBetreff.TabIndex = 5;
            this.txtBetreff.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBetreff_KeyDown);
            // 
            // txtVon
            // 
            this.txtVon.Location = new System.Drawing.Point(54, 74);
            this.txtVon.Margin = new System.Windows.Forms.Padding(2);
            this.txtVon.Name = "txtVon";
            this.txtVon.Size = new System.Drawing.Size(201, 20);
            this.txtVon.TabIndex = 6;
            this.txtVon.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtVon_KeyDown);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Betreff";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 76);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Von";
            // 
            // btnLoschenBetreff
            // 
            this.btnLoschenBetreff.Location = new System.Drawing.Point(258, 6);
            this.btnLoschenBetreff.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoschenBetreff.Name = "btnLoschenBetreff";
            this.btnLoschenBetreff.Size = new System.Drawing.Size(16, 18);
            this.btnLoschenBetreff.TabIndex = 9;
            this.btnLoschenBetreff.Text = "X";
            this.btnLoschenBetreff.UseVisualStyleBackColor = true;
            this.btnLoschenBetreff.Click += new System.EventHandler(this.btnLoschenBetreff_Click);
            // 
            // btnLoschenVon
            // 
            this.btnLoschenVon.Location = new System.Drawing.Point(258, 74);
            this.btnLoschenVon.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoschenVon.Name = "btnLoschenVon";
            this.btnLoschenVon.Size = new System.Drawing.Size(16, 18);
            this.btnLoschenVon.TabIndex = 10;
            this.btnLoschenVon.Text = "X";
            this.btnLoschenVon.UseVisualStyleBackColor = true;
            this.btnLoschenVon.Click += new System.EventHandler(this.btnLoschenVon_Click);
            // 
            // btnLoschenText
            // 
            this.btnLoschenText.Location = new System.Drawing.Point(258, 28);
            this.btnLoschenText.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoschenText.Name = "btnLoschenText";
            this.btnLoschenText.Size = new System.Drawing.Size(16, 18);
            this.btnLoschenText.TabIndex = 14;
            this.btnLoschenText.Text = "X";
            this.btnLoschenText.UseVisualStyleBackColor = true;
            this.btnLoschenText.Click += new System.EventHandler(this.btnLoschenText_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 31);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Inhalt";
            // 
            // txInhalt
            // 
            this.txInhalt.Location = new System.Drawing.Point(54, 28);
            this.txInhalt.Margin = new System.Windows.Forms.Padding(2);
            this.txInhalt.Name = "txInhalt";
            this.txInhalt.Size = new System.Drawing.Size(201, 20);
            this.txInhalt.TabIndex = 12;
            this.txInhalt.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtText_KeyDown);
            // 
            // treeView1
            // 
            this.treeView1.AllowDrop = true;
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.treeView1.LabelEdit = true;
            this.treeView1.Location = new System.Drawing.Point(5, 179);
            this.treeView1.Margin = new System.Windows.Forms.Padding(2);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(275, 471);
            this.treeView1.TabIndex = 15;
            this.treeView1.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.treeView1_ItemDrag);
            this.treeView1.DragDrop += new System.Windows.Forms.DragEventHandler(this.treeView1_DragDrop);
            this.treeView1.DragEnter += new System.Windows.Forms.DragEventHandler(this.treeView1_DragEnter);
            this.treeView1.MouseDown += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDown);
            // 
            // lblSuche
            // 
            this.lblSuche.AutoSize = true;
            this.lblSuche.Location = new System.Drawing.Point(4, 141);
            this.lblSuche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblSuche.Name = "lblSuche";
            this.lblSuche.Size = new System.Drawing.Size(205, 13);
            this.lblSuche.TabIndex = 16;
            this.lblSuche.Text = "Die Suche unter dem Namen abspeichern";
            // 
            // txtSucheName
            // 
            this.txtSucheName.Location = new System.Drawing.Point(5, 157);
            this.txtSucheName.Margin = new System.Windows.Forms.Padding(2);
            this.txtSucheName.Name = "txtSucheName";
            this.txtSucheName.Size = new System.Drawing.Size(248, 20);
            this.txtSucheName.TabIndex = 17;
            // 
            // btnSaveSearch
            // 
            this.btnSaveSearch.Location = new System.Drawing.Point(257, 157);
            this.btnSaveSearch.Margin = new System.Windows.Forms.Padding(2);
            this.btnSaveSearch.Name = "btnSaveSearch";
            this.btnSaveSearch.Size = new System.Drawing.Size(16, 18);
            this.btnSaveSearch.TabIndex = 18;
            this.btnSaveSearch.UseVisualStyleBackColor = true;
            this.btnSaveSearch.Click += new System.EventHandler(this.btnSaveSearch_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.anwendenToolStripMenuItem,
            this.umbenenenToolStripMenuItem,
            this.loschenToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(147, 70);
            // 
            // anwendenToolStripMenuItem
            // 
            this.anwendenToolStripMenuItem.Name = "anwendenToolStripMenuItem";
            this.anwendenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.anwendenToolStripMenuItem.Text = "Anwenden";
            this.anwendenToolStripMenuItem.Click += new System.EventHandler(this.anwendenToolStripMenuItem_Click);
            // 
            // umbenenenToolStripMenuItem
            // 
            this.umbenenenToolStripMenuItem.Name = "umbenenenToolStripMenuItem";
            this.umbenenenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.umbenenenToolStripMenuItem.Text = "Umbenennen";
            this.umbenenenToolStripMenuItem.Click += new System.EventHandler(this.umbenenenToolStripMenuItem_Click);
            // 
            // loschenToolStripMenuItem
            // 
            this.loschenToolStripMenuItem.Name = "loschenToolStripMenuItem";
            this.loschenToolStripMenuItem.Size = new System.Drawing.Size(146, 22);
            this.loschenToolStripMenuItem.Text = "Löschen";
            this.loschenToolStripMenuItem.Click += new System.EventHandler(this.loschenToolStripMenuItem_Click);
            // 
            // btnLoscheAn
            // 
            this.btnLoscheAn.Location = new System.Drawing.Point(258, 97);
            this.btnLoscheAn.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoscheAn.Name = "btnLoscheAn";
            this.btnLoscheAn.Size = new System.Drawing.Size(16, 18);
            this.btnLoscheAn.TabIndex = 21;
            this.btnLoscheAn.Text = "X";
            this.btnLoscheAn.UseVisualStyleBackColor = true;
            this.btnLoscheAn.Click += new System.EventHandler(this.btnLoscheAn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 99);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(20, 13);
            this.label4.TabIndex = 20;
            this.label4.Text = "An";
            // 
            // txtAn
            // 
            this.txtAn.Location = new System.Drawing.Point(54, 97);
            this.txtAn.Margin = new System.Windows.Forms.Padding(2);
            this.txtAn.Name = "txtAn";
            this.txtAn.Size = new System.Drawing.Size(201, 20);
            this.txtAn.TabIndex = 19;
            this.txtAn.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAn_KeyDown);
            // 
            // chkbAnlagen
            // 
            this.chkbAnlagen.AutoSize = true;
            this.chkbAnlagen.Location = new System.Drawing.Point(54, 122);
            this.chkbAnlagen.Margin = new System.Windows.Forms.Padding(2);
            this.chkbAnlagen.Name = "chkbAnlagen";
            this.chkbAnlagen.Size = new System.Drawing.Size(65, 17);
            this.chkbAnlagen.TabIndex = 23;
            this.chkbAnlagen.Text = "Anlagen";
            this.chkbAnlagen.UseVisualStyleBackColor = true;
            // 
            // btnLoschenKategorie
            // 
            this.btnLoschenKategorie.Location = new System.Drawing.Point(258, 51);
            this.btnLoschenKategorie.Margin = new System.Windows.Forms.Padding(2);
            this.btnLoschenKategorie.Name = "btnLoschenKategorie";
            this.btnLoschenKategorie.Size = new System.Drawing.Size(16, 18);
            this.btnLoschenKategorie.TabIndex = 26;
            this.btnLoschenKategorie.Text = "X";
            this.btnLoschenKategorie.UseVisualStyleBackColor = true;
            this.btnLoschenKategorie.Click += new System.EventHandler(this.btnLoschenKategorie_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 54);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 25;
            this.label5.Text = "Kateg.";
            // 
            // txtKategorie
            // 
            this.txtKategorie.Location = new System.Drawing.Point(54, 51);
            this.txtKategorie.Margin = new System.Windows.Forms.Padding(2);
            this.txtKategorie.Name = "txtKategorie";
            this.txtKategorie.Size = new System.Drawing.Size(201, 20);
            this.txtKategorie.TabIndex = 24;
            this.txtKategorie.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtKategorie_KeyDown);
            // 
            // frmSearchWizard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 661);
            this.Controls.Add(this.btnLoschenKategorie);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtKategorie);
            this.Controls.Add(this.chkbAnlagen);
            this.Controls.Add(this.btnLoscheAn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAn);
            this.Controls.Add(this.btnSaveSearch);
            this.Controls.Add(this.txtSucheName);
            this.Controls.Add(this.lblSuche);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.btnLoschenText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txInhalt);
            this.Controls.Add(this.btnLoschenVon);
            this.Controls.Add(this.btnLoschenBetreff);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtVon);
            this.Controls.Add(this.txtBetreff);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(300, 1000);
            this.MinimumSize = new System.Drawing.Size(300, 600);
            this.Name = "frmSearchWizard";
            this.Text = "Search Wizard ®AB";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmSearchWizard_FormClosing);
            this.Load += new System.EventHandler(this.frmSearchWizard_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBetreff;
        private System.Windows.Forms.TextBox txtVon;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnLoschenBetreff;
        private System.Windows.Forms.Button btnLoschenVon;
        private System.Windows.Forms.Button btnLoschenText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txInhalt;
        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Label lblSuche;
        private System.Windows.Forms.TextBox txtSucheName;
        private System.Windows.Forms.Button btnSaveSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem loschenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem anwendenToolStripMenuItem;
        private System.Windows.Forms.Button btnLoscheAn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAn;
        private System.Windows.Forms.CheckBox chkbAnlagen;
        private System.Windows.Forms.Button btnLoschenKategorie;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtKategorie;
        private System.Windows.Forms.ToolStripMenuItem umbenenenToolStripMenuItem;
    }
}

