using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main()
    {

        Jugador j1 = new Jugador(5); // Se pasa por parametro la suerte
        Jugador j2 = new Jugador(5);
        Jugador j3 = new Jugador(5);

        Mapa mapa = new Mapa();
        int golpe = 0;
        while (j1.salud + j2.salud + j3.salud > 0)
        {

            if (j1.salud > 0)
            {
                j1.Jugar();
                golpe = mapa.casillas[j1.casilla];
                j1.Golpeado(golpe);
                Console.BackgroundColor = ConsoleColor.White;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("J1 | Salud: " + j1.salud + " | Posicion: " + j1.casilla);
                Console.ResetColor();
            }

            if (j2.salud > 0)
            {
                j2.Jugar();
                golpe = mapa.casillas[j1.casilla];
                j2.Golpeado(golpe);
                Console.BackgroundColor = ConsoleColor.Yellow;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("J2 | Salud: " + j2.salud + " | Posicion: " + j2.casilla);
                Console.ResetColor();
            }

            if (j3.salud > 0)
            {
                j3.Jugar();
                golpe = mapa.casillas[j1.casilla];
                j3.Golpeado(golpe);
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("J3 | Salud: " + j3.salud + " | Posicion: " + j3.casilla);
                Console.ResetColor();
            }
        }

        Console.WriteLine("J1: " + j1.casilla + "| J2: " + j2.casilla + "| J3: " + j3.casilla);

        Console.ReadLine();
    }
}


