using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace University_Chooser
{
    public partial class Accomodation : Form
    {
        List<AccomodationData> accomData;
        int ukprn;
        string website;

        public Accomodation()
        {
            InitializeComponent();
        }

        private void Accomodation_Load(object sender, EventArgs e)
        {
            //Read ukprn
            StreamReader reader = new StreamReader("AccomodationSearch.txt");
            ukprn = Convert.ToInt32(reader.ReadLine());

            LoadAccomodation();
            PopulateListView();
            reader.Close();
        }
        private void btnGoWeb_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(website);
        }

        private void LoadAccomodation()
        {
            accomData = new List<AccomodationData>();
            AccomodationData newAccom = new AccomodationData();
            StreamReader reader = new StreamReader("AccomodationData.csv");
            bool foundAccom = false;
            string line; 
            string[] sections;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                sections = line.Split(',');

                if ((foundAccom == true) && (Convert.ToInt32(sections[0]) != ukprn))
                {
                    break;
                }
                else
                {
                    if (Convert.ToInt32(sections[0]) == ukprn)
                    {
                        foundAccom = true;
                        
                        if (accomData.Count == 0)
                        {
                            website = sections[1];
                        }

                        newAccom = new AccomodationData();
                        newAccom.name = sections[2];
                        newAccom.lowerCost = Convert.ToInt32(sections[3]);
                        newAccom.upperCost = Convert.ToInt32(sections[4]);

                        accomData.Add(newAccom);
                    }
                }
            }

            reader.Close();
        }
        private void PopulateListView()
        {
            ListViewItem item;

            lvAccomodation.Items.Clear();

            foreach(AccomodationData data in accomData)
            {
                item = new ListViewItem(data.name);
                item.SubItems.Add("£" + data.lowerCost.ToString("0.00"));
                item.SubItems.Add("£" + data.upperCost.ToString("0.00"));

                lvAccomodation.Items.Add(item);
            }
        }
    }
}
