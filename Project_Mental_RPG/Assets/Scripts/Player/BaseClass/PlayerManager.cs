using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    protected PlayerSystems playerManager;

    private void Awake()
    {
        
    }

    // Initalizes player sub classes
    public virtual void Init(PlayerSystems manager)
    {
        this.playerManager = manager;
    }

    // Call in Update()
    public virtual void Tick()
    {

    }

    // Call in FixedUpdate
    public virtual void FixedTick()
    {
        //MovePlayer();
    }

    // Call in LateUpdate
    public virtual void LateTick()
    {

    }

    

    //private void OnEnable()
    //{
    //    playerInputs.Enable();
    //}

    //private void OnDisable()
    //{
    //    playerInputs.Disable();
    //}
}
