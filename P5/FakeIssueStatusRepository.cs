using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    class FakeIssueStatusRepository : IIssueStatusRepository
    {
        private static List<IssueStatus> allStatus;

        public FakeIssueStatusRepository()
        {
            allStatus = new List<IssueStatus>();
            if (allStatus.Count == 0)
            {
                Add(1, "Open");
                Add(2, "Assigned");
                Add(3, "Fixed");
                Add(4, "Closed - Won't Fix");
                Add(5, "Closed - Fixed");
                Add(6, "Closed - by design");
            }
        }

        public void Add(int id, string value)
        {
            IssueStatus newStatus = new IssueStatus();
            newStatus.Id = id;
            newStatus.Value = value;
            allStatus.Add(newStatus);
        }
        public List<IssueStatus> GetAll()
        {
            List<IssueStatus> statuses = new List<IssueStatus>();
            foreach (IssueStatus status in allStatus)
            {
                statuses.Add(status);
            }
            return statuses;
        }
        public int GetIdByStatus(string value)
        {
            foreach (IssueStatus issue in allStatus)
            {
                if (issue.Value == value)
                    return issue.Id;
            }
            return -1;
        }
        public string GetValueById(int id)
        {
            foreach (IssueStatus issue in allStatus)
            {
                if (issue.Id == id)
                    return issue.Value;
            }
            return "No status with supplied ID found";
        }
    }
}
