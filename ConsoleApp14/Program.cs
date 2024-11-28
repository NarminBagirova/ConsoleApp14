namespace ConsoleApp14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////implicit conversion
            //byte a = 250;
            //int b = a;

            ////explicit conversion
            //int c = 260;
            //byte d = (byte)c;

            //Animal animalShark = new BabyShark();
            //Animal animalParrot = new Parrot();

            //Animal[] animals = { animalShark, animalParrot };

            //foreach(var animal in animals)
            //{
            //    if(animal is BabyShark)
            //    {
            //        BabyShark babyshark = (BabyShark)animal;
            //        babyshark.Sing();
            //    }else if(animal is Parrot)
            //    {
            //        Parrot parrot = animal as Parrot;
            //        parrot.Speak();
            //    }
            //}

            Worker workerBackend1 = new Worker()
            {
                Fullname= "Eli Hesenov",
                Salary=3000,
                Position= Position.Backend,
            };

            Worker workerBackend2 = new Worker()
            {
                Fullname = "Narmin Bagirova",
                Salary = 5000,
                Position = Position.Backend,

            };

            Worker workerFrontend = new Worker()
            {
                Fullname = "Atabey Abbasov",
                Salary = 7000,
                Position = Position.Frontend,

            };

            Company company= new Company();

            company.AddWorker(workerBackend1);
            company.AddWorker(workerBackend2);
            company.AddWorker(workerFrontend);

            foreach(var worker in company.FilteredWorkersByPosition("backend"))
            {

                Console.WriteLine(worker.);
            }


        }
    }
}