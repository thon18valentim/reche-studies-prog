using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
  public class User
  {
    public Person Pessoa { get; set; }
    public Week Semana { get; set; }
    public int Week_content_count { get; set; }

    public User(Person pessoa, Week semana, int week_content_count)
    {
      Pessoa = pessoa;
      Semana = semana;
      Week_content_count = week_content_count;
    }
  }
}
