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

        MMSSyncManager _manager = new MMSSyncManager();

        private void btn_Sync_Click(object sender, EventArgs e)
        {

            SPClient clientSource = new SPClient(txtDomain.Text, txtUserID.Text, txtPassword.Text, cboEnvironment.Text);

            //client.RetreveTermSet();

            SPClient clientDestination = new SPClient(txtDestDomain.Text, txtDestUserID.Text, txtDestPassword.Text, cboDestEnvironment.Text);
            _manager.CopyTermGroup(clientSource.context, clientDestination.context, cboDestMMSTermSet.Text);

            Console.WriteLine("Completed");
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cboEnvironment_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPClient _client = new SPClient(txtDomain.Text, txtUserID.Text, txtPassword.Text, cboEnvironment.Text);

            TermStore sourceTermStore = _manager.GetTermStoreObject(_client.context);

            // Get a list of termgroups to process, exclude site collection scoped groups and system groups
            IEnumerable<TermGroup> termGroups = _client.context.LoadQuery(sourceTermStore.Groups.Include(g => g.Name,
                                                                                                       g => g.Id,
                                                                                                       g => g.IsSiteCollectionGroup,
                                                                                                       g => g.IsSystemGroup))
                                                                                              .Where(g => g.IsSystemGroup == false && g.IsSiteCollectionGroup == false);
            _client.context.ExecuteQuery();

            cboMMSGroup.Items.Clear();
            cboMMSTermSet.Items.Clear();

            foreach (TermGroup termGroup in termGroups)
            {
                cboMMSGroup.Items.Add(termGroup.Name);
            }

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void cboMMSGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            SPClient _client = new SPClient(txtDomain.Text, txtUserID.Text, txtPassword.Text, cboEnvironment.Text);

            TermStore sourceTermStore = _manager.GetTermStoreObject(_client.context);
            TermGroup sourceTermGroup = _manager.GetTermGroup(_client.context, sourceTermStore, cboDestMMSGroup.Text);




            // Get a list of termgroups to process, exclude site collection scoped groups and system groups
            IEnumerable<TermSet> termSets = _client.context.LoadQuery(sourceTermStore.GetTermSetsByName.Include(g => g.Name,
                                                                                                       g => g.Id));



                                                                                              .Where(g => g.IsSystemGroup == false && g.IsSiteCollectionGroup == false);
            _client.context.ExecuteQuery();


            _client.context.Load(sourceTermGroup, group => group.Name,
                                          group => group.Id,
                                          group => group.Description,
                                          group => group.TermSets.Include(
                                                   termSet => termSet.Name,
                                                   termSet => termSet.Id));

            _client.context.ExecuteQuery();

            cboMMSTermSet.Items.Clear();

            foreach (TermGroup termGroup in sourceTermGroup)
            {
                cboMMSGroup.Items.Add(termGroup.Name);
            }




        }



    }
}
