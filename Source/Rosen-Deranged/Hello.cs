using RimWorld;
using Verse;

namespace Rosen_Deranged
{
    [StaticConstructorOnStartup]
    public static class Hello
    {
        static Hello()
        {
            for (int i = 0; i < 1000; i++)
            {
                
                Log.Message("ALL WORK AND NO PLAY MAKES JACK A DULL BOY.");
            }
        }
            
    }
}