using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskManager
{
    public class Tools
    {
        static public int getId(String selected)
        {
            int id = 0;
            int zeros = 1;

            if (selected == "")
                return -1;

            for (int i = selected.Length - 1; i >= 0; i--)
            {
                if (selected[i] == '(')
                    break;

                if (selected[i] >= '0' && selected[i] <= '9')
                {
                    id = id + (selected[i] - '0') * zeros;
                    zeros *= 10;
                }

            }

            return id;
        }

        static public int getNumberOfTasks()
        {
            int counter = 0;
            Project.readProjects();
            foreach(Project project in Project.projects)
            {
                foreach(Employee employee in project.emploees)
                {
                    counter += employee.tasksOfEmp.Count;
                }
            }

            return counter;
        }

        static public Project getProject(int projectId)
        {
            foreach (Project project in Project.projects)
            {
                if (project.id == projectId)
                {
                    return project;
                }
            }

            return null; // never reached
        }

        static public List<Employee> GetEmployeesAtProject(int projectId)
        {
            return getProject(projectId).emploees;
        }

        static public Employee getEmployee(int projectId, int employeeId)
        {
            List<Employee> employees = GetEmployeesAtProject(projectId);

            foreach (Employee employee in employees)
            {
                if (employee.id == employeeId)
                    return employee;
            }

            return null; // never reached
        }

        static public EmpTask getTask(int projectId, int employeeId, int taskId)
        {
            Employee employee = getEmployee(projectId, employeeId);

            foreach (EmpTask empTask in employee.tasksOfEmp)
            {
                if (empTask.id == taskId)
                    return empTask;
            }

            return null; // never reached
        }

        static public Employee getempId(int taskid)
        {
            Project.readProjects();
            List<Project> projects = Project.projects;

            foreach(Project project in projects)
            {
                foreach (Employee employee in project.emploees)
                {
                    foreach (EmpTask empTask in employee.tasksOfEmp)
                    {
                        if (empTask.id == taskid)
                            return employee;
                    }
                }
            }
            return null;
        }

    }
}
