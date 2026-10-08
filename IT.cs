using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    public class IT
    {

        private readonly EmployeeSeperator employeeSeperator;

        public IT(EmployeeSeperator _employeeSeperator)
        {
            employeeSeperator = _employeeSeperator;
            employeeSeperator.EmployeeSeperated += EmployeeSeperatedEventHandler;

        }

       public void EmployeeSeperatedEventHandler()
        {
            Console.WriteLine("IT department notified of employee separation.");
        }

    }
}
