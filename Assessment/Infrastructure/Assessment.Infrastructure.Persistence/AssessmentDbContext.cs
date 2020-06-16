using Assessment.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

namespace Assessment.Infrastructure.Persistence
{
    public class AssessmentDbContext : DbContext
    {
        public AssessmentDbContext(DbContextOptions<AssessmentDbContext> options)
        :base(options)
        {
        }
        public DbSet<JobApplication> JobApplications { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<JobApplication>().HasData(new JobApplication 
            { 
                Id = 1,
                ReferenceId = Guid.NewGuid(),
                JobTitle = "Tech Lead",
                CompanyInfo = "Hexaware Technologies",
                JobDescription = "Full stack developer skilled at end-end software development and technical leadership.",
                CandidateProfile = "Full stack developer skilled at end-end software development and technical leadership. Experienced in developing enterprise applications.",
                ApplicationInfo = "First level submission"
            });
        }
    }
}
