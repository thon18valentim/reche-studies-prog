using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assets.Scripts
{
  public class Person
  {
    public string Name { get; set; }
    public string Course { get; set; }
    public string Insti { get; set; }

    public Person(string name, string course, string insti)
    {
      Name = name;
      Course = course;
      Insti = insti;
    }

    public string GetName()
    {
      return Name;
    }
    public string GetCourse()
    {
      return Course;
    }
    public string GetInsti()
    {
      return Insti;
    }
  }
}
