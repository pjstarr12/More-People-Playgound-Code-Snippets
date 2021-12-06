foreach (LimbBehaviour Limb in PersonBehaviour.Limbs) //make sure PersonBehaviour is the PersonBehaviour of your human (duh)
{
    //if you need the GameObject, then do
    Limb.gameObject
    //you can set all different things in LimbBehaviour (a Component [script] in the limb)
    Limb.Health = 0f;
    Limb.BreakingThreshold = 0
}
