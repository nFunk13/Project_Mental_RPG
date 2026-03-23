using UnityEngine;

public class DamageItemTest : Interactable
{
    int damage = 2;
    [SerializeField] private PHealth playerHealth;

    public override void Interact()
    {
        //throw new System.NotImplementedException();
        playerHealth.OnDamage(damage);
        Destroy(gameObject);
    }

    public override void OnInteractStart()
    {
        
    }

    public override void OnInteractEnd()
    {
        
    }

    public void OnEnable()
    {
        playerHealth.healthChanged += Interact;
    }

    public void OnDisable()
    {
        playerHealth.healthChanged -= Interact;
    }
}
