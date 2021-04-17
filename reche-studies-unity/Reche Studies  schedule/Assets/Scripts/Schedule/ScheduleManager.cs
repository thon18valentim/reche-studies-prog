using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using Assets.Scripts;
using System.IO;

public class ScheduleManager : MonoBehaviour
{
  // Checklist Modal 
  public GameObject checklist_modal;
  public GameObject slots_modal;
  public GameObject slots_modal_delete;

  public GameObject message_text;
  public GameObject message2_text;

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

  public TextMeshProUGUI current_week_text;

  // Start is called before the first frame update
  void Start()
    {
    user_name_txt.text = World.pessoa.GetName().ToUpper();
    SetAuxiliar();
    SelectingWeeks();
    ShowingWeek();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

  public void OpenInstagram()
  {
    Application.OpenURL("https://www.instagram.com/reche.studies/");
  }

  public void OpenCheckList(int i)
  {
    if(i == 1)
    {
      if (File.Exists(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(1).pdf"))
      {
        message_text.SetActive(false);
        Application.OpenURL(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(1).pdf");
      }
      else
      {
        message_text.SetActive(true);
        Debug.Log("Checklist não existe, favor criar!");
      } 
    }
    else if(i == 2)
    {
      if (File.Exists(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(2).pdf"))
      {
        message_text.SetActive(false);
        Application.OpenURL(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(2).pdf");
      }
      else
      {
        message_text.SetActive(true);
        Debug.Log("Checklist não existe, favor criar!");
      }

    }
    else if(i == 3)
    {
      if (File.Exists(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(3).pdf"))
      {
        message_text.SetActive(false);
        Application.OpenURL(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(3).pdf");
      }
      else
      {
        message_text.SetActive(true);
        Debug.Log("Checklist não existe, favor criar!");
      }

    }
    else
    {
      message_text.SetActive(true);
      Debug.Log("Checklist não existe, favor criar!");
    }
    
  }

  public void DeleteCheckList(int i)
  {
    if (i == 1)
    {
      if (File.Exists(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(1).pdf"))
      {
        message2_text.SetActive(false);
        File.Delete(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(1).pdf");
      }
      else
      {
        message2_text.SetActive(true);
        Debug.Log("Checklist não existe, favor criar!");
      }
    }
    else if (i == 2)
    {
      if (File.Exists(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(2).pdf"))
      {
        message2_text.SetActive(false);
        File.Delete(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(2).pdf");
      }
      else
      {
        message2_text.SetActive(true);
        Debug.Log("Checklist não existe, favor criar!");
      }

    }
    else if (i == 3)
    {
      if (File.Exists(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(3).pdf"))
      {
        message2_text.SetActive(false);
        File.Delete(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021(3).pdf");
      }
      else
      {
        message2_text.SetActive(true);
        Debug.Log("Checklist não existe, favor criar!");
      }

    }
    else
    {
      message2_text.SetActive(true);
      Debug.Log("Checklist não existe, favor criar!");
    }
  }

  public void SetAuxiliar()
  {
    if (World.usuario.Week_amount_study == 43)
    {
      World.usuario.Auxiliar = 92;
    }
    else if (World.usuario.Week_amount_study == 29)
    {
      World.usuario.Auxiliar = 62;
    }
    else if (World.usuario.Week_amount_study == 22)
    {
      World.usuario.Auxiliar = 47;
    }
    else if (World.usuario.Week_amount_study == 18)
    {
      World.usuario.Auxiliar = 38;
    }
    else
    {
      World.usuario.Auxiliar = 182;
    }
  }

  public void ShowingWeek()
  {
    current_week_text.text = World.usuario.Current_week.ToString();
  }

  public void Advance_week()
  {
    if (World.usuario.Current_week < World.usuario.Auxiliar)
    {
      World.usuario.Current_week += 1;
      if (World.usuario.Week_amount_study == 43)
      {
        World.usuario.Select += 2;
      }
      else if (World.usuario.Week_amount_study == 29)
      {
        World.usuario.Select += 3;
      }
      else if (World.usuario.Week_amount_study == 22)
      {
        World.usuario.Select += 4;
      }
      else if (World.usuario.Week_amount_study == 18)
      {
        World.usuario.Select += 5;
      }
      else
      {
        World.usuario.Select++;
      }
      SelectingWeeks();
      ShowingWeek();
    }
  }

  public void Back_week()
  {
    if (World.usuario.Select >= 1)
    {
      World.usuario.Current_week -= 1;
      if (World.usuario.Week_amount_study == 43)
      {
        World.usuario.Select -= 2;
      }
      else if (World.usuario.Week_amount_study == 29)
      {
        World.usuario.Select -= 3;
      }
      else if (World.usuario.Week_amount_study == 22)
      {
        World.usuario.Select -= 4;
      }
      else if (World.usuario.Week_amount_study == 18)
      {
        World.usuario.Select -= 5;
      }
      else
      {
        World.usuario.Select--;
      }
      SelectingWeeks();
      ShowingWeek();
    }
  }

  public void SelectingWeeks()
  {
    essay_txt.text = "Escolha um tema e faça uma redação";

    try
    {
      lang1_txt.text = World.cont_Languages[World.usuario.Select].Name;
    }
    catch
    {
      lang1_txt.text = null;
    }

    try
    {
      mat1_txt.text = World.cont_Math[World.usuario.Select].Name;
    }
    catch
    {
      mat1_txt.text = null;
    }

    try
    {
      nat1_txt.text = World.cont_cNature[World.usuario.Select].Name;
    }
    catch
    {
      nat1_txt.text = null;
    }

    try
    {
      hum1_txt.text = World.cont_cHumans[World.usuario.Select].Name;
    }
    catch
    {
      hum1_txt.text = null;
    }
    
    
    
    

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
      try
      {
        lang2_txt.text = World.cont_Languages[World.usuario.Select + 1].Name;
      }
      catch
      {
        lang2_txt.text = null;
      }

      try
      {
        mat2_txt.text = World.cont_Math[World.usuario.Select + 1].Name;
      }
      catch
      {
        mat2_txt.text = null;
      }

      try
      {
        nat2_txt.text = World.cont_cNature[World.usuario.Select + 1].Name;
      }
      catch
      {
        nat2_txt.text = null;
      }

      try
      {
        hum2_txt.text = World.cont_cHumans[World.usuario.Select + 1].Name;
      }
      catch
      {
        hum2_txt.text = null;
      }
    }
    if(World.usuario.Week_amount_study <= 29)
    {
      try
      {
        lang3_txt.text = World.cont_Languages[World.usuario.Select + 2].Name;
      }
      catch
      {
        lang3_txt.text = null;
      }

      try
      {
        mat3_txt.text = World.cont_Math[World.usuario.Select + 2].Name;
      }
      catch
      {
        mat3_txt.text = null;
      }

      try
      {
        nat3_txt.text = World.cont_cNature[World.usuario.Select + 2].Name;
      }
      catch
      {
        nat3_txt.text = null;
      }

      try
      {
        hum3_txt.text = World.cont_cHumans[World.usuario.Select + 2].Name;
      }
      catch
      {
        hum3_txt.text = null;
      }
    }
    if(World.usuario.Week_amount_study <= 22)
    {
      try
      {
        lang4_txt.text = World.cont_Languages[World.usuario.Select + 3].Name;
      }
      catch
      {
        lang4_txt.text = null;
      }

      try
      {
        mat4_txt.text = World.cont_Math[World.usuario.Select + 3].Name;
      }
      catch
      {
        mat4_txt.text = null;
      }

      try
      {
        nat4_txt.text = World.cont_cNature[World.usuario.Select + 3].Name;
      }
      catch
      {
        nat4_txt.text = null;
      }

      try
      {
        hum4_txt.text = World.cont_cHumans[World.usuario.Select + 3].Name;
      }
      catch
      {
        hum4_txt.text = null;
      }
    }
    if(World.usuario.Week_amount_study <= 18)
    {
      try
      {
        lang5_txt.text = World.cont_Languages[World.usuario.Select + 4].Name;
      } 
      catch
      {
        lang5_txt.text = null;
      }

      try
      {
        mat5_txt.text = World.cont_Math[World.usuario.Select + 4].Name;
      }
      catch
      {
        mat5_txt.text = null;
      }

      try
      {
        nat5_txt.text = World.cont_cNature[World.usuario.Select + 4].Name;
      }
      catch
      {
        nat5_txt.text = null;
      }

      try
      {
        hum5_txt.text = World.cont_cHumans[World.usuario.Select + 4].Name;
      }
      catch
      {
        hum5_txt.text = null;
      }
    }
  }

  public void open_checklist_modal()
  {
    checklist_modal.SetActive(true);
  }

  public void close_checklist_modal()
  {
    checklist_modal.SetActive(false);
    slots_modal.SetActive(false);
    message_text.SetActive(false);
    slots_modal.SetActive(false);
    slots_modal_delete.SetActive(false);
  }

  public void Open_modal_slots()
  {
    slots_modal.SetActive(true);
    slots_modal_delete.SetActive(false);
    message_text.SetActive(false);
    message2_text.SetActive(false);
  }

  public void Open_modal_slots2()
  {
    slots_modal.SetActive(false);
    slots_modal_delete.SetActive(true);
    message_text.SetActive(false);
    message2_text.SetActive(false);
  }

  public void Create_checklist()
  {
    if(World.usuario.Checklists < 3)
    {
      World.usuario.Checklists++;
      File.Copy(System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021.pdf", System.Environment.CurrentDirectory + "/Cronograma/CRONOGRAMA_ENEM 2021("+World.usuario.Checklists.ToString()+").pdf");
      Debug.Log("Checklist Criado");
      message_text.SetActive(false);
      message2_text.SetActive(false);
    }
    else
    {
      Debug.Log("Memória cheia");
    }
  }
}
