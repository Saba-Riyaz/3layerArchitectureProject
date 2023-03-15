using DataLayer;
using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business
{
    public class StudentBusiness
    {
        public int StudentId  { get; private set; }

        public StudentBusiness ()
        {

        }
        public void SaveStudent (StudentEntity entity)
        {
            StudentDBAccess obj = new StudentDBAccess();
            obj.SaveStudent (entity);
        }

        public DataTable GetStudent ()
        {
            StudentDBAccess dal = new StudentDBAccess();

            DataTable dt = dal.GetStudent();
            return dt;
        }
        public void UpdateStudent (StudentEntity entity)
        {
            StudentDBAccess obj = new StudentDBAccess();
            obj.UpdateStudent (entity);

        }
        public void DeleteEmployee(int StudentId )
        {

            StudentDBAccess dal = new StudentDBAccess();

            dal.DeleteStudent (StudentId);



        }
    }
}
