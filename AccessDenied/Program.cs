using AccessDenied;

Persona studente = new Studente("Marco", "Rossi");


/*
 * Da una classe non correlata, possiamo accedere ai metodi dichiarati public e internal
 * 
 * public: possiamo accedere a metodi o variabili da qualsiasi parte del software
 * 
 * internal: possiamo accedere a metodi o variabili da qualsiasi parte dell'assembly
 * 
 * private: possiamo accedere a metodi o variabili solo all'interno della classe stessa o richiamando il metodo:
 * o tramite getter e setter
 * o richiamando il metodo privato attraverso un metodo publico 
 * 
 * protected: possiamo accederea metodi o variabili all'interno della stessa classe o di una sottoClasse
 */

studente.Saluta(); //public che richiama un metodo private
studente.Camminare(); //internal

