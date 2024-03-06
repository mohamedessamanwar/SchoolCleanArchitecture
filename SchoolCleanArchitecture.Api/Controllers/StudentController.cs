using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SchoolCleanArchitecture.Core.Features.Student.Requsts.Quaries;

namespace SchoolCleanArchitecture.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IMediator _mediator;

        public StudentController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<ActionResult> GetStudents()
        {
            var response = await _mediator.Send(new GetStudentsRequst()); 
            return Ok(response);

        }

        [HttpGet("{id}")]
        public async Task<ActionResult> GetStudent(int id)
        {
        //v
            var response = await _mediator.Send(new GetStudentRequst { Id=id});
            return Ok(response);

        }



    }
}
