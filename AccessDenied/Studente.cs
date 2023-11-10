namespace AccessDenied
{
    public class Studente : Persona
    {
        public Studente(string? nome, string? cognome) : base(nome, cognome)
        {
        }

        /* 
         * protected: possiamo accederea metodi o variabili all'interno della stessa classe o di una sottoClasse
         */

        public void Leggere()
        {
            base.Sorridi();//metodo protected richiamato
        }
    }
}
