using System;

public class Jugador
{
    public int casilla; // Numero de la casilla actual
    public int suerte;
    public int salud;

    // Generador de numeros aleatorios de la clase
    static Random random = new Random();

    public Jugador(int suerte)
    {
        // Posicion inicial del jugador
        this.casilla = 0;

        // Definiendo la suerte del jugador
        if (suerte < 1)
            this.suerte = 1;
        else if (suerte > 19)
            this.suerte = 19;
        else
            this.suerte = suerte;

        // Definiendo la salud del jugador
        this.salud = (20 - this.suerte) * 100;
    }

    public void Jugar()
    {
        this.casilla += random.Next(1, this.suerte);
    }

    public void Golpeado(int golpe)
    {
        // Si muere salir        
        if (this.salud <= 0)
            return;

        this.salud += golpe; // Numero "random" entre [-10, 4]
    }

}
