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
    public partial class UniversitySearch : Form
    {
        List<University> universities;
        CourseFinder finder;

        public UniversitySearch()
        {
            InitializeComponent();
        }

        private void UniversityMain_Load(object sender, EventArgs e)
        {
            universities = LoadUniversityNSS();
            LoadCourses();
            PopulateListView();
            finder = new CourseFinder();
        }

        private void lvUniversities_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvUniversities.SelectedItems.Count > 0)
            {
                //Extract uni
                University selectedUniversity = GetUniversity(lvUniversities.SelectedItems[0].SubItems[0].Text);

                //Update extra information
                gbExtraInfo.Text = selectedUniversity.name;
                lblOverall.Text = "Overall Satisfaction: " + selectedUniversity.OverallSatisfaction + "%";
                tbFeedbackSat.Text = "Feedback Satisfaction: " + selectedUniversity.FeedbackSatisfaction + "%";
                tbManagementSat.Text = "Management Satisfaction: " + selectedUniversity.ManagementSatisfaction + "%";
                tbPersonalSat.Text = "Management Satisfaction: " + selectedUniversity.PersonalDevSatisfaction + "%";
                tbResourcesSat.Text = "Resources Satisfaction: " + selectedUniversity.ResourcesSatisfaction + "%";
                tbSupportSat.Text = "Support Satisfaction: " + selectedUniversity.SupportSatisfaction + "%";
                tbTeachingSat.Text = "Teaching Satisfaction: " + selectedUniversity.TeachingSatisfaction + "%";

                //Update course list
                PopulateCourseView(selectedUniversity);
            }
        }
        private void msiOverallSat_Click(object sender, EventArgs e)
        {
            universities = SortUniversitiesOverall(universities);
            PopulateListView();
        }
        private void msiName_Click(object sender, EventArgs e)
        {
            universities.Sort();
            PopulateListView();
        }
        private void lvCourses_DoubleClick(object sender, EventArgs e)
        {
            if (lvCourses.SelectedItems.Count > 0)
            {
                University currentUni = GetUniversity(lvUniversities.SelectedItems[0].SubItems[0].Text);
                Course currentCourse = GetCourse(lvCourses.SelectedItems[0].SubItems[0].Text,currentUni);

                System.Diagnostics.Process.Start(currentCourse.furtherInformation);
            }
        }
        private void msiCourseFinder_Click(object sender, EventArgs e)
        {
            finder.Show();
        }

        private List<University> LoadUniversityNSS()
        {
            StreamReader reader = new StreamReader("NSSInstitutions.csv");
            List<University> universities = new List<University>();
            University newUni = new University();
            string line;
            string[] sections;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                sections = line.Split('\t');

                if (sections[1].Substring(0, sections[1].Length - 1) == newUni.name)
                {
                    newUni.questionResults.Add(Convert.ToInt32(sections[3].Substring(0, sections[3].Length - 1)));
                }
                else
                {
                    if (newUni.name != null)
                    {
                        universities.Add(newUni);
                        newUni = new University();
                        newUni.ukprn = Convert.ToInt32(sections[0]);
                        newUni.name = sections[1].Substring(0, sections[1].Length - 1);
                        newUni.questionResults = new List<int>();
                        newUni.courses = new List<Course>();
                    }
                    else
                    {
                        newUni = new University();
                        newUni.name = sections[1].Substring(0, sections[1].Length - 1);
                        newUni.questionResults = new List<int>();
                        newUni.ukprn = Convert.ToInt32(sections[0]);
                        newUni.courses = new List<Course>();
                    }
                }
            }

            return universities;
        }
        private void LoadCourses()
        {
            StreamReader reader = new StreamReader("Courses.csv");
            Course newCourse;
            string line;
            string[] sections;
            bool found = false;

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                sections = line.Split(',');

                foreach (University currentUniversity in universities)
                {

                    if (Convert.ToInt32(sections[0]) == currentUniversity.ukprn)
                    {
                        //Setup course
                        newCourse = new Course();
                        newCourse.name = sections[1];
                        newCourse.furtherInformation = sections[2];
                        newCourse.ucasID = sections[3];
                        found = false;

                        foreach (Course currentCourse in currentUniversity.courses)
                        {
                            if (currentCourse.name == newCourse.name)
                            {
                                found = true;
                                break;
                            }
                        }

                        if (found == false)
                        {
                            currentUniversity.courses.Add(newCourse);
                        }
                    }
                }
            }
        }
        private List<University> SortUniversitiesOverall(List<University> unsortedUniversities)
        {
            List<University> sortedUniversities = new List<University>();
            List<University> lowerList = new List<University>();
            List<University> upperList = new List<University>();
            University pivot; //Pivot chosen as first uni

            if (unsortedUniversities.Count > 1)
            {
                pivot = unsortedUniversities[0];
                //Seperate remaining elements into lower/upper lists
                foreach (University currentUniversity in unsortedUniversities)
                {
                    //Ensure we don't 'sort' the pivot
                    if (currentUniversity != pivot)
                    {
                        if (currentUniversity.OverallSatisfaction > pivot.OverallSatisfaction)
                        {
                            upperList.Add(currentUniversity);
                        }
                        else
                        {
                            lowerList.Add(currentUniversity);
                        }
                    }
                }

                //Sort lower and upper lists
                upperList = SortUniversitiesOverall(upperList);
                lowerList = SortUniversitiesOverall(lowerList);

                //Concatenate the lists
                sortedUniversities.AddRange(upperList);
                sortedUniversities.Add(pivot);
                sortedUniversities.AddRange(lowerList);
            }
            else
            {
                sortedUniversities = unsortedUniversities;
            }

            return sortedUniversities;

        }
        private University GetUniversity(string name)
        {
            University foundUni = new University();

            foreach (University currentUni in universities)
            {
                if (currentUni.name == name)
                {
                    foundUni = currentUni;
                    break;
                }
            }

            return foundUni;
        }
        private Course GetCourse(string name, University current)
        {
            Course foundCourse = new Course();

            foreach (Course currentCourse in current.courses)
            {
                if (currentCourse.name == name)
                {
                    foundCourse = currentCourse;
                    break;
                }
            }

            return foundCourse;
        }
        private void PopulateListView()
        {
            ListViewItem newItem;

            lvUniversities.Items.Clear();

            foreach (University currentUni in universities)
            {
                newItem = new ListViewItem(currentUni.name);
                newItem.SubItems.Add(currentUni.OverallSatisfaction.ToString() + "%");

                lvUniversities.Items.Add(newItem);
            }

        }
        private void PopulateCourseView(University uni)
        {
            ListViewItem item;

            lvCourses.Items.Clear();

            foreach(Course currentCourse in uni.courses)
            {
                item = new ListViewItem(currentCourse.name);
                item.SubItems.Add(currentCourse.ucasID);

                lvCourses.Items.Add(item);
            }
        }

        private void btnAccomodationShow_Click(object sender, EventArgs e)
        {
            StreamWriter writer = new StreamWriter("AccomodationSearch.txt");
            University current = GetUniversity(gbExtraInfo.Text);

            if (current != null)
            {
                writer.Write(current.ukprn);
            }

            writer.Close();

            Accomodation accomShow = new Accomodation();
            accomShow.ShowDialog(this);
            accomShow.Dispose();
        }
    }
}
