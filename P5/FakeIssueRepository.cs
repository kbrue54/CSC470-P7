using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string EMPTY_TITLE_ERROR = "A title is required";
        public const string EMPTY_DISCOVERY_DATETIME_ERROR = "Must select a discovery date/time.";
        public const string FUTURE_DISCOVERY_DATETIME_ERROR = "Issues can't be from the future";
        public const string EMPTY_DISCOVERER_ERROR = "A discoverer is required.";

        private static List<Issue> _Issues = new List<Issue>();

        string ValidateIssue(Issue issue) { return ""; }
        bool isDubplicate(string title) {
            bool isDuplicate = false;
            foreach (Issue i in _Issues)
            {
                if (title == i.Title)
                {
                    isDuplicate = true;
                }
            }
            return isDuplicate;
        }


        ///
        public string Add(Issue Issue) {
         
            string newIssueName = Issue.Title.Trim();
            if (isDubplicate(newIssueName))
            {
                return "Duplicate";
            }
            if (newIssueName == "")
            {
                return EMPTY_TITLE_ERROR;
            }

            _Issues.Add(Issue);
            return NO_ERROR;
        }
        public List<Issue> GetAll(int ProjectID) {
            List<Issue> Issues = new List<Issue>();
            foreach (Issue issue in _Issues)
            {
                if (issue.ProjectID == ProjectID)
                {
                    Issues.Add(issue);
                }
            }
            return Issues;
        }
        public bool Remove(Issue Issue) {
            int index = 0;
            foreach (Issue issue in _Issues)
            {
                if (issue.Id == Issue.Id)
                {
                    _Issues.RemoveAt(index);
                    return true;
                }
                index++;
            }
            return false;
        }
        public string Modify(Issue Issue) {
           
            int index = 0;
            foreach (Issue i in _Issues)
            {
                if (Issue.Id == i.Id)
                {
                    _Issues[index] = Issue;
                    return NO_ERROR;
                }
                index++;
            }
            return "Error";
        }
        public int GetTotalNumberOfIssues(int ProjectID) {
            
            int count = 0;
            foreach (Issue i in _Issues)
            {
                if (i.ProjectID == ProjectID)
                {
                   count++;
                }
              
            }
            return count;
        }
        public List<string> GetIssuesByMonth(int ProjectID) {

            int[] monthCounts = new int[12];
            int[] year = new int[12];

            List<string> issuesByMonth = new List<string>();

            foreach (Issue i in _Issues)
            {
                if (i.ProjectID == ProjectID)
                {
                    monthCounts[i.DiscoveryDate.Month]++;
                    year[i.DiscoveryDate.Month] = i.DiscoveryDate.Year;
                   
                }
            }

            foreach (int month in monthCounts)
            {
                if(month != 0)
                {
                    issuesByMonth.Add(year[month].ToString() + " - " + monthCounts[month]  );
                }

            }


            return issuesByMonth;
        }
        public List<string> GetIssuesByDiscoverer(int ProjectID) {

           Dictionary<string , int > DiscovererCounts = new Dictionary<string, int>();
           List<string>  IssuesByDiscoverer = new List<string>();

            foreach(Issue i in _Issues)
            {
                if (DiscovererCounts.ContainsKey(i.Discoverer))
                {
                    DiscovererCounts[i.Discoverer]++;

                } else
                {
                    DiscovererCounts.Add(i.Discoverer, 1);
                }

            }

            foreach (KeyValuePair<string, int> entry in DiscovererCounts)
            {
                IssuesByDiscoverer.Add(entry.Key + ": " + entry.Value);
            }

            return IssuesByDiscoverer;

        }
        public Issue GetIssuesByID(int Id) {
            Issue Issue = new Issue();
            foreach (Issue issue in _Issues)
            {
                if (issue.Id == Id)
                {
                    return issue;
                }


            }

            return Issue;
        }
    }
}
