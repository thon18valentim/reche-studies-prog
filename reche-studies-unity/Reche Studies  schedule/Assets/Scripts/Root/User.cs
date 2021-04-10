using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Assets.Scripts
{
  public class User
  {
    public Person Pessoa { get; set; }
    public Week Semana { get; set; }
    
    // How many contents per week
    public int Week_content_count { get; set; }
    // How many weeks to study
    public int Week_amount_study { get; set; }

    public User(Person pessoa, Week semana, int week_content_count, int week_amount_study)
    {
      Pessoa = pessoa;
      Semana = semana;
      Week_content_count = week_content_count;
      Week_amount_study = week_amount_study;
    }
  }
}
