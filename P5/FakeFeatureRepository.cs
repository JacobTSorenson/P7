using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class FakeFeatureRepository : IFeatureRepository
    {
        private const string NO_ERROR = "";
        private const string DUPLICATE_TITLE_ERROR = "Title must be unique.";
        private const string EMPTY_TITLE_ERROR = "Title must have a value.";
        private const string NOT_FOUND_ERROR = "Feature not found.";
        private const string INVALID_PROJECT_ID_ERROR = "Invalid Project ID for Feature.";

        private static List<Feature> features = new List<Feature>();
        private FakeRequirementRepository requirements = new FakeRequirementRepository();
        public FakeFeatureRepository()
        {
            if (features.Count == 0)
            {
                Add(new Feature {
                    Id = 1,
                    ProjectId = 1,
                    Title = "Starter Feature"
                });
            }
        }

        public string Add(Feature feature)
        {
            if (IsDuplicateTitle(feature.Title.Trim(), feature.ProjectId))
                return DUPLICATE_TITLE_ERROR;

            if (feature.Title.Trim() == "")
                return EMPTY_TITLE_ERROR;

            feature.Id = GetNextId();
            features.Add(feature);
            return NO_ERROR;
        }
        public List<Feature> GetAll(int ProjectId)
        {
            List<Feature> returnList = new List<Feature>();

            foreach (Feature f in features)
            {
                if (f.ProjectId == ProjectId)
                    returnList.Add(f);
            }

            return returnList;
        }
        public string Remove(Feature feature)
        {
            foreach (Feature f in features)
            {
                if (f.Id == feature.Id)
                {
                    features.Remove(f);
                    requirements.RemoveByFeatureId(f.Id);
                    return NO_ERROR;
                }
            }

            return NOT_FOUND_ERROR;
        }
        public string Modify(Feature feature)
        {
            if (IsDuplicateTitle(feature.Title.Trim(), feature.ProjectId))
                return DUPLICATE_TITLE_ERROR;

            if (feature.Title.Trim() == "")
                return EMPTY_TITLE_ERROR;

            foreach (Feature f in features)
            {
                if (f.Id == feature.Id)
                {
                    features.Remove(f);
                    features.Add(feature);
                    return NO_ERROR;
                }
            }

            return NOT_FOUND_ERROR;
        }
        public Feature GetFeatureById(int featureId)
        {
            foreach (Feature f in features)
            {
                if (f.Id == featureId)
                    return f;
            }

            return null;
        }
        public Feature GetFeatureByTitle(string title)
        {
            foreach (Feature f in features)
            {
                if (f.Title == title)
                    return f;
            }

            return null;
        }
        private bool IsDuplicateTitle(string featureTitle, int ProjectId)
        {
            bool isDuplicate = false;

            foreach (Feature f in features)
            {
                if (f.ProjectId == ProjectId && featureTitle == f.Title)
                    isDuplicate = true;
            }

            return isDuplicate;
        }
        private int GetNextId()
        {
            int currentMaxId = 0;

            foreach (Feature f in features)
            {
                if (currentMaxId < f.Id)
                    currentMaxId = f.Id;
            }

            return ++currentMaxId;
        }
    }
}
