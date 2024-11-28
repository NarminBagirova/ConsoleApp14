using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14
{
    public class Company
    {
        private Worker[] _workers;
        private int _idCounter = 1;
        public int Id { get;  set; }
      
        
        public Company()
        {
            Id = _idCounter++;
            _workers = Array.Empty<Worker>();
        }

        public void AddWorker(Worker worker)
        {
            Array.Resize(ref _workers, _workers.Length + 1);
            _workers[^1] = worker;
        }

        public Worker[] FilteredWorkersByPosition(string positon)
        {
            Worker[] filteredWorkers = Array.Empty<Worker>();

            foreach (var worker in _workers)
            {
                if (worker.Position.ToString().ToLower() == positon.Trim().ToLower())
                {

                    Array.Resize(ref filteredWorkers, filteredWorkers.Length + 1);
                    filteredWorkers[^1] = worker;
                }
            }
            return filteredWorkers;
        }
    }
}
