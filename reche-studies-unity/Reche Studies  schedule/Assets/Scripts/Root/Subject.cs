using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assets.Scripts
{
  [Serializable]
  public class Subject
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public List<Content> Content_list { get; set; }
    public int Count_content { get; set; }

    public Subject(int id, string name, List<Content> content_list)
    {
      Id = id;
      Name = name;
    }
  }
}
