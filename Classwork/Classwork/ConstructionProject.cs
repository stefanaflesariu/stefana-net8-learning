using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Classwork
{
    public class ConstructionProject
    {
        public string ProjectName { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Contractor { get; set; }
        public float Budget { get; set; }
        public List<ConstructionTask> Tasks { get; set; } = new List<ConstructionTask>();
        public ConstructionProject(string projectName, DateTime startDate, DateTime endDate, string contractor, float Budget) {
            
            this.ProjectName = projectName;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.Contractor = contractor;
            this.Budget = Budget;
        }

        public void AddTask(string taskName, int duration)
        {
            ConstructionTask task = new ConstructionTask(taskName, duration);
            Tasks.Add(task);
        }
        int duration = 0;
        public int GetProjectDuration()
        {
            
            foreach(ConstructionTask task in Tasks)
            {
                duration += task.Duration;
            }
            return duration;
        }
        public float GetTotalCost()
        {
            return duration * 400;
        }
        public List<string> GetTaskList()
        {
            List<string> list = new List<string>();
            foreach(ConstructionTask task in Tasks)
            {
                list.Add(task.Name);
            }
            return list;
        }
    }
}
