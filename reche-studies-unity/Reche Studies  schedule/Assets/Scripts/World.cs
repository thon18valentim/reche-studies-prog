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
    cHumans = new Subject(1,"Ciências Humanas",cont_cHumans);
    cNature = new Subject(2, "Ciências da Natureza",cont_cNature);
    cMath = new Subject(3, "Matemática e suas Tecnologias",cont_Math);
    cLanguages = new Subject(4, "Linguagens, Códigos e suas Tecnologias",cont_Languages);
  }

  public static void PopulatingUser()
  {
    usuario = new User(pessoa, week, 1, 86);
  }

  public static void PopulatingCHumans()
  {
    cont_cHumans.Add(new Content(1, "História", "Pré-História", 2));
    cont_cHumans.Add(new Content(1, "História", "Grécia Antiga", 2));
    cont_cHumans.Add(new Content(1, "História", "Roma Antiga", 2));
    cont_cHumans.Add(new Content(1, "História", "História do Islamismo", 2));
    cont_cHumans.Add(new Content(1, "História", "Maias, Incas e Astecas", 2));
    cont_cHumans.Add(new Content(1, "História", "Alta Idade Média: Império Bizantino", 2));
    cont_cHumans.Add(new Content(1, "História", "Carlos Magno e seu Império", 2));
    cont_cHumans.Add(new Content(1, "História", "Catolicismo na Idade Média", 2));
    cont_cHumans.Add(new Content(1, "História", "Feudalismo", 2));
    cont_cHumans.Add(new Content(1, "História", "Formação dos Estados Nacionais Europeus", 2));
    cont_cHumans.Add(new Content(1, "História", "Renascimento", 2));
    cont_cHumans.Add(new Content(1, "História", "Reformas Religiosas", 2));
    cont_cHumans.Add(new Content(1, "História", "Expansão Marítimo Comercial Europeia", 2));
    cont_cHumans.Add(new Content(1, "História", "Mercantilismo e Colonização das Américas", 2));
    cont_cHumans.Add(new Content(1, "História", "Absolutismo: Teorias e Governos", 2));
    cont_cHumans.Add(new Content(1, "História", "Revolução Inglesa do Século XVII", 2));
    cont_cHumans.Add(new Content(1, "História", "Iluminismo", 2));
    cont_cHumans.Add(new Content(1, "História", "EUA: Colonização e Independência", 2));
    cont_cHumans.Add(new Content(1, "História", "Revolução Francesa", 2));
    cont_cHumans.Add(new Content(1, "História", "Império de Napoleão e o Congresso de Viena", 2));
    cont_cHumans.Add(new Content(1, "História", "Independência das Colônias da América", 2));
    cont_cHumans.Add(new Content(1, "História", "Revoluções na França", 2));
    cont_cHumans.Add(new Content(1, "História", "Revolução Industrial", 2));
    cont_cHumans.Add(new Content(1, "História", "Liberalismo, Socialismo e Anarquismo", 2));
    cont_cHumans.Add(new Content(1, "História", "Guerra de Secessão dos Estados Unidos", 2));
    cont_cHumans.Add(new Content(1, "História", "Imperialismo Ásia e África", 2));
    cont_cHumans.Add(new Content(1, "História", "Primeira Guerra Mundial", 2));
    cont_cHumans.Add(new Content(1, "História", "Revolução Russa e o Governo de Stalin", 2));
    cont_cHumans.Add(new Content(1, "História", "Nazi-Facismo", 2));
    cont_cHumans.Add(new Content(1, "História", "Crise de 1929 e a Grande Depressão", 2));
    cont_cHumans.Add(new Content(1, "História", "Segunda Guerra Mundial e A Guerra Civil Espanhola", 2));
    cont_cHumans.Add(new Content(1, "História", "Holocausto", 2));
    cont_cHumans.Add(new Content(1, "História", "Guerra Fria", 2));
    cont_cHumans.Add(new Content(1, "História", "União Soviética", 2));
    cont_cHumans.Add(new Content(1, "História", "Conflito Árabe-Israelense", 2));
    cont_cHumans.Add(new Content(1, "História", "América Latina no Século XX", 2));
    cont_cHumans.Add(new Content(1, "História", "Queda do muro de Berlim", 2));
    cont_cHumans.Add(new Content(1, "História", "Fim da Guerra Fria", 2));
    cont_cHumans.Add(new Content(1, "História", "Descolonização", 2));
    cont_cHumans.Add(new Content(1, "História", "África do Sul e o Apartheid", 2));
  }
  public static void PopulatingCNature()
  {
    cont_cNature.Add(new Content(1, "Biologia", "Células Procariontes e Eucariontes",2));
    cont_cNature.Add(new Content(1, "Biologia", "Estrutura Química e o Metabolismo Celular", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Membrana Plasmática", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Permeabilidade Seletiva", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Organelas", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Respiração Aeróbica", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Fermentação", 2));
    cont_cNature.Add(new Content(1, "Biologia", "DNA e RNA", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Mitose e Meiose", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Descartes", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Classificação dos Seres Vivos", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Filogenia", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Nomenclaturas", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Reino Monera", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Reino Fungi", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Reino Protista", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Fotossíntese", 2));
    cont_cNature.Add(new Content(1, "Biologia", "Algas", 2));
  }
  public static void PopulatingCMath()
  {
    cont_Math.Add(new Content(1, "Matemática", "Conjuntos Numéricos", 2));
    cont_Math.Add(new Content(1, "Matemática", "Expressões Numéricas", 2));
    cont_Math.Add(new Content(1, "Matemática", "Potências", 2));
    cont_Math.Add(new Content(1, "Matemática", "Equações", 2));
    cont_Math.Add(new Content(1, "Matemática", "Inequações", 2));
    cont_Math.Add(new Content(1, "Matemática", "Teoria dos Conjuntos", 2));
    cont_Math.Add(new Content(1, "Matemática", "Funções: Função Linear", 2));
    cont_Math.Add(new Content(1, "Matemática", "Tipos de Função", 2));
    cont_Math.Add(new Content(1, "Matemática", "Função Quadrática", 2));
    cont_Math.Add(new Content(1, "Matemática", "Grandezas Proporcionais: Porcentagem", 2));
    cont_Math.Add(new Content(1, "Matemática", "Funções Exponenciais: Funções Logarítmicas", 2));
    cont_Math.Add(new Content(1, "Matemática", "Progressões", 2));
    cont_Math.Add(new Content(1, "Matemática", "Análise Combinatória, Permutações, Arranjos, Combinação Simples", 2));
    cont_Math.Add(new Content(1, "Matemática", "Probabilidade", 2));
    cont_Math.Add(new Content(1, "Matemática", "Matrizes", 2));
    cont_Math.Add(new Content(1, "Matemática", "Sistema de Equações Lineares", 2));
    cont_Math.Add(new Content(1, "Matemática", "Trigonometria", 2));
    cont_Math.Add(new Content(1, "Matemática", "Geometria Analítica", 2));
  }
  public static void PopulatingLanguages()
  {
    cont_Languages.Add(new Content(1, "Português", "Fonética e Fonologia", 2));
    cont_Languages.Add(new Content(1, "Português", "Acentuação Gráfica", 2));
    cont_Languages.Add(new Content(1, "Português", "Significação das Palavras", 2));
    cont_Languages.Add(new Content(1, "Português", "Estrutura e Formação das Palavras", 2));
    cont_Languages.Add(new Content(1, "Português", "Pronomes", 2));
    cont_Languages.Add(new Content(1, "Português", "Conjunções", 2));
    cont_Languages.Add(new Content(1, "Português", "Interjeição", 2));
    cont_Languages.Add(new Content(1, "Português", "Sujeito e Predicado", 2));
    cont_Languages.Add(new Content(1, "Português", "Adjunto Adnominal/Adverbial/ Aposto e Vocativo", 2));
    cont_Languages.Add(new Content(1, "Português", "Orações Coordenadas", 2));
    cont_Languages.Add(new Content(1, "Português", "Orações Subordinadas", 2));
    cont_Languages.Add(new Content(1, "Português", "Pontuação", 2));
    cont_Languages.Add(new Content(1, "Português", "Figuras de Linguagem", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Classicismo", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Quinhentismo", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Barroco", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Arcadismo", 2));
    cont_Languages.Add(new Content(2, "Literatura", "Romantismo no Brasil", 2));
  }
}
