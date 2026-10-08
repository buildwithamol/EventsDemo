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

       public void EmployeeSeperatedEventHandler(object sender, EventArgs e)
        {
            Console.WriteLine("IT department notified of employee separation.");
        }

    }
}
