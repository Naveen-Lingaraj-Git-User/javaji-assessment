using Assessment.Core.Abstractions;
using Assessment.Core.DTOs;
using Assessment.Core.Entities;
using Assessment.Core.Interfaces;
using Assessment.Core.ViewModels;
using Assessment.Infrastructure.Persistence;
using AutoMapper;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assessment.Core.Services
{
    public class JobApplicationService : BaseServiceProvider, IJobApplicationService
    {
        public Task<int> CreateJobApplication(JobApplicationViewModel jobApplicationViewModel)
        {
            Using<AssessmentDbContext>().JobApplications.Add(Using<IMapper>().Map<JobApplication>(jobApplicationViewModel.Result[0]));
            return Using<AssessmentDbContext>().SaveChangesAsync();
        }

        public JobApplicationViewModel ReadJobApplication(int id)
        {
            return new JobApplicationViewModel
            {
                Result = Using<IMapper>().Map<IList<JobApplicationDTO>>(Using<AssessmentDbContext>().JobApplications.Where(x => x.Id == id).ToList())
            };
        }

        public JobApplicationViewModel ReadJobApplications()
        {
            return new JobApplicationViewModel
            {
                Result = Using<IMapper>().Map<IList<JobApplicationDTO>>(Using<AssessmentDbContext>().JobApplications.ToList())
            };
        }

        public Task<int> UpdaterJobApplication(JobApplicationViewModel jobApplicationViewModel)
        {
            var jobApplication = ReadJobApplication(jobApplicationViewModel.Result[0].Id);
            jobApplication.Result = Using<IMapper>().Map<IList<JobApplicationDTO>>(jobApplicationViewModel.Result);
            Using<AssessmentDbContext>().Update(jobApplication.Result);
            return Using<AssessmentDbContext>().SaveChangesAsync();
        }

        public Task<int> DeleteJobApplication(int id)
        {
            var jobApplication = ReadJobApplication(id);
            Using<AssessmentDbContext>().Remove(jobApplication);
            return Using<AssessmentDbContext>().SaveChangesAsync();
        }
    }
}
