using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> _IssuesStatuses = new List<IssueStatus>();

        public FakeIssueStatusRepository()
        {

            _IssuesStatuses.Add( new IssueStatus { Id = 1, Value ="Open"});
            _IssuesStatuses.Add(new IssueStatus { Id = 2, Value = "Assigned" });
            _IssuesStatuses.Add(new IssueStatus { Id = 3, Value = "Fixed" });
            _IssuesStatuses.Add(new IssueStatus { Id = 4, Value = "Closed - Won't fix" });
            _IssuesStatuses.Add(new IssueStatus { Id = 5, Value = "Closed - Fixed" });
            _IssuesStatuses.Add(new IssueStatus { Id = 6, Value = "Closed - by design" });



        }

        public void Add(int Id, string value)
        {
            IssueStatus issueStatus = new IssueStatus();
            issueStatus.Id = Id;
            issueStatus.Value = value;

            _IssuesStatuses.Add(issueStatus);
        }

        public List<IssueStatus> GetAll()
        {
            return _IssuesStatuses;

            //List<IssueStatus> issueStatuses = new List<IssueStatus>();

            //issueStatuses = _IssuesStatuses;
            //return issueStatuses;
     
        }

        public int GetIdByStatus(string value)
        {
            foreach(IssueStatus i in _IssuesStatuses)
            {
                if (i.Value == value)
                {
                    return i.Id;
                }
            }

            return -1;
        }

        public string GetValueById(int Id)
        {
            foreach (IssueStatus i in _IssuesStatuses)
            {
                if (i.Id == Id)
                {
                    return i.Value;
                }
            }

            return "Error";

        }
    }
}
