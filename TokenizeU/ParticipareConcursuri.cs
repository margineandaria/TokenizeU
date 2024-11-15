using System;
namespace Tokenizeu
{
   public class ParticipareConcursuri
{
    public int LocOlimpiada { get; set; }
    public int NumarConferinte { get; set; }
    public int TipArticol { get; set; }
    public int NumarCercuri { get; set; }
    public int NumarCursuri { get; set; }

    public ParticipareConcursuri(int locOlimpiada, int numarConferinte, int tipArticol, int numarCercuri, int numarCursuri)
    {
        LocOlimpiada = locOlimpiada;
        NumarConferinte = numarConferinte;
        TipArticol = tipArticol;
        NumarCercuri = numarCercuri;
        NumarCursuri = numarCursuri;
    }
    public int CalculeazaPunctajConcursuri()
    {
        int punctaj = 0;
        switch (LocOlimpiada)
        {
            case 1: punctaj = 150; break; 
            case 2: punctaj = 100; break; 
            case 3: punctaj = 75; break;  
            case 4: punctaj = 35; break; 
            case 0: punctaj = 0; break; 
        }

        punctaj += NumarConferinte * 40;
        punctaj += TipArticol switch
        {
            1 => 300, 
            2 => 150,
            3 => 75,
            0 => 0,
            _ => 0
        };
        punctaj += NumarCercuri * 25;
        punctaj += NumarCursuri * 30;

        return punctaj;
    }
}
}
