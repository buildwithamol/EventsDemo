using System;
using System.Collections.Generic;
using System.Text;

namespace EventsDemo
{
    public class EmployeeSeperator
    {
        public delegate void EmployeeSeperatedEventHandler(); //Delegate to define the signature of the event handler method
        public event EmployeeSeperatedEventHandler? EmployeeSeperated; //Event to notify subscribers when an employee is separated


        /// <summary>
        /// This method is called to notify the employee separator to other departments
        /// or systems that an employee has been separated from the organization.
        /// </summary>
        public void SeperatorNotify()
        {
            EmployeeSeperated?.Invoke(); //Publish Event to all subscribers

        }
    }
}
