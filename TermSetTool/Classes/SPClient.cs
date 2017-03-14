using Microsoft.SharePoint.Client;
using Microsoft.SharePoint;
using Microsoft.SharePoint.Client.Taxonomy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CamlexNET;
using System.IO;

namespace TermSetTool.Classes
{
    class SPClient
    {
        public Web w;
        public Site s;
//        public System.Collections.Generic.List<Lookup> Lookups = new System.Collections.Generic.List<Lookup>();
        public ClientContext context;

        public SPClient(string sDomain, string sUser, string sPassword, string sSite)
        {

            context = new ClientContext(sSite);

            this.context.RequestTimeout = (int)300000;

            context.Credentials = new NetworkCredential(sUser, sPassword, sDomain);

            this.w = context.Web;
            this.s = context.Site;

            context.Load(w);
            context.Load(s);

            context.ExecuteQuery();

            // Load the Lookups List
        }

        public void RetreveTermSet()
        {

            //
            // Load up the taxonomy item names.
            //
            TaxonomySession taxonomySession = TaxonomySession.GetTaxonomySession(this.context);
            TermStore termStore = taxonomySession.GetDefaultSiteCollectionTermStore();
            this.context.Load(termStore,
                    store => store.Name,
                    store => store.Groups.Include(
                        group => group.Name,
                        group => group.TermSets.Include(
                            termSet => termSet.Name,
                            termSet => termSet.Terms.Include(
                                term => term.Name)
                        )
                    )
            );
            this.context.ExecuteQuery();

            //
            //Writes the taxonomy item names.
            //
            if (taxonomySession != null)
            {
                if (termStore != null)
                {
                    foreach (TermGroup group in termStore.Groups)
                    {
                        Console.WriteLine("Group " + group.Name);

                        foreach (TermSet termSet in group.TermSets)
                        {
                            Console.WriteLine("TermSet " + termSet.Name);

                            foreach (Term term in termSet.Terms)
                            {
                                //Writes root-level terms only.
                                Console.WriteLine("Term " + term.Name);
                            }
                        }
                    }
                }
            }
        
        }

    }

}
