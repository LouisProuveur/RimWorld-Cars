using RimWorld;
using System.Collections.Generic;
using Verse;
using Verse.AI;
using UnityEngine;

namespace LP2_Cars
{
    public class CompProperties_Cars : CompProperties
    {
        public float massCapacity;

        public float restEffectiveness;

        public bool max1PerGroup;

        public bool canChangeAssignedThingsAfterStarting;

        public bool showOverallStats = true;

        public SoundDef pawnLoadedSound;

        public SoundDef pawnExitSound;

        public CompProperties_Cars()
        {
            compClass = typeof(CompTransporter);
        }

    }
}