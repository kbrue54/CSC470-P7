using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    class FakeRequirementRepository : IRequirementRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_STATEMENT_ERROR = "Statements must be unique";
        public const string EMPTY_STATEMENT_ERROR = "Statement must have a value";
        public const string REQUIREMENT_NOT_FOUND_ERROR = "Requirement does not exist";
        public const string MISSING_FEATUREID_ERROR = "Must select a feature for this requirement";
        public const string MISSING_PROJECTID_ERROR = "Must select a project for this requirement";

        private static List<Requirement> _requirements = new List<Requirement>();

        public FakeRequirementRepository()
        {
            if(_requirements.Count() == 0)
            {
                _requirements.Add(new Requirement
                {
                    Id = 0,
                    ProjectId =1,
                    FeatureId =0,
                    Statement = "Test statement"
                }) ;
            }
        }

        public string Add(Requirement requirement)
        {
            foreach(Requirement r in _requirements)
            {
                if(r.Statement == requirement.Statement)
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }
            }

            if (requirement.Statement == "")
            {
                return EMPTY_STATEMENT_ERROR;
            }

            if(requirement.FeatureId < 0)
            {
                return MISSING_FEATUREID_ERROR;
            }

            if(requirement.ProjectId < 0)
            {
                return MISSING_PROJECTID_ERROR;
            }

            _requirements.Add(requirement);
            return NO_ERROR;
        }

        public List<Requirement> GetAll(int ProjectId)
        {
            List<Requirement> requirements = new List<Requirement>();

            foreach(Requirement r in _requirements)
            {
                if(r.ProjectId == ProjectId)
                {
                    requirements.Add(r);
                }
            }

            return requirements;
        }

        public string Remove(Requirement requirement)
        {
            int index = 0;
            foreach(Requirement r in _requirements)
            {
                if(r.Id == requirement.Id)
                {
                    _requirements.RemoveAt(index);
                    return NO_ERROR;
                }
                index++;
            }

            return REQUIREMENT_NOT_FOUND_ERROR;

        }

        public string Modify(Requirement requirement)
        {
            foreach (Requirement r in _requirements)
            {
                if (r.Statement == requirement.Statement)
                {
                    return DUPLICATE_STATEMENT_ERROR;
                }
            }

            if (requirement.Statement == "")
            {
                return EMPTY_STATEMENT_ERROR;
            }


            int index = 0;
            foreach(Requirement r in _requirements)
            {
                if(r.Id == requirement.Id)
                {
                    _requirements[index] = requirement;
                    return NO_ERROR;
                }
                index++;
            }

            return REQUIREMENT_NOT_FOUND_ERROR;
        }

        public Requirement GetRequirementById(int requirementId)
        {
            foreach(Requirement r in _requirements)
            {
                if(r.Id == requirementId)
                {
                    return r;
                }
            }

            return new Requirement();
        }

        public int CountByFeatureId(int featureId)
        {
            int total = 0;

            foreach(Requirement r in _requirements)
            {
                if(r.FeatureId == featureId)
                {
                    total++;
                }
            }

            return total;
        }

        public void RemoveByFeatureId(int featureID)
        {
            int index = 0;
            foreach(Requirement r in _requirements.ToList())
            {
                if(r.FeatureId == featureID)
                {
                    _requirements.RemoveAt(index);
                }
                index++;
            }
        }

        public List<Requirement> getAllTestFunc()
        {
            return _requirements;
        }
    }
}
