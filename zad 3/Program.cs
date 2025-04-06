namespace zad_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SortedDictionary<int, string> employees = new SortedDictionary<int, string>();
            while (true)
            {
                Console.Write("Write the number of the employee (0 for end): ");
                int employeeNumber = int.Parse(Console.ReadLine());
                if (employeeNumber == 0)
                {
                    break;
                }
                Console.Write("Write the name of the employee: ");
                string employeeName = Console.ReadLine();

                employees.Add(employeeNumber, employeeName);
            }
            Console.WriteLine("List of employees:");
            foreach (var employee in employees)
            {
                Console.WriteLine($"Employee number: {employee.Key}, Employee name: {employee.Value}");
            }
        }
    }
}
