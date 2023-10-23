namespace PrimeiroProjeto
{
    internal class Employee
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public double Salary { get; private set; }

        public Employee(int id, string name, double salary)
        {
            this.Id = id;
            this.Name = name;
            this.Salary = salary;
        }

        public override string ToString()
        {
            return this.Id + ", " + this.Name + ", " + this.Salary;
        }

        public void increaseSalary(double increase)
        {
            double amountIncrease = this.Salary / increase;
            this.Salary += amountIncrease;
        }
    }
}
