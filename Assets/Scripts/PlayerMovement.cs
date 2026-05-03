using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 500f;
    public float jumpForce = 100f;
    private Rigidbody2D rb;
    private bool isGrounded;
    
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        float movex = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2 (movex*moveSpeed,-10f);
    }
}
