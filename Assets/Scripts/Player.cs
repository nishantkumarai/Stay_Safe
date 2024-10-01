using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerSpeed;
    private Rigidbody2D rb;
    private Vector2 playerDirection;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        // Get the input for vertical movement
        float directionY = Input.GetAxisRaw("Vertical");
        // Create a vector for movement direction
        playerDirection = new Vector2(0, directionY).normalized;
    }

    void FixedUpdate()
    {
        // Move the player using velocity
        rb.linearVelocity = new Vector2(0, playerDirection.y * playerSpeed);
    }
}
