using System;
using UnityEngine;

public class PHealth : PlayerManager
{
    [SerializeField] int maxHealth = 10;

    public event Action healthChanged;

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

    public void OnDamage(int damage)
    {
        currentHealth -= damage;
    }
}
