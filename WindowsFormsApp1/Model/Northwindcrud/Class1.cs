using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1.Model.NorthwindCrud
{
   public class Northwindclass
    {
        public List<Model.Northwindcrud.GetEmployeeandcustomer_Result> GetEmployeeandcus(int id)
        {
            
            using (var context = new Northwindcrud.NORTHWNDEntities1())
            {
                

                try 
                {

                   
                   
                   return context.GetEmployeeandcustomer(id).ToList();
                    
                    
                }
                catch (Exception ex)
                {

                    throw;
                }
                finally
                {
                    if (context != null)
                    {
                        context.Dispose();
                    }

                }

            }
            
           
        }

    }
}
       
