using System.Collections.Generic;
using RimWorld; 
using Verse;

namespace Rosen_Deranged
{
    public class Hediff_ProcyonLotor: Hediff
    {
        public override void Notify_PawnKilled()
        {
            var names = new List<string>();
            names.Add("Steve");
            names.Add("Mr Fluffles");
            names.Add("Murderbot 9000");
            GenList.Shuffle<string>(names);
            Log.Message("Test\t" +  names[0]);
            for (int i = 0; i < 3; i++)
            {
                Pawn raccoon = PawnGenerator.GeneratePawn(PawnKindDef.Named("Raccoon"));
                raccoon.Name = new NameSingle(names[i]);
                GenSpawn.Spawn(raccoon, CellFinder.StandableCellNear(pawn.Position, pawn.Map, 2f), pawn.Map);
            }
            
            
        }
    }
}