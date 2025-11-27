using EF_2.Context;
using EF_2.Model;
using Microsoft.EntityFrameworkCore;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EF_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            using AirlineDbContext dbContext = new AirlineDbContext();
            //a.Insert a new airline named "EgyptAir" with contact person "Ahmed Ali", phone "0123456789" and “0113654789”, and address "Cairo".

            //Airline airline = new Airline()
            //{
            //    Name = "EgyptAir",
            //    ContactPerson = "Ahmed Ali",
            //    Address = "Cairo",
            //    Phones = new HashSet<Phone>()
            //    {
            //        new Phone{Number = "0123456789"},
            //        new Phone{Number = "0113654789"}
            //    }

            //};

            //dbContext.Airlines.Add(airline);
            //dbContext.SaveChanges();

            //b.Add a new aircraft with model "Model01", capacity 180, and airline = "EgyptAir".
            //Aircraft aircraft = new Aircraft()
            //{
            //    Model = "Model01",
            //    Capacity = 180,
            //    AirlineId = 18
            //};

            //dbContext.Aircrafts.Add(aircraft);
            //dbContext.SaveChanges();

            //c.Record a new transaction of amount 50000 with description "Tickets" for "EgyptAir".
            //Transaction transaction = new Transaction()
            //{
            //    Amount = 50000,
            //    Description = "Tickets",
            //    AirlineId = 18
            //};
            //dbContext.Transactions.Add(transaction);
            //dbContext.SaveChanges();

            //d.Select all employees who work in "EgyptAir"

            //var emps = dbContext.Empolyees.Where(E => E.AirlineId == 18);

            //foreach (var e in emps)
            //{
            //    Console.WriteLine(e.Name);
            //}

            //e.Show all transactions (id, description, amount) recorded by "EgyptAir".
            //var trans = dbContext.Transactions.Where(T => T.AirlineId == 18);
            //foreach (var transaction in trans) {
            //    Console.WriteLine(transaction.Id);
            //    Console.WriteLine(transaction.Description);
            //    Console.WriteLine(transaction.Amount);
            //}

            //d.Get the total number of employees working in each airline.

            //var empCounts = dbContext.Empolyees
            //    .GroupBy(a => a.AirlineId)
            //    .Select(group => new
            //    {
            //        key = group.Key,
            //        tot = group.Count()
            //    }
            //    );

            //foreach (var emp in empCounts) {
            //    Console.WriteLine(emp);
            //}

            //g.Change the capacity of the “Model01”  aircraft to 200.
            //var aircraft = dbContext.Aircrafts.Where(A => A.Model == "Model01").FirstOrDefault();

            //if (aircraft != null)
            //{

            //    Console.WriteLine(aircraft.Capacity);
            //    aircraft.Capacity = 200;
            //    dbContext.SaveChanges();
            //}


            //h.Delete all transactions older than 2020.
            //dbContext.Transactions.Where(e => e.Date.Year <= 2020).ExecuteDelete();

            //i.Insert a new route from "Cairo" to "Dubai", classification "International", distance 2400 km.

            //Route route = new Route()
            //{
            //    Origin = "Cairo",
            //    Destionation = "Dubai",
            //    Classification = "International",
            //    Distance = 2400
            //};

            //dbContext.Routes.Add(route);
            //dbContext.SaveChanges();

            //j.Assign  “Model01”  aircraft to Route From  "Cairo" to "Dubai". With duration 4 hours, price 3000 LE


            #region SectionA
            //1. Load "EgyptAir" With all its aircrafts and their routes 

            //var data = dbContext.Airlines.Include(A => A.Aircraft).ThenInclude(B => B.AircraftRoutes).ThenInclude(C => C.Route)
            //    .FirstOrDefault(D => D.Name == "EgyptAir");


            //if (data != null) {
            //    Console.WriteLine(data.Name);
            //    foreach(var i in data.Aircraft)
            //    {
            //        Console.WriteLine(i.Model);

            //        foreach (var j in i.AircraftRoutes)
            //        {
            //            Console.WriteLine(j.Route.Id);
            //        }

            //    }  
            //}

            // 2.Retrieve all airlines with their employees, and for each employee load their qualifications.
            //var data = dbContext.Airlines.Include(A => A.Empolyees).ThenInclude(B => B.Qualifications);


            //foreach (var i in data)
            //{
            //    Console.WriteLine(i.Name);

            //    foreach (var j in i.Empolyees)
            //    {
            //        Console.WriteLine(j.Name);
            //        foreach (var c in j.Qualifications)
            //        {
            //            Console.WriteLine(c.Name);
            //        }
            //    }
            //}

            //3. Load all airlines with their transactions, but only include transactions where Amount > 10000 
            //var data = dbContext.Airlines.Include(A => A.Transaction.Where(B => B.Amount > 10000));

            //foreach (var item in data)
            //{
            //    Console.WriteLine(item.Name);
            //    foreach (var item2 in item.Transaction) {
            //        Console.WriteLine(item2.Amount);
            //    }
            //}

            // 4.Select all routes along with the model of aircrafts assigned to them 

            //var data = dbContext.Routes.Include(A=>A.AircraftRoutes).ThenInclude(A=>A.Aircraft);
            //foreach (var route in data) {
            //    Console.WriteLine(route.Id);

            //    foreach (var route2 in route.AircraftRoutes) {
            //        Console.WriteLine(route2.Aircraft.Model);
            //    }
            //}

            //5.Retrieve all aircrafts with their airline and the airline’s phones.
            //var data = dbContext.Aircrafts.Include(a => a.AirCraftAirline).ThenInclude(b => b.Phones);

            //foreach (var aircraft in data) {
            //    Console.WriteLine(aircraft.Model);
            //    Console.WriteLine(aircraft.AirCraftAirline.Id);
            //    foreach(var phone in aircraft.AirCraftAirline.Phones)
            //    {
            //        Console.WriteLine(phone.Number);
            //    }   
            //}



            #endregion

            #region  Join Operators
            // 1.List all employees with their airline name.

            //var data = dbContext.Set<Empolyee>()
            //    .Join(dbContext.Airlines,
            //    E => E.AirlineId,
            //    A => A.Id,
            //    (E, A) => new
            //    {
            //        E.Id,
            //        E.Name,
            //        AirlineID = A.Id,
            //        AirlineName = A.Name
            //    });

            //foreach(var e in data)
            //{
            //    Console.WriteLine(e);
            //}

            //2.Show all routes with the aircraft model assigned and the airline name that owns the aircraft.

            //var data = from R in dbContext.Set<Route>()
            //           join AR in dbContext.AircraftRoutes on R.Id equals AR.RouteId
            //           join A in dbContext.Aircrafts on AR.AircraftId equals A.Id
            //           join AL in dbContext.Airlines on A.AirlineId equals AL.Id
            //           select new
            //           {
            //               R.Id,
            //               A.Model,
            //               AL.Name
            //           };

            //foreach (var item in data) {
            //    Console.WriteLine(item);
            //}

            //3. For each airline, list its aircraft models.
            //var data = from AL in dbContext.Set<Airline>()
            //           join A in dbContext.Aircrafts on AL.Id equals A.AirlineId
            //           select new
            //           {
            //               AL.Id,
            //               AL.Name,
            //               A.Model
            //           };

            //foreach (var item in data) {
            //    Console.WriteLine(item);
            //}

            //4.Show all transactions (id, amount, description) along with the airline name, but only where Amount > 20000.

            //var data = from T in dbContext.Set<Transaction>()
            //           join AL in dbContext.Airlines on T.AirlineId equals AL.Id
            //           where T.Amount >= 20000
            //           select new
            //           {
            //               T.Id,
            //               T.Amount,
            //               T.Description,
            //               AL.Name
            //           };
            //foreach(var item in data)
            //{
            //    Console.WriteLine(item);
            //}


            #endregion


        }
    }
}
