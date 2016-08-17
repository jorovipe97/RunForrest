using System;


class Mapa
{
    public int[] casillas = new int[1000000];
    static Random random = new Random();

    public Mapa()
    {
        for (int i = 0; i < casillas.Length; i++)
        {
            casillas[i] = random.Next(-10, 5);
        }
    }
}