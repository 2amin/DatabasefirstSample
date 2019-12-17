using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.VeiwModel
{
   
   public class Northweiwmodel
    {
        #region [-Ctors-]
        public Northweiwmodel()
        {
            Ref_northwindclass = new Model.NorthwindCrud.Northwindclass();
        }
        #endregion
        Model.NorthwindCrud.Northwindclass Ref_northwindclass;
        #region [-GetRelationEmpoloyeeandcustomer(int id)-]
        public List<Model.Northwindcrud.GetEmployeeandcustomer_Result> GetRelationEmpoloyeeandcustomer(int id)
        {
            return Ref_northwindclass.GetEmployeeandcus(id);
        } 
        #endregion
    }
}
