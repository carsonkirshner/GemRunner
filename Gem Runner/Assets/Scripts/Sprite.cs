using UnityEngine;

public class Sprite : MonoBehaviour
{
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float jumpForce = 10f;
    private Rigidbody2D rb;


    // start
    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // update
    void Update()
    {
        MovePlayer();
        Jump();
    }

    void MovePlayer()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(horizontalInput, verticalInput, 0f);
        transform.Translate(movement * moveSpeed * Time.deltaTime);
    }

    // figure out why only space bar works to jump
    void Jump()
    {
        if (Input.GetButtonDown("Jump") || Input.GetButtonDown("Vertical"))
        {
            rb.velocity = new Vector2(rb.velocity.x, 0f);
            rb.AddForce(Vector2.up * jumpForce, ForceMode2D.Impulse);
        }
    }
}
