﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using assignment24lib;

namespace assignment24_1
{

    internal class Program
    {
        static void Main(string[] args)
        {
            /* Employee employee = new Employee();
             Console.WriteLine("Enter Employee's Id");
             employee.Id = int.Parse(Console.ReadLine());
             Console.WriteLine("Enter employee's First Name");
             employee.FirstName = Console.ReadLine();
             Console.WriteLine("Enter employee's last Name");
             employee.LastName = Console.ReadLine();
             Console.WriteLine("Enter employee's salary");
             employee.Salary = double.Parse(Console.ReadLine());
             BinaryFormatter formatter = new BinaryFormatter();
             using (FileStream fs = new FileStream(" ", FileMode.Create))

             {
                 formatter.Serialize(fs, employee);
             }
             Console.WriteLine("Created & Serialized");
             BinaryFormatter formatter1 = new BinaryFormatter();
             using (FileStream fs = new FileStream("D:\\exercises\\7-8\\employee.bin", FileMode.Open))
             {
                 Employee obj = (Employee)formatter.Deserialize(fs);
                 Console.WriteLine($"Serialiae employee id is :  {obj.Id}   firstname : {obj.FirstName} , lastname:  {obj.LastName}, salary : {obj.Salary}");

             }
             Employee employee1 = new Employee { Id = 1, FirstName = "Raj", LastName = "Koti", Salary = 25000 };
             //Serialize the object to XML
             XmlSerializer serializer = new XmlSerializer(typeof(Employee));
             using (TextWriter writer = new StreamWriter("C:\\Users\\91849\\OneDrive\\Desktop\\ASSIGNMENTS"))

             {
                 serializer.Serialize(writer, employee1);
             }
             Console.WriteLine("Created & Serialized");

             //Deserialized the object to xml
             XmlSerializer serializer1 = new XmlSerializer(typeof(Employee));
             using (TextReader reader = new StreamReader("D:\\exercises\\7-8\\employee.xml"))
             {
                 Employee deserializedPerson = (Employee)serializer.Deserialize(reader);
                 Console.WriteLine($" ID: {deserializedPerson.Id} , FirstName: {deserializedPerson.FirstName}, LastName: {deserializedPerson.LastName}, Salary: {deserializedPerson.Salary}");
             }*/

            Employee employee = new Employee();
            Console.WriteLine("Enter Employee's Id");
            employee.Id = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter employee's First Name");
            employee.FirstName = Console.ReadLine();
            Console.WriteLine("Enter employee's last Name");
            employee.LastName = Console.ReadLine();
            Console.WriteLine("Enter employee's salary");
            employee.Salary = double.Parse(Console.ReadLine());
            BinaryFormatter formatter = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\91849\\OneDrive\\Desktop\\ASSIGNMENTS\\assignment24-1\\employee.bin", FileMode.Create))
            {
                formatter.Serialize(fs, employee);
            }
            Console.WriteLine("Created & Serialized");
            BinaryFormatter formatter1 = new BinaryFormatter();
            using (FileStream fs = new FileStream("C:\\Users\\91849\\OneDrive\\Desktop\\ASSIGNMENTS\\assignment24-1\\employee.bin", FileMode.Open))
            {
                Employee obj = (Employee)formatter.Deserialize(fs);
                Console.WriteLine($"Serialiae employee id is :  {obj.Id}   firstname : {obj.FirstName} , lastname:  {obj.LastName}, salary : {obj.Salary}");

            }
            Employee employee1 = new Employee { Id = 1, FirstName = "Raj", LastName = "Koti", Salary = 25000 };
            //Serialize the object to XML
            XmlSerializer serializer = new XmlSerializer(typeof(Employee));
            using (TextWriter writer = new StreamWriter("C:\\Users\\91849\\OneDrive\\Desktop\\ASSIGNMENTS\\assignment24-1\\employee.xml"))

            {
                serializer.Serialize(writer, employee1);
            }
            Console.WriteLine("Created & Serialized");

            //Deserialized the object to xml
            XmlSerializer serializer1 = new XmlSerializer(typeof(Employee));
            using (TextReader reader = new StreamReader("C:\\Users\\91849\\OneDrive\\Desktop\\ASSIGNMENTS\\assignment24-1\\employee.xml"))
            {
                Employee deserializedPerson = (Employee)serializer.Deserialize(reader);
                Console.WriteLine($" ID: {deserializedPerson.Id} , FirstName: {deserializedPerson.FirstName}, LastName: {deserializedPerson.LastName}, Salary: {deserializedPerson.Salary}");
            }




            Console.ReadKey();
        }
    }
}
