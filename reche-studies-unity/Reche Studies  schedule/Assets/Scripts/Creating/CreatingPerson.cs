using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using Assets.Scripts;
using TMPro;

public class CreatingPerson : MonoBehaviour
{
  // Getting Input Fields
  public TMP_InputField name_input;
  public TMP_InputField course_input;
  public TMP_InputField insti_input;

  // Creating Aux Var
  public TextMeshProUGUI name_txt;
  public TextMeshProUGUI course_txt;
  public TextMeshProUGUI insti_txt;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    
    }

  public void Atualiza_name()
  {
    name_txt.text = name_input.text;
  }
  public void Atualiza_course()
  {
    course_txt.text = course_input.text;
  }
  public void Atualiza_insti()
  {
    insti_txt.text = insti_input.text;
  }

  public void Creating_person()
  {
    World.pessoa.Name = name_txt.text;
    World.pessoa.Course = course_txt.text;
    World.pessoa.Insti = insti_txt.text;
    Debug.Log("Pessoa Criada!");
    Debug.Log(World.pessoa.Name);
  }
}
