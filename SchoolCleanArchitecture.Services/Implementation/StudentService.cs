using SchoolCleanArchitecture.Domain.Enities;
using SchoolCleanArchitecture.Infrastructure.Interfaces;
using SchoolCleanArchitecture.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCleanArchitecture.Services.Implementation
{
    public class StudentService : IStudentService
{
    private readonly IUnitOfWork _unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<List<Student>> GetStudents()
        {
           //IGenericRepository<Student> studentRepository = _unitOfWork.GetRepository<Student>();
            List<Student> students = (List<Student>) await _unitOfWork.GetRepository<Student>().GetAllAsync();
            return students;
        }
        public async Task<Student> GetStudent(int id)
        {
            //IGenericRepository<Student> studentRepository = _unitOfWork.GetRepository<Student>();
            Student student =  _unitOfWork.GetRepository<Student>().GetById(id);
            return student;
        }
    }

}
