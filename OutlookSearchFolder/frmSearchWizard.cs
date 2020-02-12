using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;


namespace OutlookSearchWizard
{
    public partial class frmSearchWizard : Form
    {
        Microsoft.Office.Interop.Outlook.Application oApp;
        string filter = "";

        #region frm SearchWizard Events
        public frmSearchWizard()
        {
            InitializeComponent();
            oApp = OutlookObj.GetApplicationObject();
            GetCategories();
            btnSaveSearch.Text = "\u2714";
        }
        private void frmSearchWizard_Load(object sender, EventArgs e)
        {
            try
            {
                Settings Stngs = XMLSerializer.DeSerializeObject<Settings>("Settings.xml");
                this.Height = Stngs.Heigh;
                this.Width = Stngs.Width;
                this.Location = new Point(Stngs.LocationX, Stngs.LocationY);
                TreeViewSerializer saveTreeView = new TreeViewSerializer();
                saveTreeView.DeserializeTreeView(treeView1, "Suchordner.xml");
            }
            catch (System.Exception)
            {
                //
            }
        }
        private void frmSearchWizard_FormClosing(object sender, FormClosingEventArgs e)
        {
            Settings Stngs = new Settings();
            Stngs.Heigh = this.Height;
            Stngs.Width = this.Width;
            Stngs.LocationX = this.Location.X;
            Stngs.LocationY = this.Location.Y;
            XMLSerializer.SerializeObject<Settings>(Stngs, "Settings.xml");
            TreeViewSerializer saveTreeView = new TreeViewSerializer();
            saveTreeView.SerializeTreeView(treeView1, "Suchordner.xml");
        }
        #endregion

        #region Get Categories
        private void GetCategories()
        {
            foreach (Microsoft.Office.Interop.Outlook.Category c in oApp.Session.Categories)
            {
                
            }
        }

        
        #endregion

        #region Suchen
        
        private void OutlookSearch()
        {
            filter = "";
            if (txtBetreff.Text != "")
            {
                filter += "thema:(" + txtBetreff.Text + ")";
            }
            if (txtVon.Text != "")
            {
                filter += "von:(" + txtVon.Text + ")";
            }
            if (txInhalt.Text != "")
            {
                filter += "inhalt:(" + txInhalt.Text + ")";
            }
            if (txtAn.Text != "")
            {
                filter += "an:(" + txtAn.Text + ")";
            }
            if (txtKategorie.Text != "")
            {
                filter += "kategorie:(" + txtKategorie.Text + ")";
            }
            if (chkbAnlagen.Checked == true)
            {
                filter += "hatanlagen:ja";
            }

            if (filter != "")
            {
                oApp.ActiveExplorer().Search(filter, Microsoft.Office.Interop.Outlook.OlSearchScope.olSearchScopeAllFolders);
            }
        }
        
        #endregion

        #region  btn Loschen
        private void btnLoschenBetreff_Click(object sender, EventArgs e)
        {
            txtBetreff.Text = "";
        }
        private void btnLoschenVon_Click(object sender, EventArgs e)
        {
            txtVon.Text = "";
        }
        private void btnLoschenText_Click(object sender, EventArgs e)
        {
            txInhalt.Text = "";
        }
        private void btnLoscheAn_Click(object sender, EventArgs e)
        {
            txtAn.Text = "";
        }
        private void btnLoschenKategorie_Click(object sender, EventArgs e)
        {
            txtKategorie.Text = "";
        }

        #endregion

        #region Enter Events
        private void txtBetreff_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OutlookSearch();
            }
        }
        private void txtVon_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OutlookSearch();
            }
        }
        private void txtText_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OutlookSearch();
            }
        }
        private void txtAn_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OutlookSearch();
            }
        }
        private void txtKategorie_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                OutlookSearch();
            }
        }
        #endregion

        #region GetColour
        private Color GetItemColor(string index)

        {
            switch (index)
            {
                case "olCategoryColorNone":
                    return Color.Empty;

                case "olCategoryColorRed":
                    return Color.FromArgb(231, 161, 162);

                case "olCategoryColorOrange":
                    return Color.FromArgb(249, 186, 137);

                case "olCategoryColorPeach":
                    return Color.FromArgb(247, 221, 143);

                case "olCategoryColorYellow":
                    return Color.FromArgb(252, 250, 144);

                case "olCategoryColorGreen":
                    return Color.FromArgb(120, 209, 104);

                case "olCategoryColorTeal":
                    return Color.FromArgb(159, 220, 201);

                case "olCategoryColorOlive":
                    return Color.FromArgb(198, 210, 176);

                case "olCategoryColorBlue":
                    return Color.FromArgb(157, 183, 232);

                case "olCategoryColorPurple":
                    return Color.FromArgb(181, 161, 226);

                case "olCategoryColorMaroon":
                    return Color.FromArgb(218, 174, 194);

                case "olCategoryColorSteel":
                    return Color.FromArgb(218, 217, 220);

                case "olCategoryColorDarkSteel":
                    return Color.FromArgb(107, 121, 148);

                case "olCategoryColorGray":
                    return Color.FromArgb(191, 191, 191);

                case "olCategoryColorDarkGray":
                    return Color.FromArgb(111, 111, 111);

                case "olCategoryColorBlack":
                    return Color.FromArgb(79, 79, 79);

                case "olCategoryColorDarkRed":
                    return Color.FromArgb(193, 26, 37);

                case "olCategoryColorDarkOrange":
                    return Color.FromArgb(226, 98, 13);

                case "olCategoryColorDarkPeach":
                    return Color.FromArgb(199, 153, 48);

                case "olCategoryColorDarkYellow":
                    return Color.FromArgb(185, 179, 0);

                case "olCategoryColorDarkGreen":
                    return Color.FromArgb(54, 143, 43);

                case "olCategoryColorDarkTeal":
                    return Color.FromArgb(50, 155, 122);

                case "olCategoryColorDarkOlive":
                    return Color.FromArgb(119, 139, 69);

                case "olCategoryColorDarkBlue":
                    return Color.FromArgb(40, 88, 165);

                case "olCategoryColorDarkPurple":
                    return Color.FromArgb(92, 63, 163);

                case "olCategoryColorDarkMaroon":
                    return Color.FromArgb(147, 68, 107);

            }
            return Color.Empty;

        }




        #endregion

        private void btnSaveSearch_Click(object sender, EventArgs e)
        {
            //OutlookSearch();
            if (!(txtSucheName.Text == ""))
            {
                SearchTag sTag = new SearchTag(
                    txtSucheName.Text,
                    txtBetreff.Text,
                    txInhalt.Text,
                    txtKategorie.Text,
                    txtVon.Text,
                    txtAn.Text,
                    chkbAnlagen.Checked
                    );
                TreeNode newNode = new TreeNode(txtSucheName.Text);
                newNode.Tag = sTag.SearchString;
                TreeNode tn = treeView1.SelectedNode;

                if (tn == null)
                {
                    treeView1.Nodes.Add(newNode);
                }
                else
                {
                    TreeNode trN = treeView1.SelectedNode.Nodes.Add(txtSucheName.Text);
                    trN.Tag = sTag.SearchString;
                    trN.TreeView.SelectedNode = trN;
                    treeView1.SelectedNode = null;
                }
                txtSucheName.Text = ""; 
            }
        }

        private void treeView1_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                TreeView treeView = sender as TreeView;
                if (treeView != null)
                {
                    treeView.SelectedNode = null;
                    treeView.Focus();
                } 
            }

            if (e.Button == MouseButtons.Right)
            {
                if (treeView1.SelectedNode != null)
                {
                    contextMenuStrip1.Show(Cursor.Position);
                }
            }
        }

        #region ToolSripMenu
        private void loschenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                treeView1.Nodes.Remove(treeView1.SelectedNode);
            }
        }
        private void anwendenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode != null)
            {
                string searchString = (string)treeView1.SelectedNode.Tag;
                MessageBox.Show(searchString);
                MessageBox.Show(searchString.Split(';').Length.ToString());
                SearchTag sTag = new SearchTag(searchString);
                MessageBox.Show(sTag.Name);
                txtSucheName.Text = sTag.Name;
                txtBetreff.Text = sTag.Betreff;
                txInhalt.Text = sTag.Inhalt;
                txtKategorie.Text = sTag.Kategorie;
                txtVon.Text = sTag.Von;
                txtAn.Text = sTag.An;
                chkbAnlagen.Checked = sTag.Anhang;

                //if (filter != "")
                //{
                //    oApp.ActiveExplorer().Search(filter, Microsoft.Office.Interop.Outlook.OlSearchScope.olSearchScopeAllFolders);
                //}
                //filter = "";
            }

        }
        private void umbenenenToolStripMenuItem_Click(object sender, EventArgs e)
        {
            treeView1.SelectedNode.BeginEdit();
        }
        #endregion


        #region Drag and Drop
        private void treeView1_ItemDrag(object sender, ItemDragEventArgs e)
        {
            DoDragDrop(e.Item, DragDropEffects.Move);
        }

        private void treeView1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void treeView1_DragDrop(object sender, DragEventArgs e)
        {
            // Retrieve the client coordinates of the drop location.
            Point targetPoint = treeView1.PointToClient(new Point(e.X, e.Y));

            // Retrieve the node at the drop location.
            TreeNode targetNode = treeView1.GetNodeAt(targetPoint);

            // Retrieve the node that was dragged.
            TreeNode draggedNode = (TreeNode)e.Data.GetData(typeof(TreeNode));

            // Sanity check
            if (draggedNode == null)
            {
                return;
            }

            // Did the user drop on a valid target node?
            if (targetNode == null)
            {
                // The user dropped the node on the treeview control instead
                // of another node so lets place the node at the bottom of the tree.
                draggedNode.Remove();
                treeView1.Nodes.Add(draggedNode);
                draggedNode.Expand();
            }
            else
            {
                TreeNode parentNode = targetNode;

                // Confirm that the node at the drop location is not 
                // the dragged node and that target node isn't null
                // (for example if you drag outside the control)
                if (!draggedNode.Equals(targetNode) && targetNode != null)
                {
                    bool canDrop = true;

                    // Crawl our way up from the node we dropped on to find out if
                    // if the target node is our parent. 
                    while (canDrop && (parentNode != null))
                    {
                        canDrop = !Object.ReferenceEquals(draggedNode, parentNode);
                        parentNode = parentNode.Parent;
                    }

                    // Is this a valid drop location?
                    if (canDrop)
                    {
                        // Yes. Move the node, expand it, and select it.
                        draggedNode.Remove();
                        targetNode.Nodes.Add(draggedNode);
                        targetNode.Expand();
                    }
                }
            }

            // Optional: Select the dropped node and navigate (however you do it)
            treeView1.SelectedNode = draggedNode;
            // NavigateToContent(draggedNode.Tag);
        }









        #endregion

        
    }
}
