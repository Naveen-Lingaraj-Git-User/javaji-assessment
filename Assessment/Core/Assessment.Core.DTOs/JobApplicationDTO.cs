using Assessment.Core.Entities;
using AutoMapper;
using System;

namespace Assessment.Core.DTOs
{
    [AutoMap(typeof(JobApplication), ReverseMap = true)]
    public class JobApplicationDTO
    {
        public int Id { get; set; }
        public Guid ReferenceId { get; set; }
        public string JobTitle { get; set; }
        public string CompanyInfo { get; set; }
        public string JobDescription { get; set; }
        public string CandidateProfile { get; set; }
        public string ApplicationInfo { get; set; }
    }
}
