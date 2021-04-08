using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingSchedule : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    World.usuario.Week_content_count = (int)World.week.Hours / 2;
    Debug.Log("Matérias por semana " + World.usuario.Week_content_count);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
