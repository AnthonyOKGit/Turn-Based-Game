using System;
using UnityEngine;

[CreateAssetMenu(fileName = "action", menuName = "Scriptable Objects/action")]
public class action : ScriptableObject
{
    public string actionName;
    public int cost; // The cost to use the action (e.g., mana cost, stamina cost)
    public int cooldown; // The number of turns before the action can be used again (0 for no cooldown(can be used any time), -1 for one-time use(can only be used once per combat))
    public string description; // A brief description of the action

    // Action type and power (Multiple types can be added to the same action, e.g., an attack that also heals, or a buff that also deals damage)
    // For ease of object creation and editing, multiple types are stored in an array of FullAction that includes type and power

    public FullAction[] fullActions;

}

[Serializable]
public class FullAction
{
    public ActionType actionType; // E.g., "Attack", "Heal", "Buff", etc.
    public int power; // The strength of the action (e.g., damage for attacks, healing for heals, amount for buffs)
}

public enum ActionType
{
    Attack,
    Heal,
    Buff,
    Debuff
}
