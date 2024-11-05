﻿using AutoMapper;
using SFDShop.Application.Mapping;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SFDShop.Application.ViewModel.EmployeeTask
{
    public class EmployeeTaskDetailsVm : IMapFrom<SFDShop.Domain.Models.EmployeeTask>
    {
        public int Id { get; set; }
        public string TaskName { get; set; }   
        public bool IsCompleted { get; set; }
        public DateTime TaskDate { get; set; }


        public void Mapping(Profile profile)
        {
            profile.CreateMap<SFDShop.Domain.Models.EmployeeTask, EmployeeTaskDetailsVm>()
                .ForMember(d => d.TaskName, opt => opt.MapFrom(t => t.TaskName))
                .ForMember(d => d.TaskDate, opt => opt.MapFrom(t => t.TaskDate))
                .ForMember(d => d.IsCompleted, opt => opt.MapFrom(t => t.IsCompleted));
        }
    }
}
