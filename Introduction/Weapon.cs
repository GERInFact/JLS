namespace Introduction;

class Weapon : Item
{
    public void ModifyStats(Stats statsToModify)
    {
        if (statsToModify == null) return;
        
        statsToModify.HealthModifier += this.Stats.HealthModifier;
        statsToModify.ManaModifier += this.Stats.ManaModifier;
        statsToModify.StaminaModifier += this.Stats.StaminaModifier;
        statsToModify.SpeedModifier += this.Stats.SpeedModifier;
        statsToModify.StrengthModifier += this.Stats.StrengthModifier;
    }
}