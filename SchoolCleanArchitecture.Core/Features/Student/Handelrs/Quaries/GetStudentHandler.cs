using AutoMapper;
using MediatR;
using SchoolCleanArchitecture.Core.Basis;
using SchoolCleanArchitecture.Core.Dtos.StudentDtos;
using SchoolCleanArchitecture.Core.Features.Student.Requsts.Quaries;
using SchoolCleanArchitecture.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCleanArchitecture.Core.Features.Student.Handelrs.Quaries
{
    public class GetStudentHandler : IRequestHandler<GetStudentRequst, Response<ViewStudentDto>>
    {
        private readonly IStudentService _studentService;
        private readonly IMapper _mapper;
        public GetStudentHandler(IMapper mapper, IStudentService studentService)

        {
            _studentService = studentService;
            _mapper = mapper;
        }
        public async Task<Response<ViewStudentDto>> Handle(GetStudentRequst request, CancellationToken cancellationToken)
        {
            var  students = await _studentService.GetStudent(request.Id);
            if (students == null)
            {
                return new ResponseHandler().NotFound<ViewStudentDto>();
            }
            ViewStudentDto Dto = _mapper.Map<ViewStudentDto>(students);
            return new ResponseHandler().Success<ViewStudentDto>(Dto);
        }
    }
}
