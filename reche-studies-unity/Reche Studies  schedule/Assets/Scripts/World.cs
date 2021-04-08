using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Assets.Scripts;

public class World : MonoBehaviour
{
  public static Person pessoa;
  public static Week week;
  public static User usuario;

  public static Subject cHumans;
  public static Subject cNature;

  public static List<Content> cont_cHumans = new List<Content>();
  public static List<Content> cont_cNature = new List<Content>();

  static World()
  {
    PopulatingPerson();
    PopulatingWeek();
    PopulatingUser();
    PopulatingCHumans();
    PopulatingCNature();
  }

  public static void PopulatingPerson()
  {
    pessoa = new Person("Name Empty", "Course Empty", "Insti Empty");
  }
  public static void PopulatingWeek()
  {
    week = new Week(true,true,true,true,true,false,false,5);
  }
  public static void PopulatingSubjects()
  {
    cHumans = new Subject(1,"Ci�ncias Humanas",cont_cHumans);
    cNature = new Subject(2, "Ci�ncias da Natureza",cont_cNature);
  }

  public static void PopulatingUser()
  {
    usuario = new User(pessoa, week, 1);
  }

  public static void PopulatingCHumans()
  {
    cont_cHumans.Add(new Content(1, "Hist�ria", "Pr�-Hist�ria", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Gr�cia Antiga", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Roma Antiga", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Hist�ria do Islamismo", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Maias, Incas e Astecas", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Alta Idade M�dia: Imp�rio Bizantino", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Carlos Magno e seu Imp�rio", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Catolicismo na Idade M�dia", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Feudalismo", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Forma��o dos Estados Nacionais Europeus", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Renascimento", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Reformas Religiosas", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Expans�o Mar�timo Comercial Europeia", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Mercantilismo e Coloniza��o das Am�ricas", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Absolutismo: Teorias e Governos", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Revolu��o Inglesa do S�culo XVII", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Iluminismo", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "EUA: Coloniza��o e Independ�ncia", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Revolu��o Francesa", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Imp�rio de Napole�o e o Congresso de Viena", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Independ�ncia das Col�nias da Am�rica", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Revolu��es na Fran�a", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Revolu��o Industrial", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Liberalismo, Socialismo e Anarquismo", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Guerra de Secess�o dos Estados Unidos", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Imperialismo �sia e �frica", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Primeira Guerra Mundial", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Revolu��o Russa e o Governo de Stalin", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Nazi-Facismo", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Crise de 1929 e a Grande Depress�o", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Segunda Guerra Mundial e A Guerra Civil Espanhola", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Holocausto", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Guerra Fria", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Uni�o Sovi�tica", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Conflito �rabe-Israelense", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Am�rica Latina no S�culo XX", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Queda do muro de Berlim", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Fim da Guerra Fria", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "Descoloniza��o", 2));
    cont_cHumans.Add(new Content(1, "Hist�ria", "�frica do Sul e o Apartheid", 2));
  }
  public static void PopulatingCNature()
  {
    cont_cNature.Add(new Content(1, "Biologia", "C�lulas Procariontes e Eucariontes",2));
    cont_cNature.Add(new Content(1, "Biologia", "Estrutura Qu�mica e o Metabolismo Celular", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Membrana Plasm�tica", 2));
  }
}
