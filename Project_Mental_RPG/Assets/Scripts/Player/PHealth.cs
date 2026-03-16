using UnityEngine;

public class PHealth : PlayerManager
{
    [SerializeField] int maxHealth = 10;

    public int currentHealth { get; private set; }

    public override void Init(PlayerSystems manager)
    {
        base.Init(manager);
        currentHealth = maxHealth;
    }

    public override void Tick()
    {
        Debug.Log("Current health: " +  currentHealth);
    }
}
