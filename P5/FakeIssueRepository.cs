using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Builder;

namespace P5

{
    public class FakeIssueRepository : IIssueRepository
    {
        public const string NO_ERROR = "";
        public const string MODIFIED_ISSUE_ID_ERROR = "Can not modify the issue id.";
        public const string DUPLICATE_ISSUE_TITLE_ERROR = "Issue name already exists.";
        public const string NO_ISSUE_FOUND_ERROR = "No issue found.";
        public const string EMPTY_ISSUE_TITLE_ERROR = "Issue title is empty or blank.";

        private static List<Issue> issues = new List<Issue>();

        public FakeIssueRepository()
        {
            if (issues.Count == 0)
            {
                Add(new Issue {
                    title = "First Issue",
                    discoveryDate = new DateTime(2020, 1, 25, 8, 1, 0),
                    projectId = 1,
                    discoverer = "Dave Bishop",
                    initialDescription = "The first issue event",
                    component = "FormMain",
                    status = 4
                });
                Add(new Issue {
                    title = "Minor Problem",
                    discoveryDate = new DateTime(2020, 2, 1, 10, 30, 0),
                    projectId = 1,
                    discoverer = "Dave Bishop",
                    initialDescription = "This is a minor issue",
                    component = "FormCreateProject",
                    status = 1
                });
                Add(new Issue {
                    title = "Mediocre Problem",
                    discoveryDate = new DateTime(2020, 2, 15, 9, 30, 0),
                    projectId = 1,
                    discoverer = "Dave Bishop",
                    initialDescription = "This is a mediocre issue",
                    component = "FormModifyProject",
                    status = 1
                });
                Add(new Issue {
                    title = "Show stopper issue",
                    discoveryDate = new DateTime(2020, 3, 31, 16, 30, 0),
                    projectId = 1,
                    discoverer = "Dakota Bishop",
                    initialDescription = "Huge issue",
                    component = "FakePreferenceRepository",
                    status = 3
                });
            }
        }
        public List<Issue> GetAll(int projectId)
        {
            List<Issue> returnList = new List<Issue>();

            foreach (Issue i in issues)
            {
                if (i.projectId == projectId)
                    returnList.Add(i);
            }

            return returnList;
        }
        public string Add(Issue issue)
        {
            if (IsDuplicateTitle(issue.title.Trim()))
                return DUPLICATE_ISSUE_TITLE_ERROR;

            if (issue.title.Trim() == "")
                return EMPTY_ISSUE_TITLE_ERROR;

            issue.ID = GetNextId();
            issues.Add(issue);
            return NO_ERROR;
        }
        public bool Remove(Issue issue)
        {
            foreach (Issue i in issues)
            {
                if (i.ID == issue.ID)
                {
                    issues.Remove(i);
                    return true;
                }
            }

            return false;
        }
        
        public string Modify(Issue issue)
        {
            foreach (Issue i in issues)
            {
                if (i.ID == issue.ID)
                {
                    issues.Remove(i);
                    issues.Add(issue);
                    return NO_ERROR;
                }
            }

            return NO_ISSUE_FOUND_ERROR;
        }
        public int GetTotalNumberOfIssues(int projectId)
        {
            int counter = 0;

            foreach (Issue i in issues)
            {
                if (i.projectId == projectId)
                    counter++;
            }

            return counter;
        }
        public List<string> GetIssuesByMonth(int projectId)
        {
            List<string> issuesByMonth = new List<string>();
            Dictionary<long, int> uniqueDates = new Dictionary<long, int>();
            int dateIssueCount = 0;

            foreach (Issue i in GetAll(projectId))
            {
                DateTime monthCutoff = new DateTime(i.discoveryDate.Year, i.discoveryDate.Month, 1, 1, 1, 1);

                if (!uniqueDates.TryGetValue(monthCutoff.Ticks, out dateIssueCount))
                    uniqueDates.Add(monthCutoff.Ticks, 1);

                else
                    uniqueDates[monthCutoff.Ticks]++;
            }

            foreach (KeyValuePair<long, int> pair in uniqueDates)
            {
                DateTime surrogate = new DateTime(pair.Key);
                string itemName = surrogate.Year + " - " + surrogate.Month + ": " + pair.Value;
                issuesByMonth.Add(itemName);
            }

            return issuesByMonth;
        }
        public List<string> GetIssuesByDiscoverer(int projectId)
        {
            List<string> issuesByDiscoverer = new List<string>();
            Dictionary<string, int> uniqueDiscoverers = new Dictionary<string, int>();
            int discIssueCount = 0;

            foreach (Issue i in GetAll(projectId))
            {
                if (!uniqueDiscoverers.TryGetValue(i.discoverer, out discIssueCount))
                    uniqueDiscoverers.Add(i.discoverer, 1);

                else
                    uniqueDiscoverers[i.discoverer]++;
            }

            foreach (KeyValuePair<string, int> pair in uniqueDiscoverers)
            {
                string[] nameArray = pair.Key.Split(' ');
                string itemName = nameArray[1] + ", " + nameArray[0] + " - " + pair.Value;
                issuesByDiscoverer.Add(itemName);
            }

            return issuesByDiscoverer;
        }
        public Issue GetIssueById(int id)
        {
            foreach (Issue i in issues)
            {
                if (i.ID == id)
                    return i;
            }

            return null;
        }
        
        public int GetNextId()
        {
            int currentMaxId = 0;

            foreach (Issue i in issues)
            {
                if (currentMaxId < i.ID)
                    currentMaxId = i.ID;
            }

            return ++currentMaxId;
        }
        public bool IsDuplicateTitle(string issueName)
        {
            bool isDuplicate = false;

            foreach (Issue i in issues)
            {
                if (issueName == i.title)
                    isDuplicate = true;
            }

            return isDuplicate;
        }
    }
}
