using UnityEngine;

public class enemyData : MonoBehaviour
{
    // Attached to an enemy object that holds all the data for the enemy
    // Effectively only a container for enemy data (should have very little logic)

    public int maxHealth = 50;
    public int currentHealth = 50;

    private void Awake()
    {
        currentHealth = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if (currentHealth < 0)
        {
            currentHealth = 0;
        }
    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        if (currentHealth > maxHealth)
        {
            currentHealth = maxHealth;
        }
    }
}
