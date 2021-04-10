using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;

public class ScheduleManager : MonoBehaviour
{
  public TextMeshProUGUI user_name_txt;

  // Languages Texts
  public TextMeshProUGUI lang1_txt;
  public TextMeshProUGUI lang2_txt;
  public TextMeshProUGUI lang3_txt;
  public TextMeshProUGUI lang4_txt;
  public TextMeshProUGUI lang5_txt;
  // Humans Texts
  public TextMeshProUGUI hum1_txt;
  public TextMeshProUGUI hum2_txt;
  public TextMeshProUGUI hum3_txt;
  public TextMeshProUGUI hum4_txt;
  public TextMeshProUGUI hum5_txt;
  // Nature Texts
  public TextMeshProUGUI nat1_txt;
  public TextMeshProUGUI nat2_txt;
  public TextMeshProUGUI nat3_txt;
  public TextMeshProUGUI nat4_txt;
  public TextMeshProUGUI nat5_txt;
  // Math Texts
  public TextMeshProUGUI mat1_txt;
  public TextMeshProUGUI mat2_txt;
  public TextMeshProUGUI mat3_txt;
  public TextMeshProUGUI mat4_txt;
  public TextMeshProUGUI mat5_txt;
  // Essay Text
  public TextMeshProUGUI essay_txt;

  // Controls Week Selection
  int select = 0;
  // Show Current Week to the user
  int current_week = 1;
  public TextMeshProUGUI current_week_text;

  // Start is called before the first frame update
  void Start()
    {
    user_name_txt.text = World.pessoa.GetName().ToUpper();
    SelectingWeeks();
    ShowingWeek();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
  public void OpenCheckList()
  {
    Application.OpenURL(System.Environment.CurrentDirectory + "/CRONOGRAMA_ENEM 2021.pdf");
  }

  public void ShowingWeek()
  {
    current_week_text.text = current_week.ToString();
  }

  public void Advance_week()
  {
    if (select < World.usuario.Week_amount_study)
    {
      current_week += 1;
      if (World.usuario.Week_amount_study == 43)
      {
        select += 2;
      }
      else if (World.usuario.Week_amount_study == 29)
      {
        select += 3;
      }
      else if (World.usuario.Week_amount_study == 22)
      {
        select += 4;
      }
      else if (World.usuario.Week_amount_study == 18)
      {
        select += 5;
      }
      else
      {
        select++;
      }
      SelectingWeeks();
      ShowingWeek();
    }
  }

  public void Back_week()
  {
    if (select >= 1)
    {
      current_week -= 1;
      if (World.usuario.Week_amount_study == 43)
      {
        select -= 2;
      }
      else if (World.usuario.Week_amount_study == 29)
      {
        select -= 3;
      }
      else if (World.usuario.Week_amount_study == 22)
      {
        select -= 4;
      }
      else if (World.usuario.Week_amount_study == 18)
      {
        select -= 5;
      }
      else
      {
        select--;
      }
      SelectingWeeks();
      ShowingWeek();
    }
  }

  public void SelectingWeeks()
  {
    essay_txt.text = "Escolha um tema e faça uma redação";
    
    lang1_txt.text = World.cont_Languages[select].Name;
    mat1_txt.text = World.cont_Math[select].Name;
    nat1_txt.text = World.cont_cNature[select].Name;
    hum1_txt.text = World.cont_cHumans[select].Name;
    lang2_txt.text = null;
    mat2_txt.text = null;
    nat2_txt.text = null;
    hum2_txt.text = null;
    lang3_txt.text = null;
    mat3_txt.text = null;
    nat3_txt.text = null;
    hum3_txt.text = null;
    lang4_txt.text = null;
    mat4_txt.text = null;
    nat4_txt.text = null;
    hum4_txt.text = null;
    lang5_txt.text = null;
    mat5_txt.text = null;
    nat5_txt.text = null;
    hum5_txt.text = null;
    if (World.usuario.Week_amount_study <= 43)
    {
      lang2_txt.text = World.cont_Languages[select + 1].Name;
      mat2_txt.text = World.cont_Math[select + 1].Name;
      nat2_txt.text = World.cont_cNature[select + 1].Name;
      hum2_txt.text = World.cont_cHumans[select + 1].Name;
    }
    if(World.usuario.Week_amount_study <= 29)
    {
      lang3_txt.text = World.cont_Languages[select + 2].Name;
      mat3_txt.text = World.cont_Math[select + 2].Name;
      nat3_txt.text = World.cont_cNature[select + 2].Name;
      hum3_txt.text = World.cont_cHumans[select + 2].Name;
    }
    if(World.usuario.Week_amount_study <= 22)
    {
      lang4_txt.text = World.cont_Languages[select + 3].Name;
      mat4_txt.text = World.cont_Math[select + 3].Name;
      nat4_txt.text = World.cont_cNature[select + 3].Name;
      hum4_txt.text = World.cont_cHumans[select + 3].Name;
    }
    if(World.usuario.Week_amount_study <= 18)
    {
      lang5_txt.text = World.cont_Languages[select + 4].Name;
      mat5_txt.text = World.cont_Math[select + 4].Name;
      nat5_txt.text = World.cont_cNature[select + 4].Name;
      hum5_txt.text = World.cont_cHumans[select + 4].Name;
    }
  }
}
