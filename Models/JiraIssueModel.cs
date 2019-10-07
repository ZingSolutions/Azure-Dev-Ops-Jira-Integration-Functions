﻿namespace JiraDevOpsIntegrationFunctions.Models
{
    class JiraIssueModel
    {
        public JiraIssueModel() { }
        public string State { get; set; }
        public string Description { get; set; }
        public Context Context { get; set; }
        public string TargetUrl { get; set; }
    }
}
