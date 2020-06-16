using Assessment.Core.ViewModels;
using System;
using System.Threading.Tasks;

namespace Assessment.Core.Interfaces
{
    public interface IJobApplicationService
    {
        Task<int> CreateJobApplication(JobApplicationViewModel jobApplicationViewModel);
        JobApplicationViewModel ReadJobApplication(int id);
        JobApplicationViewModel ReadJobApplications();
        Task<int> UpdaterJobApplication(JobApplicationViewModel jobApplicationViewModel);
        Task<int> DeleteJobApplication(int id);
    }
}
