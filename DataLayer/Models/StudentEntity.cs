using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class StudentEntity
    {
        public int CampusId  { get; set; }
        public int DepartmentId  { get; set; }
        public int StudentId  { get; set; }

        public String FirstName { get; set; }
        public String LastName { get; set; }
        public String Email { get; set; }
        public String Phone { get; set; }
        public String Address  { get; set; }
        public String DateOfBirth  { get; set; }
        public String Gender  { get; set; }

        public String Age  { get; set; }
         public String Religion   { get; set; }
    }

}


