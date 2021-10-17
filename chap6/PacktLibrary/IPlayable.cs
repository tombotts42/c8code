using static System.Console;

namespace Packt.Shared
{
    public interface IPlayable
    {
        void play();

        void pause();

        void stop()
        {
            WriteLine("Default implementation of stop");
        }
    }
}
