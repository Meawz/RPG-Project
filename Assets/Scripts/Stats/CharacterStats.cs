using UnityEngine;

public class CharacterStats : MonoBehaviour
{
    public int maxHealth = 100;
    public int currentHealth {  get; private set; }


    public Stat damage;
    public Stat armor;

    public HealthBar healthBar;
    void Awake()
    {
        currentHealth = maxHealth;
        healthBar.SetMaxHealth(maxHealth);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.T))
        {
            TakeDamage(10);
        }
    }

    public void TakeDamage (int damage)
    {

        damage -= armor.GetValue();
        damage = Mathf.Clamp(damage, 0, int.MaxValue);

        currentHealth -= damage;
        Debug.Log(transform.name + " takes " + damage + " damage ");

        if (currentHealth < 0)
        {
            Die();
        }

        healthBar.SetHealth(currentHealth);

    }

    public void Heal(int amount)
    {
        currentHealth += amount;
        currentHealth = Mathf.Clamp(currentHealth, 0, int.MaxValue);
        healthBar.SetHealth(currentHealth);
        Debug.Log(transform.name + " healed for " + amount + " health");
    }

    public virtual void Die()
    {
        // Die
        // This method is meant to be overwritten
        Debug.Log(transform.name + " died.");
    }

}
