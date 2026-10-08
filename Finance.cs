namespace EventsDemo
{
    public class Finance
    {
        private readonly EmployeeSeperator employeeSeperator;

        public Finance(EmployeeSeperator employeeSeperator)
        {
            this.employeeSeperator = employeeSeperator;
            employeeSeperator.EmployeeSeperated += EmployeeSeperatedEventHandler;
        }

        public void EmployeeSeperatedEventHandler()
        {
            Console.WriteLine("Finance department notified of employee separation.");
        }

    }
}
