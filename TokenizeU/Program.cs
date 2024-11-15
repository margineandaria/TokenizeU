using System;
using System.Collections.Generic;

namespace Tokenizeu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> studenti = new List<Student>();
            string adaugaAltStudent;

            do
            {
                Console.WriteLine("Introduceti informatiile studentului:");

                Console.Write("Nume: ");
                string nume = Console.ReadLine();

                Console.Write("Prenume: ");
                string prenume = Console.ReadLine();

                Console.Write("Facultate: ");
                string facultate = Console.ReadLine();

                Console.Write("Numar Matricol ");
                int id = int.Parse(Console.ReadLine());

                List<Nota> note = new List<Nota>();
                Console.WriteLine("Introduceti numarul de note:");
                int numarNote = int.Parse(Console.ReadLine());

                for (int i = 0; i < numarNote; i++)
                {
                    double nota;
                    int incercare;

                    while (true)
                    {
                        Console.Write($"Nota la materia {i + 1} (1 - 10): ");
                        bool isValid = double.TryParse(Console.ReadLine(), out nota);
                        if (isValid && nota >= 1 && nota <= 10)
                        {
                            Console.Write($"Numarul incercarii pentru nota {i + 1}: ");
                            bool isValidIncercare = int.TryParse(Console.ReadLine(), out incercare);
                            if (isValidIncercare && incercare >= 1)
                            {
                                note.Add(new Nota(nota, incercare));
                                break;
                            }
                            else
                            {
                                Console.WriteLine("incercarea trebuie să fie un numar pozitiv.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Nota invalida! Vă rugăm sa introduceti o valoare intre 1 și 10.");
                        }
                    }
                }

                Console.Write("Numarul incercarii: ");
                int numarIncercari = int.Parse(Console.ReadLine());

                NoteSesiune noteSesiune = new NoteSesiune(note, numarIncercari);

                Console.Write("Ore voluntariat universitate: ");
                int oreVoluntariatUni = int.Parse(Console.ReadLine());

                Console.Write("Ore voluntariat societate: ");
                int oreVoluntariatSoc = int.Parse(Console.ReadLine());

                ImplicareStudent voluntariat = new ImplicareStudent(oreVoluntariatUni, oreVoluntariatSoc);

                Console.Write("Ore practica voluntara la companii: ");
                int orePracticaVoluntara = int.Parse(Console.ReadLine());

                Console.Write("Ore practica plătita la companii: ");
                int orePracticaPlatita = int.Parse(Console.ReadLine());

                Practica practica = new Practica(orePracticaVoluntara, orePracticaPlatita);

                int locOlimpiada;
                while (true)
                {
                    Console.Write("Loc in olimpiada (1, 2, 3, 4 pentru participare fară premiu sau 0 pentru neparticipant: ");
                    bool isValid = int.TryParse(Console.ReadLine(), out locOlimpiada);
                    if (isValid && (locOlimpiada == 0 || locOlimpiada == 1 || locOlimpiada == 2 || locOlimpiada == 3 || locOlimpiada == 4))
                        break;
                    else
                        Console.WriteLine("Introducere invalida! Va rugam sa introduceti 0, 1, 2, 3 sau 4.");
                }

                Console.Write("Numar de conferinte stiintifice la care a participat: ");
                int numarConferinte = int.Parse(Console.ReadLine());

                int tipArticol;
                while (true)
                {
                    Console.Write("Tip articol (1 = Prestigiu, 2 = Specialitate, 3 = Acceptat dar nepublicat, 0 = fara articol publicat: ");
                    bool isValid = int.TryParse(Console.ReadLine(), out tipArticol);
                    if (isValid && (tipArticol >= 0 && tipArticol <= 3))
                        break;
                    else
                        Console.WriteLine("Introducere invalida! Va rugam sa introduceti 0, 1, 2 sau 3.");
                }

                Console.Write("Numar de cercuri studentesti: ");
                int numarCercuri = int.Parse(Console.ReadLine());

                Console.Write("Numar de cursuri suplimentare: ");
                int numarCursuri = int.Parse(Console.ReadLine());

                ParticipareConcursuri participareConcursuri = new ParticipareConcursuri(locOlimpiada, numarConferinte, tipArticol, numarCercuri, numarCursuri);

                Console.Write("Tip premiu (1 = Concurs National, 2 = Premiu National, 3 = Premiu International): ");
                int tipPremiu = int.Parse(Console.ReadLine());
                string tipPremiuText = tipPremiu switch
                {
                    1 => "Concurs National",
                    2 => "Premiu National",
                    3 => "Premiu International",
                    4 => "Nu a Participat",
                    _ => "Necunoscut"
                };

                PremiiObtinute premii = new PremiiObtinute(tipPremiuText);

                Student student = new Student(nume, prenume, facultate, id, noteSesiune, voluntariat, practica, participareConcursuri, premii);

                studenti.Add(student);

                Console.WriteLine("Doriti sa adaugati un alt student? (da/nu)");
                adaugaAltStudent = Console.ReadLine().ToLower();

            } while (adaugaAltStudent == "da");

            Console.WriteLine("\nLista studentilor si punctajele acestora:");
            foreach (var student in studenti)
            {
                student.AfiseazaDetaliiStudent();
                double NumarTokenuri;
                double PunctajTotal = student.CalculeazaPunctajTotal();
                NumarTokenuri = 0.05 * PunctajTotal;
                Console.WriteLine($"Numarul de Tokenuri pe baza scorului este {NumarTokenuri}");
                Console.WriteLine("--------------------");
            }
        }
    }
}
