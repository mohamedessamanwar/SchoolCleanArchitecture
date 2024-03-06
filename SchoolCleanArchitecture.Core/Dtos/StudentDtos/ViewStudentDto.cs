using SchoolCleanArchitecture.Domain.Enities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolCleanArchitecture.Core.Dtos.StudentDtos
{
    public class ViewStudentDto
    {
        public int StudID { get; set; }

        [StringLength(200)]
        public string Name { get; set; }
        [StringLength(500)]
        public string Address { get; set; }
        [StringLength(500)]
        public string Phone { get; set; }

    }
}
