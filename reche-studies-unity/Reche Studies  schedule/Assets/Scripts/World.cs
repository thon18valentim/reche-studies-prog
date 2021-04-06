using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class World : MonoBehaviour
{
  public static Person pessoa;
  public static Week week;

  static World()
  {
    PopulatingPerson();
    PopulatingWeek();
  }

  public static void PopulatingPerson()
  {
    pessoa = new Person("Name Empty", "Course Empty", "Insti Empty");
  }
  public static void PopulatingWeek()
  {
    week = new Week(true,true,true,true,true,false,false,5);
  }
}
