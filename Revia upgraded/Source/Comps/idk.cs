using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Verse;
using RimWorld;
using ReviaRace.Helpers;
using ReviaRace.Needs;

namespace ReviaRace.Comps
{
    public class idk : ThingComp
        {
        public override void PostSpawnSetup(bool respawningAfterLoad)
                {
                    base.PostSpawnSetup(respawningAfterLoad);
                    var pawn = parent as Pawn;

                    if (pawn != null && GetSoulReapTier() == -1)
                    {
                        if (pawn.kindDef == Defs.RE_ReviaRaceVeteran ||
                            pawn.kindDef == Defs.RE_ReviaRaceMistress ||
                            pawn.kindDef == defs.RE_ReviaRaceRusher)
                        {
                            AddSoulReapTier(9);
                            pawn.skills.GetSkill(SkillDefOf.Melee).Level = 20;
                            pawn.skills.GetSkill(SkillDefOf.Shooting).Level = 20;
                            pawn.story.traits.allTraits.AddDistinct(new Trait(TraitDefOf.Tough));
                        }
                        else
                        {

                        }
                    }
                }
        }
}