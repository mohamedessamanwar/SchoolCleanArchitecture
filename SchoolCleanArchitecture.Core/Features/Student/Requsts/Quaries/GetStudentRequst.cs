using MediatR;
using SchoolCleanArchitecture.Core.Basis;
using SchoolCleanArchitecture.Core.Dtos.StudentDtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCleanArchitecture.Core.Features.Student.Requsts.Quaries
{
    public class GetStudentRequst : IRequest<Response<ViewStudentDto>>
    {
        public int Id { get; set; }
    }
}
