using System;
namespace Tokenizeu 
{
    public class Universitate
    {
        public Student Student { get; set; }

        public Universitate(Student student)
        {
            Student = student;
        }

        public void AfiseazaPunctajTotal()
        {
            Student.AfiseazaDetaliiStudent();
        }
    }
}