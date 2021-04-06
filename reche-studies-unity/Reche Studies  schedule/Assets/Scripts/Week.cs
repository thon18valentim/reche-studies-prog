using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Assets.Scripts
{
  public class Week
  {
    public bool Monday { get; set; }
    public bool Tuesday { get; set; }
    public bool Wednesday { get; set; }
    public bool Thursday { get; set; }
    public bool Friday { get; set; }
    public bool Saturday { get; set; }
    public bool Sunday { get; set; }
    public int Count_days { get; set; }
    public int Hours { get; set; }

    public Week(bool mon, bool tue, bool wed, bool thu, bool fri, bool sat, bool sun, int count)
    {
      Monday = mon;
      Tuesday = tue;
      Wednesday = wed;
      Thursday = thu;
      Friday = fri;
      Saturday = sat;
      Sunday = sun;
      Count_days = count;
    }

    public void SetWeekHours(int hours)
    {
      Hours = hours;
    }

  }

}
