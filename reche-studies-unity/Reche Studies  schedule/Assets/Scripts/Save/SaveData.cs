using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using Assets.Scripts;

public class SaveData : MonoBehaviour
{
  public void SavingProg()
  {
    Save();
    Debug.Log("Saving Prog");
  }

  // Loading Game button func
  public void LoadingProg()
  {
    LoadSave();
    Debug.Log("Loading Prog");
  }

  void Save()
  {
    BinaryFormatter bf = new BinaryFormatter();
    FileStream fs = File.Create(Application.persistentDataPath + "/progSave.data");
    SaveClass s = new SaveClass();

    s.current_week = World.usuario.Current_week;
    s.select = World.usuario.Select;
    s.auxiliar = World.usuario.Auxiliar;
    s.pessoa = World.pessoa;
    s.week = World.week;
    s.usuario = World.usuario;

    // Serializing
    bf.Serialize(fs, s);
    fs.Close();
    Debug.Log("Serializing data");
  }

  void LoadSave()
  {
    if(File.Exists(Application.persistentDataPath + "/progSave.data"))
    {
      Debug.Log("Save File Found");
      BinaryFormatter bf = new BinaryFormatter();
      FileStream fs = File.Open(Application.persistentDataPath + "/progSave.data", FileMode.Open);

      SaveClass s = (SaveClass)bf.Deserialize(fs);
      fs.Close();

      World.usuario.Current_week = s.current_week;
      World.usuario.Select = s.select;
      World.usuario.Auxiliar = s.auxiliar;

      World.pessoa = s.pessoa;
      World.week = s.week;
      World.usuario = s.usuario;

      Debug.Log("Saved Data restored!");
    }
    else
    {
      Debug.Log("ERROR! Save File do not Found");
    }
  }

  [Serializable]
  class SaveClass
  {
    public int current_week;
    public int select;
    public int auxiliar;

    public Person pessoa;
    public Week week;
    public User usuario;
  }
}
