using UnityEngine;

public class PInteraction : PlayerManager
{
    private float interactionRange = 2.5f;

    [SerializeField] private LayerMask interactibleLayer;
    private Interactable currentInteractable;

    private PlayerInputs playerInputs;

    private void Awake()
    {
        playerInputs = new PlayerInputs();

        playerInputs.Interaction.Interacting.performed += empty => TryInteraction();
    }

    public override void Tick()
    {
        CollectItemsInRadius();
    }

    private void CollectItemsInRadius()
    {
        Collider2D[] collider = Physics2D.OverlapCircleAll(transform.position, interactionRange, interactibleLayer);

        Interactable closestInteractable = null;
        float closestDistance = float.MaxValue;

        foreach (Collider2D col in collider)
        {
            if (col.TryGetComponent<Interactable>(out Interactable interactible))
            {
                float distance = Vector2.Distance(transform.position, col.transform.position);

                if (distance < closestDistance)
                {
                    closestInteractable = interactible;
                    closestDistance = distance;
                }
            }
        }

        currentInteractable = closestInteractable;

        Debug.Log("current closest Interactible: " + currentInteractable);
    }

    private void TryInteraction()
    {
        Debug.Log("INTERACTING");
        currentInteractable.Interact();
    }

    private void OnEnable()
    {
        playerInputs.Enable();
    }

    private void OnDisable()
    {
        playerInputs.Disable();
    }
}
