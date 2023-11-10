namespace AccessDenied
{
    public class Persona
    {
        public string? Nome { get; set; }
        public string? Cognome { get; set; }

        public Persona(string? nome, string? cognome)
        {
            this.Nome = nome;
            this.Cognome = cognome;
        }

        /*
         * private: possiamo accedere a metodi o variabili solo all'interno della classe stessa o richiamando il metodo:
         * o tramite getter e setter
         * o richiamando il metodo privato attraverso un metodo publico 
         */

        public void Saluta()
        {
            Console.WriteLine($"{Nome} {Cognome} sta salutando");
            this.Digita(); //guardare output di classe Program
        }

        protected void Sorridi()
        {
            Console.WriteLine($"{Nome} {Cognome} sta sorridendo");
        }

        private void Digita()
        {
            Console.WriteLine($"{Nome} {Cognome} sta digitando");
        }

        internal void Camminare()
        {
            Console.WriteLine($"{Nome} {Cognome} sta camminando");
            
        }


        
    }
}
