using static System.Console;

namespace Packt.Shared
{
    public class DvdPlayer : IPlayable
    {
        public void pause(){
            WriteLine("DVD is pausing");
        }

        public void play()
        {
            WriteLine("DVS is playing");
        }
    }
}