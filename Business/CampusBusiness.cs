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
    public class CampusBusiness
    {
        public int CampusId  { get; private set; }

        public CampusBusiness ()
        {

        }
        public void SaveCampus (CampusEntity entity)
        {
            CampusDBAccess obj = new CampusDBAccess();
            obj.SaveCampus(entity);
        }

        public DataTable GetCampus ()
        {
            CampusDBAccess dal = new CampusDBAccess();

            DataTable dt = dal.GetCampus();
            return dt;
        }
        public void UpdateCampus (CampusEntity entity)
        {
            CampusDBAccess obj = new CampusDBAccess();
            obj.UpdateCampus (entity);

        }
        public void DeleteCampus (int CampusId )
        {

            CampusDBAccess dal = new CampusDBAccess();

            dal.DeleteCampus(CampusId);



        }
    }

}

