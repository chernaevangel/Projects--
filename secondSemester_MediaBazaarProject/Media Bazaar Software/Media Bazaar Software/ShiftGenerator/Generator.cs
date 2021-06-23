using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Media_Bazaar_Software.Classes;

namespace Media_Bazaar_Software.ShiftGenerator
{
    public class Generator
    {
        private Shop Shop;
        public List<string> Days { get; private set; }
        public string Department { get; private set; }
        public int NumOfPeople { get; private set; }
        public string EmployeeType { get; private set; }
        public List<Shift> Shifts { get; private set; }
        public List<Preference> Preferences { get; private set; }

        public Generator(Shop shop, string[] days, int numOfPeople, string department, string employeeType)
        {
            Shop = shop;
            Days = days.ToList();
            NumOfPeople = numOfPeople;
            Department = department;
            EmployeeType = employeeType;
            Shifts = new List<Shift>();
            Preferences = new List<Preference>();
            GenerateShifts();
        }


        private void GenerateShifts()
        {
            Shop.sm.DeleteShifts();
            List<Employee> employees = new List<Employee>();
            Preferences.AddRange(Shop.pm.GetAllPreferences(Department));
            foreach (string day in Days)
            {
                GetEmployees(employees);
                int numA, numB, numC = numA = numB = numC = NumOfPeople;
                List<int> timeSlotInts = new List<int>() { numA, numB, numC };
                foreach (Preference preference in Preferences)
                {
                    if (preference.Day.ToString().Contains(day) && preference.Availability == "Available")
                    {
                        string[] shiftTimes = { "09:00 - 12:00", "12:00 - 15:00", "15:00 - 18:00" };
                        int index = new Random().Next(0, 2);
                        Shift shift = new Shift(day, shiftTimes[index], Shop.em.GetEmployee(preference.EmployeeId.ToString()));
                        Shifts.Add(shift);
                        Shop.sm.CreateShift(shift.Employee.Id.ToString(), shift.Day, shift.TimeSlot);
                        RemoveEmployee(preference.EmployeeId, employees);
                        timeSlotInts[index] = timeSlotInts[index] - 1;
                    }
                    if (preference.Day.ToString().Contains(day) && preference.Availability == "Unavailable")
                    {
                        RemoveEmployee(preference.EmployeeId, employees);
                    }
                }
                // Morning shifts
                for (int i = 0; i < timeSlotInts[0]; i++)
                {
                    int rnd = GetEmployeeNumber(employees);
                    Employee randomEmployee = employees[rnd];
                    Shift shift = new Shift(day, "09:00 - 12:00", randomEmployee);
                    Shifts.Add(shift);
                    Shop.sm.CreateShift(shift.Employee.Id.ToString(), shift.Day, shift.TimeSlot);
                    RemoveEmployee(randomEmployee.Id, employees);
                }
                // Afternoon Shifts
                for (int i = 0; i < timeSlotInts[1]; i++)
                {
                    int rnd = GetEmployeeNumber(employees);
                    Employee randomEmployee = employees[rnd];
                    Shift shift = new Shift(day, "12:00 - 15:00", randomEmployee);
                    Shifts.Add(shift);
                    Shop.sm.CreateShift(shift.Employee.Id.ToString(), shift.Day, shift.TimeSlot);
                    RemoveEmployee(randomEmployee.Id, employees);
                }
                // Evening Shifts
                for (int i = 0; i < timeSlotInts[2]; i++)
                {
                    int rnd = GetEmployeeNumber(employees);
                    Employee randomEmployee = employees[rnd];
                    Shift shift = new Shift(day, "15:00 - 18:00", randomEmployee);
                    Shifts.Add(shift);
                    Shop.sm.CreateShift(shift.Employee.Id.ToString(), shift.Day, shift.TimeSlot);
                    RemoveEmployee(randomEmployee.Id, employees);
                }
            }
        }
        private void GetEmployees(List<Employee> employees)
        {
            foreach (Employee employee in Shop.em.GetEmployeeDepartment(Department))
            {
                if (employee.EmployeeType == EmployeeType)
                {
                    employees.Add(employee);
                }
            }
        }
        private int GetEmployeeNumber(List<Employee> employees)
        {
            int index = 0;
            if (employees.Count == 1)
            {
                return index;
            }
            else 
            {
                Random random = new Random();
                index = random.Next(0, employees.Count - 1);
                return index;
            }
            
        }
        private void RemoveEmployee(int id, List<Employee> employees)
        {
            foreach (Employee employee in employees.ToList())
            {
                if (employee.Id == id)
                {
                    employees.Remove(employee);
                }
            }
        }
    }
}
