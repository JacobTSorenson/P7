using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    interface IRequirementRepository
    {
        string Add(Requirement Requirement);
        List<Requirement> GetAll(int ProjectId);
        string Remove(Requirement Requirement);
        string Modify(Requirement Requirement);
        Requirement GetRequirementById(int RequirementId);
        int CountByFeatureId(int FeatureId);
        void RemoveByFeatureId(int FeatureId);
    }
}
