using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WorkersModel;

namespace BL
{
    public class Logic
    {
        private readonly string path = "C:/Users/lenovo/source/repos/WorkersLab_1_2020/Workers.txt";

        List<Worker> Workers = new List<Worker>();

        public void AddWorker(string inp)
        {
            string[] info = inp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Worker w = new Worker() { Name = info[0], Position = info[1] , Age = int.Parse(info[2])};
            Workers.Add(w);
            UpdateWorkers(Workers);
            //using (StreamWriter sw = new StreamWriter(path))
            //{
                //sw.WriteLine(inp);
            //}
        }

        public List<Worker> GetWorkers()
        {
            
            using (StreamReader sr = new StreamReader(path))
            {
                string str;
                if (Workers.Count == 0)
                {
                    while ((str = sr.ReadLine()) != null)
                    {
                        String[] info = str.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                        Workers.Add(new Worker()
                        {
                            Name = info[0],
                            Position = info[1],
                            Age = int.Parse(info[2]),
                        });
                    }
                }
              return Workers;
            }
            
        }
        
        public void RemoveWorker(string inp)
        {
            string[] info = inp.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            Worker w = Workers.Find(v => v.Name == info[0]
            && v.Age == int.Parse(info[2])
            && v.Position == info[1]);
            Workers.Remove(w);
            UpdateWorkers(Workers);
        }

        public void UpdateWorkers(List<Worker> Workers)
        {
            using (StreamWriter sw = new StreamWriter(path, false))
            {
                foreach (Worker w in Workers)
                {
                    string t = $"{w.Name} {w.Position} {w.Age}";
                    sw.WriteLine(t);
                }
            }
        }
        
        public void SortByAge()
        {
            Workers = Workers.OrderBy(w => w.Age).ToList();
            UpdateWorkers(Workers);
        }
    }
}
