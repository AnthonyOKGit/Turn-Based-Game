using UnityEngine;

public class playerData : MonoBehaviour
{
    // Attached to a player object that holds all the data for the player
    // Is a singleton so that there is only one instance of the player data
    // Effectively only a container for player data (should have very little logic)

    // Is not destroyed on load so that the data persists between scenes (as long as there is only one player object)
    // Holds information such as health, money, energy and inventory

    public static playerData instance;
    public int maxHealth = 10;
    public int currentHealth = 10;
    public int baseEnergy = 3;
    public int currentEnergy = 3;
    public int money = 0;

    // List of actions the player can use during combat
    [SerializeField] public action[] attackInventory;

    private void Awake()
    {
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
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

    public void UseEnergy(int amount)
    {
        currentEnergy -= amount;
        if (currentEnergy < 0)
        {
            currentEnergy = 0;
        }
    }

    public void AddEnergy(int amount)
    {
        currentEnergy += amount;
    }
    

    public void AddMoney(int amount)
    {
        money += amount;
    }

    public bool SpendMoney(int amount)
    {
        if (money >= amount)
        {
            money -= amount;
            return true;
        }
        return false;
    }

}
