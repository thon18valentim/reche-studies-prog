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
  public static Subject cMath;
  public static Subject cLanguages;

  public static List<Content> cont_cHumans = new List<Content>();
  public static List<Content> cont_cNature = new List<Content>();
  public static List<Content> cont_Math = new List<Content>();
  public static List<Content> cont_Languages = new List<Content>();

  static World()
  {
    PopulatingPerson();
    PopulatingWeek();
    PopulatingUser();
    PopulatingCHumans();
    PopulatingCNature();
    PopulatingCMath();
    PopulatingLanguages();
    PopulatingSubjects();
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
    cMath = new Subject(3, "Matem�tica e suas Tecnologias",cont_Math);
    cLanguages = new Subject(4, "Linguagens, C�digos e suas Tecnologias",cont_Languages);
  }

  public static void PopulatingUser()
  {
    usuario = new User(pessoa, week, 1, 86);
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
    cont_cNature.Add(new Content(1, "Biologia", "Permeabilidade Seletiva", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Organelas", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Respira��o Aer�bica", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Fermenta��o", 2));
    cont_cNature.Add(new Content(1, "Biologia", "DNA e RNA", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Mitose e Meiose", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Descartes", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Classifica��o dos Seres Vivos", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Filogenia", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Nomenclaturas", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Reino Monera", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Reino Fungi", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Reino Protista", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Fotoss�ntese", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Algas", 2));
  }
  public static void PopulatingCMath()
  {
    cont_Math.Add(new Content(1, "Matem�tica", "Conjuntos Num�ricos", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Express�es Num�ricas", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Pot�ncias", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Equa��es", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Inequa��es", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Teoria dos Conjuntos", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Fun��es: Fun��o Linear", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Tipos de Fun��o", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Fun��o Quadr�tica", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Grandezas Proporcionais: Porcentagem", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Fun��es Exponenciais: Fun��es Logar�tmicas", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Progress�es", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "An�lise Combinat�ria, Permuta��es, Arranjos, Combina��o Simples", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Probabilidade", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Matrizes", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Sistema de Equa��es Lineares", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Trigonometria", 2));
    cont_Math.Add(new Content(1, "Matem�tica", "Geometria Anal�tica", 2));
  }
  public static void PopulatingLanguages()
  {
    cont_Languages.Add(new Content(1, "Portugu�s", "Fon�tica e Fonologia", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Acentua��o Gr�fica", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Significa��o das Palavras", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Estrutura e Forma��o das Palavras", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Pronomes", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Conjun��es", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Interjei��o", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Sujeito e Predicado", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Adjunto Adnominal/Adverbial/ Aposto e Vocativo", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Ora��es Coordenadas", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Ora��es Subordinadas", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Pontua��o", 2));
    cont_Languages.Add(new Content(1, "Portugu�s", "Figuras de Linguagem", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Classicismo", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Quinhentismo", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Barroco", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Arcadismo", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Romantismo no Brasil", 2));
  }
}
