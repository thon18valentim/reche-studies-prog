using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
  public class Content
  {
    public int Id { get; set; }
    public string Sub_subject { get; set; }
    public string Name { get; set; }
    public int Time { get; set; }

    public Content(int id, string sub_subject, string name, int time)
    {
      Id = id;
      Sub_subject = sub_subject;
      Name = name;
      Time = time;
    }
  }
}
