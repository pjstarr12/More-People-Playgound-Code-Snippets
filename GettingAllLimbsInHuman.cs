foreach (LimbBehaviour Limb in PersonBehaviour.Limbs) //make sure PersonBehaviour is the PersonBehaviour of your human (duh)
{
    //if you need the GameObject, then do this:
    Limb.gameObject
    //you can set all different things in LimbBehaviour (a Component [script] in the limb)
    Limb.Health = 100000f;
    Limb.BreakingThreshold = 1900909857f;
}
