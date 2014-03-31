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
    public partial class CourseFinder : Form
    {
        List<University> universities;
        List<string> courseNames;
        string foundUni;

        public CourseFinder()
        {
            InitializeComponent();
        }

        private void CourseFinder_Load(object sender, EventArgs e)
        {
            LoadStuff();
        }
        private void lvCourses_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCourses.SelectedItems.Count > 0)
            {
                FindUniversity();
            }
        }
        private void btnGoUni_Click(object sender, EventArgs e)
        {
            if (foundUni != null)
            {
                System.Diagnostics.Process.Start(foundUni);
            }
        }
        private void lvAlternatives_DoubleClick(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(lvAlternatives.SelectedItems[0].SubItems[2].Text);
        }
        private void cbLimiter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadNames(cbLimiter.Text);
            courseNames.Sort();
            PopulateCourses();
        }
        private void btnAll_Click(object sender, EventArgs e)
        {
            LoadNames();
            courseNames.Sort();
            PopulateCourses();
            cbLimiter.Text = "Select a field..";
        }

        private void LoadStuff()
        {
            LoadUniversityNSS();
            LoadCourses();
        }
        private void LoadUniversityNSS()
        {
            StreamReader reader = new StreamReader("NSSInstitutions.csv");
            List<University> newUniversities = new List<University>();
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
                        newUniversities.Add(newUni);
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

            universities = newUniversities;
        }
        private void LoadCourses()
        {
            StreamReader reader = new StreamReader("Courses.csv");
            Course newCourse;
            string line;
            string[] sections;

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

                        currentUniversity.courses.Add(newCourse);
                    }
                }
            }
        }
        private void LoadNames(string limiter)
        {
            StreamReader reader = new StreamReader("Courses.csv");
            string line;
            string[] sections;
            List<string> words;
            bool found = false;
            bool wordFound = false;
            courseNames = new List<string>();

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                sections = line.Split(',');

                words = sections[1].Split(' ').ToList();

                found = false;
                wordFound = false;

                //Check that name contains limiter
                foreach(string word in words)
                {
                    if (word == limiter)
                    {
                        wordFound = true;
                        break;
                    }
                }

                if (wordFound)
                {
                    //Check for course in list
                    foreach (string name in courseNames)
                    {
                        if (name == sections[1])
                        {
                            found = true;
                            break;
                        }
                    }

                    if (!found)
                    {
                        courseNames.Add(sections[1]);
                    }
                }
            }
        }
        private void LoadNames()
        {
            StreamReader reader = new StreamReader("Courses.csv");
            string line;
            string[] sections;
            bool found = false;
            courseNames = new List<string>();

            while (!reader.EndOfStream)
            {
                line = reader.ReadLine();

                sections = line.Split(',');

                found = false;
                //Check for course in list
                foreach (string name in courseNames)
                {
                    if (name == sections[1])
                    {
                        found = true;
                        break;
                    }
                }

                if (!found)
                {
                    courseNames.Add(sections[1]);
                }
            }
        }
        private void PopulateCourses()
        {
            ListViewItem item;

            lvCourses.Items.Clear();

            foreach(string name in courseNames)
            {
                item = new ListViewItem(name);
                lvCourses.Items.Add(item);
            }
        }
        private void FindUniversity()
        {
            List<University> haveCourse = new List<University>();
            University proposedUniversity = new University();

            lvAlternatives.Items.Clear();
            
            foreach(University currentUni in universities)
            {
                //Check courses
                foreach(Course currentCourse in currentUni.courses)
                {
                    if (currentCourse.name == lvCourses.SelectedItems[0].SubItems[0].Text)
                    {
                        //Found course
                        haveCourse.Add(currentUni);

                        //Add to list view
                        ListViewItem item = new ListViewItem(currentUni.name);
                        item.SubItems.Add(currentUni.OverallSatisfaction + "%");
                        item.SubItems.Add(currentCourse.furtherInformation);

                        lvAlternatives.Items.Add(item);
                        break;
                    }
                }
            }

            //Have a list of universities who run the given course.
            //Determine 'best'
            foreach(University currentUni in haveCourse)
            {
                if (proposedUniversity.name == null)
                {
                    proposedUniversity = currentUni;
                }
                else
                {
                    //Check for better score
                    if (currentUni.OverallSatisfaction > proposedUniversity.OverallSatisfaction)
                    {
                        proposedUniversity = currentUni;
                    }
                }
            }

            //Output best
            lblUniversityName.Text = proposedUniversity.name;
            lblOverall.Text = "Overall Satisfaction: " + proposedUniversity.OverallSatisfaction + "%";
            tbFeedbackSat.Text = "Feedback Satisfaction: " + proposedUniversity.FeedbackSatisfaction + "%";
            tbManagementSat.Text = "Management Satisfaction: " + proposedUniversity.ManagementSatisfaction + "%";
            tbPersonalSat.Text = "Management Satisfaction: " + proposedUniversity.PersonalDevSatisfaction + "%";
            tbResourcesSat.Text = "Resources Satisfaction: " + proposedUniversity.ResourcesSatisfaction + "%";
            tbSupportSat.Text = "Support Satisfaction: " + proposedUniversity.SupportSatisfaction + "%";
            tbTeachingSat.Text = "Teaching Satisfaction: " + proposedUniversity.TeachingSatisfaction + "%";

            foreach (Course currentCourse in proposedUniversity.courses)
            {
                if (currentCourse.name == lvCourses.SelectedItems[0].SubItems[0].Text)
                {
                    lblUcas.Text = "UCAS Code: " + currentCourse.ucasID;
                    foundUni = currentCourse.furtherInformation;
                    break;
                }
            }
        }
    }
}
