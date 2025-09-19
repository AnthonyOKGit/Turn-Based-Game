using UnityEngine;

[CreateAssetMenu(fileName = "enemyAction", menuName = "Scriptable Objects/enemyAction")]
public class enemyAction : ScriptableObject
{
    // Simpler than player actions as enemies have no cost or cooldowns
    public string actionName;
    public string description; // A brief description of the action
    public FullAction[] fullActions;
    
}
