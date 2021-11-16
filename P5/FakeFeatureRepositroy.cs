﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P5
{
    public class FakeFeatureRepositroy : IFeatureRepository
    {
        public const string NO_ERROR = "";
        public const string DUPLICATE_TITLE_ERROR = "Title must be unique";
        public const string EMPTY_TITLE_ERROR = "Title must have a value";
        public const string NOT_FOUND_ERROR = "Feature Not Found";
        public const string INVALID_PROJECT_ID_ERROR = "Invalid Project Id for Feature";

        private static List<Feature> _features = new List<Feature>();


        public string Add(Feature feature) {
            _features.Add(feature);
            return NO_ERROR; 
        }


    

        public List<Feature> GetAll(int ProjectId) { 
            List<Feature> features = new List<Feature>();

            foreach (Feature feature in _features)
            {
                if(feature.ProjectId == ProjectId)
                {
                    features.Add(feature);
                }
            }


            return features;  
        
        }

        public string Remove(Feature feature) { return ""; }

        public string Modify(Feature feature) { return ""; }

        public Feature GetFeatureById(int projectID, int featureId) { Feature f = new Feature(); return f; }

        public Feature GetFeatureByTitle(int projectId, string Title) { Feature f = new Feature(); return f; }
    }
}