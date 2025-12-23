namespace Q2.OOP
{
    public class ParentClass
    {
        public double BasicSalary;
        public double TravelAllowence;

        public ParentClass(double basicSalary, double travelAllowence)
        {
            BasicSalary = basicSalary;
            TravelAllowence = travelAllowence;
        }

        public double PrintInfo()
        {
            return BasicSalary + TravelAllowence;
        }
    }
    public class ChildClass : ParentClass
    {
        public double HouseRent;

        
        public ChildClass(double basicSalary, double travelAllowence,double HouseRent) : base(basicSalary, travelAllowence)
        {
            this.HouseRent = HouseRent;
        }

        public void printInfo()
        {
            double total = BasicSalary + TravelAllowence;
            if (total < 20000)
            {
                HouseRent= total * 0.2;
            }
            else if (total >= 2000 && total < 50000)
            {
                HouseRent= BasicSalary * 0.2;
            }
            else if(total>=50000)
            {
                HouseRent=((0.52* BasicSalary)/(0.03*TravelAllowence));
                 
            }

            Console.WriteLine("house rent ="+HouseRent);
        }
    }

    public class Program
    {
        public static void Main(string[] args)
        {
            ChildClass child = new ChildClass(30000, 5000, 0);
            child.printInfo();
            ParentClass parent = new ParentClass(30000, 5000);
            Console.WriteLine("Total Salary = " + parent.PrintInfo());

        }
    }

}
