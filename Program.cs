using tetofo.EventBus.Impl;
using tetofo.Stem;
using tetofo.Stem.Impl;

namespace tetofo;

public static class Program
{
    public static void Main(string[] args)
    {
        using IStem stem = new ConsoleReaderStem();
        stem.Event(new StartReadingConsoleEvent());
    }
}