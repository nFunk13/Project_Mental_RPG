using UnityEngine;

public class PMovement : PlayerManager
{
    PlayerInputs playerInputs;

    private Vector2 movement;
    private Rigidbody2D rb;

    const int MOVEMENT_SPEED = 5;

    private void Awake()
    {
        playerInputs = new PlayerInputs();
        rb = GetComponent<Rigidbody2D>();

        playerInputs.PlayerMovement.Moving.performed += ctx => movement = ctx.ReadValue<Vector2>();
        playerInputs.PlayerMovement.Moving.canceled += ctx => movement = Vector2.zero;
    }

    private void MovePlayer()
    {
        rb.linearVelocity = movement * MOVEMENT_SPEED;
    }

    public override void FixedTick()
    {
        MovePlayer();
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
