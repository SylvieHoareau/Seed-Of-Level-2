using UnityEngine;

public class PlayerMovementIsometric : MonoBehaviour
{
    public float moveSpeed = 5f;
    private Rigidbody2D rb;

    private float moveX;
    private float moveY;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Désactive la gravité
        rb.gravityScale = 0;
    }

    void Update()
    {
        // Récupère les entrées clavier
        moveX = Input.GetAxisRaw("Horizontal");
        moveY = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        // Calcul du vecteur de déplacement
        Vector2 movement = new Vector2(moveX, moveY).normalized * moveSpeed;

        // Applique le déplacement au Rigidbody2D
        rb.linearVelocity = movement;
    }
}
