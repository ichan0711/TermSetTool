using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Client;
using Microsoft.SharePoint.Client.Taxonomy;
using TermSetTool.Classes;
using System.Net;


namespace TermSetTool
{



    public partial class frmTermStoreSync : System.Windows.Forms.Form

    {
        public frmTermStoreSync()
        {
            InitializeComponent();
        }

        public Microsoft.SharePoint.Client.ClientContext context;
        public Microsoft.SharePoint.Client.Web web;
        public Microsoft.SharePoint.Client.Site site;

        private TreeNode ptvnode;

        MMSSyncManager _manager = new MMSSyncManager();

        private void btn_Sync_Click(object sender, EventArgs e)
        {

            SPClient clientSource = new SPClient(txtDomain.Text, txtUserID.Text, txtPassword.Text, cboEnvironment.Text);
            SPClient clientDestination = new SPClient(txtDestDomain.Text, txtDestUserID.Text, txtDestPassword.Text, cboDestEnvironment.Text);

            _manager.CopyTermSet(clientSource.context, clientDestination.context, (string)tvSource.SelectedNode.Parent.Name, (string)tvSource.SelectedNode.Name);

            Console.WriteLine("Completed");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {

            switch (cboEnvironment.Text)
            {
                case @"http://groupgovernance.cimic.com.au/ggs/governance":
                    {
                        txtDomain.Text = "CIMIC";
                        txtUserID.Text = "svc_spadminprod";
                        txtPassword.Text = "cimic@123";
                        break;
                    }

                case @"http://uat.groupgovernance.cimic.com.au/ggs/governance":
                    {
                        txtDomain.Text = "CIMIC";
                        txtUserID.Text = "svc_spadmin_uat";
                        txtPassword.Text = "cimic@123";
                        break;
                    }

                case @"http://dev.groupgovernance.cimic.com.au/ggs/governance":
                    {
                        txtDomain.Text = "CIMICDEV";
                        txtUserID.Text = "svc_spadmin_dev";
                        txtPassword.Text = "cimic@123";
                        break;
                    }
                default:
                    // You can use the default case.
                    {
                        txtDomain.Text = "";
                        txtUserID.Text = "";
                        txtPassword.Text = "";
                        break;
                    }
            }


        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cboMMSGroup_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGetMMSGroups_Click(object sender, EventArgs e)
        {

            tvSource.Nodes.Clear();

            SPClient _client = new SPClient(txtDomain.Text, txtUserID.Text, txtPassword.Text, cboEnvironment.Text);

            TermStore sourceTermStore = _manager.GetTermStoreObject(_client.context);

            // Get a list of termgroups to process, exclude site collection scoped groups and system groups
            IEnumerable<TermGroup> termGroups = _client.context.LoadQuery(sourceTermStore.Groups.Include(g => g.Name,
                                                                                                        g => g.Id,
                                                                                                        g => g.IsSiteCollectionGroup,
                                                                                                        g => g.IsSystemGroup,
                                                                                                        g => g.TermSets))
                                                                                                .Where(g => g.IsSystemGroup == false && g.IsSiteCollectionGroup == false);
            _client.context.ExecuteQuery();

            TreeNode rootnode;

            rootnode = new TreeNode(sourceTermStore.Name);
            rootnode.Name = sourceTermStore.Name;
            rootnode.Tag = sourceTermStore.Name;
            rootnode.ImageIndex = 0;
            tvSource.Nodes.Add(rootnode);

            GetTVGroupNode(termGroups, rootnode);
        }

        private void GetTVGroupNode(IEnumerable<TermGroup> termGroups, TreeNode parentnode)
        {
            foreach (TermGroup termGroup in termGroups)
            {

                TreeNode aNode;
                aNode = new TreeNode(termGroup.Name, 0, 0);
                aNode.Name = termGroup.Name;
                aNode.Tag = parentnode.Tag + ":" + termGroup.Name;
                aNode.ImageIndex = 1;
                parentnode.Nodes.Add(aNode);

                if (termGroup.TermSets.Count > 0)
                {
                    GetTVTermSetNode(termGroup, aNode);
                }
                
            }
        }

        private void GetTVTermSetNode(TermGroup termgroup, TreeNode parentnode)
        {

            foreach (TermSet termset in termgroup.TermSets)
            {
                TreeNode aNode;
                aNode = new TreeNode(termset.Name, 0, 0);
                aNode.Name = termset.Name;
                aNode.Tag = parentnode.Tag + ":" + termset.Name;
                aNode.ImageIndex = 2;
                aNode.SelectedImageIndex = 4;
                parentnode.Nodes.Add(aNode);
            }
        }

        private void cboDestEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cboDestEnvironment.Text)
            {
                case @"http://groupgovernance.cimic.com.au/ggs/governance":
                    {
                        txtDestDomain.Text = "CIMIC";
                        txtDestUserID.Text = "svc_spadminprod";
                        txtDestPassword.Text = "cimic@123";
                        break;
                    }

                case @"http://uat.groupgovernance.cimic.com.au/ggs/governance":
                    {
                        txtDestDomain.Text = "CIMIC";
                        txtDestUserID.Text = "svc_spadmin_uat";
                        txtDestPassword.Text = "cimic@123";
                        break;
                    }

                case @"http://dev.groupgovernance.cimic.com.au/ggs/governance":
                    {
                        txtDestDomain.Text = "CIMICDEV";
                        txtDestUserID.Text = "svc_spadmin_dev";
                        txtDestPassword.Text = "cimic@123";
                        break;
                    }
                default:
                    // You can use the default case.
                    {
                        txtDestDomain.Text = "";
                        txtDestUserID.Text = "";
                        txtDestPassword.Text = "";
                        break;
                    }
            }

            if (cboDestEnvironment.Text == cboEnvironment.Text)
            {
                MessageBox.Show("Source and Destination environment cannot be the same.", "Critical Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.RightAlign, true);
                cboDestEnvironment.SelectedIndex = -1;
                txtDestDomain.Text = "";
                txtDestUserID.Text = "";
                txtDestPassword.Text = "";
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            tvDestination.Nodes.Clear();

            SPClient _client = new SPClient(txtDestDomain.Text, txtDestUserID.Text, txtDestPassword.Text, cboDestEnvironment.Text);

            TermStore termstore = _manager.GetTermStoreObject(_client.context);

            // Get a list of termgroups to process, exclude site collection scoped groups and system groups
            IEnumerable<TermGroup> termGroups = _client.context.LoadQuery(termstore.Groups.Include(g => g.Name,
                                                                                                        g => g.Id,
                                                                                                        g => g.IsSiteCollectionGroup,
                                                                                                        g => g.IsSystemGroup,
                                                                                                        g => g.TermSets))
                                                                                                .Where(g => g.IsSystemGroup == false && g.IsSiteCollectionGroup == false);
            _client.context.ExecuteQuery();

            TreeNode rootnode;

            rootnode = new TreeNode(termstore.Name);
            rootnode.Tag = termstore.Name;
            rootnode.ImageIndex = 0;
            tvDestination.Nodes.Add(rootnode);

            GetTVGroupNode(termGroups, rootnode);
        }

        private void tvSource_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            if (ptvnode.Level < 2)
            { //Make sure its a TermSet and Not The Root or Term Group
                e.Cancel = true;
            }
        }

        private void tvSource_MouseDown(object sender, MouseEventArgs e)
        {
            TreeViewHitTestInfo info = tvSource.HitTest(e.X, e.Y);
            if (info.Node != null)
            {
                ptvnode = info.Node;
            }
        }

        private void tvDestination_MouseDown(object sender, MouseEventArgs e)
        {
            //TreeViewHitTestInfo info = tvDestination.HitTest(e.X, e.Y);
            //if (info.Node != null)
            //{
            //    ptvnode = info.Node;
            //}
        }

        private void tvDestination_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            //if (ptvnode.Level < 2)
            //{ //Make sure its a TermSet and Not The Root or Term Group
                e.Cancel = true;
            //}
        }

    }
}
