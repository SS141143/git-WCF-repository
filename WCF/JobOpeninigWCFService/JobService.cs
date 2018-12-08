using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace JobOpeninigWCFService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "JobService" in both code and config file together.
    public class JobService : IJobService
    {
        public List<Job> OpeningJobs()
        {
            JobOpenings obj = new JobOpenings();
            return obj.GetAllJobs();
        }

        public List<Job> OpeningJobsByRole(string roleName)
        {
            JobOpenings obj = new JobOpenings();
            return obj.GetAllJobs().Where(x => x.Role.Equals(roleName)).ToList(); ;
        }
    }

    public class JobOpenings
    {
        public List<Job> GetAllJobs()
        {
            List<Job> jobs = new List<Job>();
            var job1 = new Job();
            job1.JobId = 101;
            job1.Role = "Developer";
            job1.JobName = "Dot Net Developer";
            jobs.Add(job1);

            var job2 = new Job();
            job2.JobId = 102;
            job2.Role = "Developer";
            job2.JobName = "Java Developer";
            jobs.Add(job2);

            var job3 = new Job();
            job3.JobId = 103;
            job3.Role = "Designer";
            job3.JobName = "CSS/Bootstrap Designer";
            jobs.Add(job3);

            var job4 = new Job();
            job4.JobId = 104;
            job4.Role = "Developer";
            job4.JobName = "PHP Developer";
            jobs.Add(job4);

            var job5 = new Job();
            job5.JobId = 105;
            job5.Role = "Designer";
            job5.JobName = "Animation Designer";
            jobs.Add(job5);

            return jobs;
            
        }
    }
}
