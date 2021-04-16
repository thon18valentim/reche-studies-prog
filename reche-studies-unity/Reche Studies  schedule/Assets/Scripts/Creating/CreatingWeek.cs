using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatingWeek : MonoBehaviour
{
  public Toggle tg1;
  public Toggle tg2;
  public Toggle tg3;
  public Toggle tg4;
  public Toggle tg5;
  public Toggle tg6;
  public Toggle tg7;

  public List<Toggle> week_aux = new List<Toggle>();

    // Start is called before the first frame update
    void Start()
    {
    CreatingWeekList();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void CreatingWeekList()
  {
    week_aux.Add(tg1);
    week_aux.Add(tg2);
    week_aux.Add(tg3);
    week_aux.Add(tg4);
    week_aux.Add(tg5);
    week_aux.Add(tg6);
    week_aux.Add(tg7);
    Debug.Log("Week List Created");
  }

  public void Creating_week()
  {
    World.week.Monday = tg1.isOn;
    World.week.Tuesday = tg2.isOn;
    World.week.Wednesday = tg3.isOn;
    World.week.Thursday = tg4.isOn;
    World.week.Friday = tg5.isOn;
    World.week.Saturday = tg6.isOn;
    World.week.Sunday = tg7.isOn;
    World.week.Count_days = 0;

    foreach(Toggle tg in week_aux)
    {
      if (tg.isOn)
      {
        World.week.Count_days++;
      }
    }

    Debug.Log(World.week.Monday);
    Debug.Log(World.week.Sunday);
    Debug.Log(World.week.Count_days);
  }
}
