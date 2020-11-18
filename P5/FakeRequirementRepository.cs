using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeRequirementRepository
    {
        private const string NO_ERROR = "";
        private const string DUPLICATE_STATEMENT_ERROR = "Statements must be unique.";
        private const string EMPTY_STATEMENT_ERROR = "Statement must have a value.";
        private const string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist.";
        private const string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement.";
        private const string MISSING_PROJECTID_ERROR = "Must select a project for this requirement.";

        private static List<Requirement> requirements = new List<Requirement>();

        public string Add(Requirement Requirement)
        {
            if (IsDuplicateStatement(Requirement.Statement.Trim(), Requirement.ProjectId))
                return DUPLICATE_STATEMENT_ERROR;

            if (Requirement.Statement.Trim() == "")
                return EMPTY_STATEMENT_ERROR;

            Requirement.Id = GetNextId();
            requirements.Add(Requirement);
            return NO_ERROR;
        }
        public List<Requirement> GetAll(int ProjectId)
        {
            List<Requirement> returnList = new List<Requirement>();

            foreach (Requirement r in requirements)
            {
                if (r.ProjectId == ProjectId)
                    returnList.Add(r);
            }

            return returnList;
        }
        public string Remove(Requirement Requirement)
        {
            foreach (Requirement r in requirements)
            {
                if (r.Id == Requirement.Id)
                {
                    requirements.Remove(r);
                    return NO_ERROR;
                }
            }

            return REQUIREMENT_NOT_FOUND_ERROR;
        }
        public string Modify(Requirement Requirement)
        {
            if (IsDuplicateStatement(Requirement.Statement.Trim(), Requirement.ProjectId))
                return DUPLICATE_STATEMENT_ERROR;

            if (Requirement.Statement.Trim() == "")
                return EMPTY_STATEMENT_ERROR;

            if (Requirement.FeatureId == -1)
                return MISSING_FEATUREID_ERROR;

            foreach (Requirement r in requirements)
            {
                if (r.Id == Requirement.Id)
                {
                    requirements.Remove(r);
                    requirements.Add(Requirement);
                    return NO_ERROR;
                }
            }

            return REQUIREMENT_NOT_FOUND_ERROR;
        }
        public Requirement GetRequirementById(int RequirementId)
        {
            foreach (Requirement r in requirements)
            {
                if (r.Id == RequirementId)
                    return r;
            }

            return null;
        }
        public int CountByFeatureId(int FeatureId)
        {
            int counter = 0;

            foreach (Requirement r in requirements)
            {
                if (r.FeatureId == FeatureId)
                    counter++;
            }

            return counter;
        }
        public void RemoveByFeatureId(int FeatureId)
        {
            foreach (Requirement r in requirements)
            {
                if (r.FeatureId == FeatureId)
                    requirements.Remove(r);
            }
        }
        private bool IsDuplicateStatement(string RequirementStatement, int ProjectId)
        {
            bool isDuplicate = false;

            foreach (Requirement r in requirements)
            {
                if (r.ProjectId == ProjectId && RequirementStatement == r.Statement)
                    isDuplicate = true;
            }

            return isDuplicate;
        }
        private int GetNextId()
        {
            int currentMaxId = 0;

            foreach (Requirement r in requirements)
            {
                if (currentMaxId < r.Id)
                    currentMaxId = r.Id;
            }

            return ++currentMaxId;
        }
    }
}
