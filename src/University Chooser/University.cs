using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace University_Chooser
{
    class University
    {
        public string name;
        public int ukprn;
        public List<int> questionResults;
        public List<Course> courses;

        public int GetRanking(bool teach, bool feedback, bool support, bool management, bool resources, bool personal)
        {
            int average = 0;
            int num = 0;

            if (teach)
            {
                average += TeachingSatisfaction;
                num++;
            }

            if (feedback)
            {
                average += FeedbackSatisfaction;
                num++;
            }

            if (support)
            {
                average += SupportSatisfaction;
                num++;
            }

            if (management)
            {
                average += ManagementSatisfaction;
                num++;
            }

            if (resources)
            {
                average += ResourcesSatisfaction;
                num++;
            }

            if (personal)
            {
                average += PersonalDevSatisfaction;
                num++;
            }

            average = average / num;

            return average;
        }

        public int OverallSatisfaction
        {
            get
            {
                return questionResults[21];
            }
        }
        public int TeachingSatisfaction
        {
            get
            {
                return ((questionResults[0] + questionResults[1] + questionResults[2] + questionResults[3]) / 4);
            }
        }
        public int FeedbackSatisfaction
        {
            get
            {
                return ((questionResults[5] + questionResults[6] + questionResults[7] + questionResults[8] + questionResults[9]) / 5);
            }
        }
        public int SupportSatisfaction
        {
            get
            {
                return ((questionResults[10] + questionResults[11] + questionResults[12]) / 3);
            }
        }
        public int ManagementSatisfaction
        {
            get
            {
                return ((questionResults[13] + questionResults[14] + questionResults[15]) / 3);
            }
        }
        public int ResourcesSatisfaction
        {
            get
            {
                return ((questionResults[16] + questionResults[17] + questionResults[18]) / 3);
            }
        }
        public int PersonalDevSatisfaction
        {
            get
            {
                return ((questionResults[19] + questionResults[20] + questionResults[21]) / 3);
            }
        }
    }
}
