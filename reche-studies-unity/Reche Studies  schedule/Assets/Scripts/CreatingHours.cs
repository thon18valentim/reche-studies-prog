using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CreatingHours : MonoBehaviour
{
  public Slider hours_sld;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void SetHours()
  {
    int hours = (int) hours_sld.value;
    World.week.SetWeekHours(hours * 10);
    Debug.Log(World.week.Hours);
  }
}
