using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class World : MonoBehaviour
{
  public static Person pessoa;

  static World()
  {
    PopulatingPerson();
  }

  public static void PopulatingPerson()
  {
    pessoa = new Person("Name Empty", "Course Empty", "Insti Empty");
  }
}
