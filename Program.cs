namespace EventsDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            EmployeeSeperator employeeSeperator = new EmployeeSeperator();
            Finance finance = new Finance(employeeSeperator);
            IT it = new IT(employeeSeperator);
            employeeSeperator?.SeperatorNotify();

            Console.ReadLine();
        }
    }
}
