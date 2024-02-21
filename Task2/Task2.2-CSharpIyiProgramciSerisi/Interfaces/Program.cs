namespace Interfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////interface new'lenemez
            //CustomerManager customerManager = new CustomerManager();
            //customerManager.Add();

            //IPersonManager employeeManager = new EmployeeManager();
            //employeeManager.Add();

            ProjectManager projectManager = new ProjectManager();
            //projectManager.AddCustomer(customerManager); --> hatalı desen kodu
            projectManager.Add(new CustomerManager());
            projectManager.Add(new EmployeeManager());
            projectManager.Add(new InternManager());
        }
    }

    interface IPersonManager
    {
        //implemented operation
        void Add();
        void Update();
    }

    // inherits - class <---> implements - interface
    class CustomerManager : IPersonManager
    {
        public void Add()
        {
            //müşteri ekleme kodları
            Console.WriteLine("Müşteri eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Müşteri güncellendi");

        }
    }

    class EmployeeManager : IPersonManager
    {
        public void Add()
        {
            //personel ekleme kodları
            Console.WriteLine("Personel eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Personel güncellendi");
        }
    }

    class InternManager : IPersonManager
    {
        public void Add()
        {
            Console.WriteLine("Stajyer eklendi");
        }

        public void Update()
        {
            Console.WriteLine("Stajyer güncellendi");
        }
    }

    class ProjectManager 
    {
        public void Add(IPersonManager personManager)
        {
            personManager.Add();
        }

        /* ***hatalı desen
        public void AddCustomer(CustomerManager customerManager)
        {
            customerManager.Add();
        }

        public void AddEmployee(EmployeeManager employeeManager)
        {
            employeeManager.Add();
        }
        */
    }
}
