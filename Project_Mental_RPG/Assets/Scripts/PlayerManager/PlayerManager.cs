using UnityEngine;

public class PlayerManager : MonoBehaviour
{
    PlayerInputs playerInputs;

    private Vector2 movement;
    private Rigidbody2D rb;

    private void Awake()
    {
        playerInputs = new PlayerInputs();
        rb = GetComponent<Rigidbody2D>();

        playerInputs.PlayerMovement.Moving.performed += ctx => movement = ctx.ReadValue<Vector2>();
        playerInputs.PlayerMovement.Moving.canceled += ctx => movement = Vector2.zero;
    }

    private void Update()
    {
        MovePlayer();
    }

    private void MovePlayer()
    {
        rb.linearVelocity = movement * 5;
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
