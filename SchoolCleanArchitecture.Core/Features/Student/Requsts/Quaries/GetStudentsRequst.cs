using MediatR;
using SchoolCleanArchitecture.Core.Basis;
using SchoolCleanArchitecture.Core.Dtos.StudentDtos;
using SchoolCleanArchitecture.Core.Features.Student.Handelrs.Quaries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCleanArchitecture.Core.Features.Student.Requsts.Quaries
{
    public class GetStudentsRequst : IRequest< Response< List<ViewStudentDto>> >   //<List<SchoolCleanArchitecture.Domain.Enities.Student>>
    {
    }
}
