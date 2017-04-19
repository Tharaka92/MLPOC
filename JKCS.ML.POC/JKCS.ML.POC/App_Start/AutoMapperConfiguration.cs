using AutoMapper;
using JKCS.ML.POC.Entities;
using JKCS.ML.POC.Models;

namespace Hypercent.Intranet.Application.App_Start
{
    public class AutoMapperConfiguration
    {
        public static void RegisterBindings()
        {
            Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<User, UserModel>();
                cfg.CreateMap<UserModel, User>();

                cfg.CreateMap<Job, JobModel>();
                cfg.CreateMap<JobModel, Job>();
            });
        }
    }
}