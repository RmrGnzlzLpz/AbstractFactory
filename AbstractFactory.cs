public interface IAbstractFactory
{
    IMoneda CrearMoneda();
    IBloqueInterrogante CrearBloqueInterrogante();
}

public class GameboyFactory : IAbstractFactory
{
    public IBloqueInterrogante CrearBloqueInterrogante()
    {
        return new GameboyBloqueInterrogante();
    }

    public IMoneda CrearMoneda()
    {
        return new GameboyMoneda();
    }
}

public class NintendoDSFactory : IAbstractFactory
{
    public IBloqueInterrogante CrearBloqueInterrogante()
    {
        return new NintendoDSBloqueInterrogante();
    }

    public IMoneda CrearMoneda()
    {
        return new NintendoDSMoneda();
    }
}