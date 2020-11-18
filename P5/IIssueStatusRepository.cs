using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IIssueStatusRepository
    {
        void Add(int id, string value);
        List<IssueStatus> GetAll();
        int GetIdByStatus(string value);
        string GetValueById(int id);
    }
}
