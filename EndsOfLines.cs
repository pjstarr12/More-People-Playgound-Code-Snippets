//lmao C# basics

//at the end of any line that you do stuff in (EXCLUDING IF STATEMENTS AND FOREACH STATEMENTS) you gotta put a ";"
//for example, here is some code from the human tiers mod..
new Modification()
    {
        OriginalItem = ModAPI.FindSpawnable("Human"),
        NameOverride = "Slightly Improved Human " + " +HT",
        NameToOrderByOverride = "A1",
        DescriptionOverride = "A little stronger than the average human." + "\n <color=orange>[Tier 1] ",
        CategoryOverride = ModAPI.FindCategory("HT"),  //these are the options of the humans, so they use commas for some reason
        ThumbnailOverride = ModAPI.LoadSprite("textures/human1.png"),
        AfterSpawn = (Instance) =>
        {
            var person = Instance.GetComponent<PersonBehaviour>(); //there IS a ";" here because we are setting a value of something
            foreach (var body in person.Limbs)
            {
                body.BaseStrength += 2f; // ";" here too (that "f" after the number means that is a float)
                body.Health *= 1.5f; // ";" here too
                body.InitialHealth *= 1.5f; // ";" here too
                body.ShotDamageMultiplier *= 0.5f; // ";" here too
                body.BreakingThreshold += 10f; // ";" here too
                body.RegenerationSpeed += 5f; // ";" here too
                body.Vitality *= 1.5f; // ";" here too
                body.ImpactPainMultiplier *= 0.5f; // ";" here too
                body.Numbness *= 1.2f; // ";" here too (goddamn, there are a lot of floats)
            } //no ";" here
        } //no ";" here
    } //no ";" here
