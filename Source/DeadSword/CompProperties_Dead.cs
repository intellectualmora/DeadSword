using Verse;

namespace DS
{
    public class CompProperties_Dead : CompProperties
    {
        public int amount;

        public CompProperties_Dead() => this.compClass = typeof(CompDeadable);
    }
}