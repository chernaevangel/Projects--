using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Interfaces;
using Media_Bazaar_Software.Classes;
using Media_Bazaar_Software.Exceptions;
using Media_Bazaar_Software.DatabaseLoad;
using System.Windows.Forms;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Media_Bazaar_Software.ManagerClasses
{
    public class EmployeeTypeManager : IManager
    {
        private EmployeeTypeDatabaseLoad employeeTypeDatabaseManager;
        public EmployeeTypeDatabaseLoad EmployeeTypeDatabaseManager { get { return employeeTypeDatabaseManager; } set { employeeTypeDatabaseManager = value; } }
        public List<EmployeeType> employeeTypes { get; private set; }
        public EmployeeTypeManager()
        {
            EmployeeTypeDatabaseManager = new EmployeeTypeDatabaseLoad();
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            employeeTypes = new List<EmployeeType>();
            foreach (EmployeeType employeeType in (List<EmployeeType>)employeeTypeDatabaseManager.ReadAll())
            {
                employeeTypes.Add(employeeType);
            }
        }
        public void Add(object obj)
        {
            try
            {
                EmployeeTypeDatabaseManager.Insert(obj);
                LoadDataFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Object GetAllObjects()
        {
            return employeeTypes;
        }
        public EmployeeType GetEmployeeType(string type)
        {
            foreach (EmployeeType e in this.employeeTypes)
            {
                if (e.Type == type)
                { return e; }
            }
            return null;
        }
        public void RemoveEmployeeType(EmployeeType employeeType)
        {
            EmployeeTypeDatabaseManager.Delete(employeeType.Type);
            this.employeeTypes.Remove(employeeType);
        }
        public void EditEmployeeTypeWage(EmployeeType empType, decimal wagePerHour)
        {
            foreach (EmployeeType e in this.employeeTypes)
            {
                if (e == empType)
                { e.WagePerHour = wagePerHour; }
            }
            EmployeeTypeDatabaseManager.Update(empType.Type, wagePerHour);
        }
    }
}
