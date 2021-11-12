using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    interface IIssueRepository
    {
        string Add(Issue Issue);
        List<Issue> GetAll(int ProjectID);
        bool Remove(Issue Issue);
        string Modify(Issue Issue);
        int GetTotalNumberOfIssues(int ProjectID);
        List<string> GetIssuesByMonth(int ProjectID);
        List<string> GetIssuesByDiscoverer(int ProjectID);
        Issue GetIssuesByID(int Id);
    }
}
