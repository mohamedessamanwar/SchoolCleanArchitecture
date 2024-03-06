using AutoMapper;
using SchoolCleanArchitecture.Core.Dtos.StudentDtos;
using SchoolCleanArchitecture.Domain.Enities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCleanArchitecture.Core.Mapping
{
    public class StudentMapping : Profile
    {
        public StudentMapping() {
            //CreateMap<List<Student>, List<ViewStudentDto>>();
            CreateMap<Student, ViewStudentDto>();


        }
       

    }
}
