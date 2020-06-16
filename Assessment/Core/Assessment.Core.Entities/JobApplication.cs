using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Assessment.Core.Entities
{
    public class JobApplication
    {
        [Key, DatabaseGenerated(DatabaseGeneratedOption.Identity), Column(Order = 0)]
        public int Id { get; set; }

        [Column(Order = 1)]
        public Guid ReferenceId { get; set; }

        [Column(Order = 2)]
        public string JobTitle { get; set; }

        [Column(Order = 3)]
        public string CompanyInfo { get; set; }

        [Column(Order = 4)]
        public string JobDescription { get; set; }

        [Column(Order = 5)]
        public string CandidateProfile { get; set; }

        [Column(Order = 6)]
        public string ApplicationInfo { get; set; }
    }
}
