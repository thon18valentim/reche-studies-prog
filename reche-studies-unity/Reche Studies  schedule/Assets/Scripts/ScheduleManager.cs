using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class ScheduleManager : MonoBehaviour
{
  public TextMeshProUGUI user_name_txt;

    // Start is called before the first frame update
    void Start()
    {
    user_name_txt.text = World.pessoa.GetName();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
