﻿using Assm1_Framework.Contexts;
using Assm1_Framework.Entities;
using Microsoft.EntityFrameworkCore;

namespace Assm1_Framework
{
    internal class Program
    {
        static void Main()
        {
          //CompanyDbContext context = new CompanyDbContext();
          //  context.Database.Migrate();


            using CompanyDbContext context = new CompanyDbContext();

            var employee = new Employee()
            {
                Name = "Ahmed mm",
                Salary = 12000,
                Address = "Cairo",
                Age = 25
            };

            //employee.Name = "Khaled";


            //Console.WriteLine(context.Entry(employee).State);


            //context.Employees.Add(employee);
            //Console.WriteLine(context.Entry(employee).State);

            //var Result = context.SaveChanges();

            //Console.WriteLine(context.Entry(employee).State);

            //employee.Name = "Omer";

            //Console.WriteLine(Result);

            //context.Employees.Add(employee);
            //context.SaveChanges();


            //Console.WriteLine(context.Entry(employee).State);
            //context.Entry(employee).State = EntityState.Added;
            //Console.WriteLine(context.Entry(employee).State);

            //context.SaveChanges();

            //var Result =  context.Employees.Where(E => E.Id == 2).FirstOrDefault();
            //var Result =  context.Employees.FirstOrDefault(E => E.Id == 2);

            //var Result = context.Employees.Select(E => E.Name);

            //foreach (var item in Result)
            //{
            //    Console.WriteLine(item);
            //}



            //    Console.WriteLine(Result?.Name);
            //Console.WriteLine(Result?.Id);

        }
    }
}
