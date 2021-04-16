using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreatingSchedule : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
    World.usuario.Week_content_count = (int)World.week.Hours / 2;
    World.usuario.Week_amount_study = (int)(427 / World.usuario.Week_content_count) + 1;
    Debug.Log("Matérias por semana " + World.usuario.Week_content_count);
    Debug.Log(World.usuario.Week_amount_study + " semanas para conclusão!");
    FindObjectOfType<SceneLoader>().LoadScene(5);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
