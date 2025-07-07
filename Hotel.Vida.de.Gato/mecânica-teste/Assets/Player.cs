using UnityEngine;

public class Player : MonoBehaviour
{
    public float moveSpeed = 5f; // Velocidade de movimento
    private Rigidbody2D rb;
    private Vector2 moveInput;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Coletar entrada do jogador
        moveInput.x = Input.GetAxisRaw("Horizontal"); // A/D ou ←/→
        moveInput.y = Input.GetAxisRaw("Vertical");   // W/S ou ↑/↓
        moveInput.Normalize(); // Para não andar mais rápido na diagonal
    }

    void FixedUpdate()
    {
        // Mover o player
        rb.MovePosition(rb.position + moveInput * moveSpeed * Time.fixedDeltaTime);
    }
}