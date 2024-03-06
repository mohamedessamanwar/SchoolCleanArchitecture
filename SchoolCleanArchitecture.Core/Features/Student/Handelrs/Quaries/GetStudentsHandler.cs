using MediatR;
using SchoolCleanArchitecture.Core.Dtos.StudentDtos;
using SchoolCleanArchitecture.Core.Features.Student.Requsts.Quaries;
using SchoolCleanArchitecture.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolCleanArchitecture.Domain.Enities;
using AutoMapper;
using SchoolCleanArchitecture.Core.Basis;
namespace SchoolCleanArchitecture.Core.Features.Student.Handelrs.Quaries
{
    public class GetStudentsHandler : IRequestHandler<GetStudentsRequst,Response<List<ViewStudentDto>>>//List<SchoolCleanArchitecture.Domain.Enities.Student>>
    {
        private readonly IStudentService _studentService ;
        private readonly IMapper _mapper;
        public GetStudentsHandler(IMapper mapper , IStudentService studentService)

        {
            _studentService = studentService;
            _mapper = mapper;
        }

        public async Task<Response<List<ViewStudentDto>>> Handle(GetStudentsRequst request, CancellationToken cancellationToken)
        {
              List<SchoolCleanArchitecture.Domain.Enities.Student>  students = await _studentService.GetStudents();
              //mapping 
              List<ViewStudentDto> Dto = _mapper.Map<List<ViewStudentDto>>(students);
               return new ResponseHandler().Success<List<ViewStudentDto>>(Dto);


        }
    }
}
