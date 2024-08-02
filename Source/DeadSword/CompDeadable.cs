using Verse;

namespace DS
{
    public class CompDeadable : ThingComp
    {
        private CompProperties_Dead Props => (CompProperties_Dead)this.props;

        public override void Notify_KilledPawn(Pawn pawn)
        {
            base.Notify_KilledPawn(pawn);
            GasUtility.AddDeadifeGas(pawn.Position, pawn.Map, pawn.Faction, this.Props.amount);
        }
    }
}