using System;
public interface IBloqueInterrogante
{
    void GenerarItem();
    void Dibujar();
}
public class GameboyBloqueInterrogante : IBloqueInterrogante
{
    public void Dibujar()
    {
        Console.WriteLine("Dibujar: Bloque interrogante de Gameboy");
    }

    public void GenerarItem()
    {
        Console.WriteLine("Generar: Bloque interrogante de Gameboy");
    }
}

public class NintendoDSBloqueInterrogante : IBloqueInterrogante
{
    public void Dibujar()
    {
        Console.WriteLine("Dibujar: Bloque interrogante de Nintendo DS");
    }

    public void GenerarItem()
    {
        Console.WriteLine("Generar: Bloque interrogante de Nintendo DS");
    }
}
