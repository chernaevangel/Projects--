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
    public class DepartmentManager : IManager
    {
        public DepartmentDatabaseLoad DepartmentDatabaseManager { get; private set; }
        public List<Department> Departments { get; private set; }
        public DepartmentManager()
        {
            DepartmentDatabaseManager = new DepartmentDatabaseLoad();
            LoadDataFromDatabase();
        }
        private void LoadDataFromDatabase()
        {
            Departments = new List<Department>();
            foreach (Department department in (List<Department>)DepartmentDatabaseManager.ReadAll())
            {
                Departments.Add(department);
            }
        }
        public void Add(object obj)
        {
            try
            {
                DepartmentDatabaseManager.Insert(obj);
                LoadDataFromDatabase();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public Object GetAllObjects()
        {
            return Departments;
        }
        public Department GetDepartment(string department)
        {
            foreach (Department d in Departments)
            {
                if (d.Name == department)
                { return d; }
            }
            return null;
        }
        public void RemoveDepartment(Department department)
        {
            DepartmentDatabaseManager.Delete(department.ManagerId);
            this.Departments.Remove(department);
        }
        public void AddDepartment(string departmentName, int managerId)
        {
            Department newDepartment = new Department(departmentName, managerId);
            Departments.Add(newDepartment);
            DepartmentDatabaseManager.Insert(newDepartment);
        }
    }
}
