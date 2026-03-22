using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    [SerializeField] protected string interactionPrompt = "Interactible";
    [SerializeField] protected float interactRanage = 2f;

    virtual public bool CanInteract()
    {
        return true;
    }

    public abstract void Interact();

    public virtual string GetPrompt()
    {
        return interactionPrompt;
    }

    public abstract void OnInteractStart();

    public abstract void OnInteractEnd();
}
