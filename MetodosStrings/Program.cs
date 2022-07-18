// See https://aka.ms/new-console-template for more information

//String normal
string ClassTopic = "Metodos de Strings";
string School = "Platzi";

//Clone
string SchoolClone = School.Clone().ToString();

//Split
string student = "Laura Valentina Bernate Gordillo";
string[] subs = student.Split(' ');


Console.WriteLine("*----------- 1 String normal: --------------*");
Console.WriteLine("Estoy aprendiendo " + ClassTopic + " en " + School + ".");
Console.WriteLine();

Console.WriteLine("*-------------- 2 Clone() ------------------*");
Console.WriteLine("Se hace un clon de la palabra Platzi: " + SchoolClone);
Console.WriteLine();

Console.WriteLine("*---- 3 CompareTo() True = 0, False = 1 ----*");
Console.WriteLine("Compara ´Metodos de Platzi´ con ´Platzi´ Resultado es : " + ClassTopic.CompareTo(School));
Console.WriteLine("Compara ´Platzi´ con el con de ´Platzi´ Resultado es : " + School.CompareTo(SchoolClone));
Console.WriteLine();

Console.WriteLine("                 4 Contains()                ");
Console.WriteLine("Retorna true si el string contiene los caracteres: ");
Console.WriteLine("La string School = Platzi contiene la palabra Pla : " + School.Contains("Pla"));
Console.WriteLine("La string School = Platzi contiene la palabra Ga : " + School.Contains("Ga"));
Console.WriteLine();

Console.WriteLine("         5 EndWith() - 6 StartsWith()        ");
Console.WriteLine("Platzi termina con zi: " + School.EndsWith("zi"));
Console.WriteLine("Platzi empieza con Pl: " + School.StartsWith("Pl"));
Console.WriteLine("Platzi empieza con Ga: " + School.StartsWith("Ga"));
Console.WriteLine();

Console.WriteLine("                 7 IndexOf                   ");
Console.WriteLine("La posicion dentro del string en el caracter Platzi es : " + School.IndexOf("a"));
Console.WriteLine();

Console.WriteLine("             8 ToLower() - ToUpper()         ");
Console.WriteLine("Letras en minusculas : " + ClassTopic.ToLower());
Console.WriteLine("Letras en mayusculas : " + ClassTopic.ToUpper());
Console.WriteLine();

Console.WriteLine("                 9 Insert()                  ");
Console.WriteLine(School.Insert(6, " Es una educación virtual "));
Console.WriteLine();

Console.WriteLine("                 13 Slipt()                  ");
Console.WriteLine("Nombre del estudiante = " + student);
foreach (var sub in subs)
{
    Console.WriteLine($"Substring: {sub}");
}
//tratar de imprimir solo el laura y bernate en el split






