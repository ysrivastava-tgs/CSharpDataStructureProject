using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace CSharDataStructureProject
{
    public class RainbowSchool
    {
        public string Name { get; }
        public string Class { get; }
        public RainbowSchool(string name,string cls)
            {
            Name = name;
            Class = cls;
            }
        public static void SortedDetails()
        {
            List<RainbowSchool> obj = new List<RainbowSchool>();
            string path = GetPath();
            if (File.Exists(path))
            {
                string[] contents = File.ReadAllLines(path);
                foreach (string content in contents)
                {
                    string[] details = content.Split(",");
                     obj.Add(new RainbowSchool(details[0],details[1]));
                }               
            }
            obj.Sort(delegate (RainbowSchool x, RainbowSchool y) {
                return x.Name.CompareTo(y.Name);
            });
            Console.WriteLine("Sorted Data");
            foreach(var x in obj)
            {
                Console.WriteLine($"Name: {x.Name}, Class: {x.Class}");
            }
        }
        public static string GetPath()
        {
            string dir = Directory.GetCurrentDirectory();
            String path = dir + "\\RainbowSchoolStudentData.txt";
            return path;
        }
        public static void Search(String name)
        {
            string path = GetPath();
            bool flag = false;
            string nm="";
            string cls="";
            if (File.Exists(path))
            {
                string[] contents = File.ReadAllLines(path);
                foreach (string content in contents)
                {
                    string[] details = content.Split(",");
                    if(details[0].Equals(name))
                    {
                        flag = true;
                        nm = details[0];
                        cls = details[1];
                    }
                }
            }
            if (flag)
            {
                Console.WriteLine("Data Found");
                Console.WriteLine($"Name: {nm}, Class: {cls}");
            }
            else
                Console.WriteLine("No such data");
        }
    }
}
