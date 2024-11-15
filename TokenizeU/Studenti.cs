using System;
namespace Tokenizeu
{
    public class Student
{
    public string Nume { get; set; }
    public string Prenume { get; set; } 
    public string Facultate { get; set; }
    public int NumarMatricol { get; set; }

    public NoteSesiune Note { get; set; }
    public ImplicareStudent Voluntariat { get; set; }
    public Practica Practica { get; set; }
    public ParticipareConcursuri Concursuri { get; set; }
    public PremiiObtinute Premii { get; set; }

    public Student(string nume, string prenume, string facultate, int numarmatricol, 
                    NoteSesiune note, ImplicareStudent voluntariat, 
                    Practica practica, ParticipareConcursuri concursuri, 
                    PremiiObtinute premii)
    {
        Nume = nume;
        Prenume = prenume;
        Facultate = facultate;
        NumarMatricol = numarmatricol;
        Note = note;
        Voluntariat = voluntariat;
        Practica = practica;
        Concursuri = concursuri;
        Premii = premii;

    }

    public double CalculeazaPunctajNote() => Note.CalculeazaPunctajTotalNote(); 
    public double CalculeazaPunctajVoluntariat() => Voluntariat.CalculeazaPunctajVoluntariat();
    public double CalculeazaPunctajPractica() => Practica.CalculeazaPunctajPractica();
    public double CalculeazaPunctajConcursuri() => Concursuri.CalculeazaPunctajConcursuri();
    public double CalculeazaPunctajPremii() => Premii.CalculeazaPunctajPremii();

    public double CalculeazaPunctajTotal()
    {
        double PunctajTotal =
        CalculeazaPunctajNote() +
        CalculeazaPunctajVoluntariat() +
        CalculeazaPunctajPractica() +
        CalculeazaPunctajConcursuri() +
        CalculeazaPunctajPremii();
        return PunctajTotal;
    }


    public void AfiseazaDetaliiStudent()
    {
        Console.WriteLine($"Numar Matricol {NumarMatricol}");
        Console.WriteLine($"Nume: {Nume} {Prenume}");
        Console.WriteLine($"Facultate: {Facultate}");
        Console.WriteLine("\n--- Punctaje ---");
        Console.WriteLine($"Punctaj Note: {CalculeazaPunctajNote()}");
        Console.WriteLine($"Punctaj Voluntariat: {CalculeazaPunctajVoluntariat()}");
        Console.WriteLine($"Punctaj Practica: {CalculeazaPunctajPractica()}");
        Console.WriteLine($"Punctaj Concursuri: {CalculeazaPunctajConcursuri()}");
        Console.WriteLine($"Punctaj Premii: {CalculeazaPunctajPremii()}");
        Console.WriteLine($"Punctaj Total: {CalculeazaPunctajTotal()}");
    }
}

}