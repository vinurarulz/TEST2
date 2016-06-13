using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAO
{
    public class EmployeeData
    {
        public bool SaveEmployee(string fname, string lname, string tel)
        {
            bool result = false;
            try
            {
                using (var db = new Database1Entities())
                {
                    var employee = new Employee() { FNAME = fname, LNAME = lname, TEL = tel };
                    db.Employees.Add(employee);
                    db.SaveChanges();
                    result = true;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return result;
        }
    }
}
