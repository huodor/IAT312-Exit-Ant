using UnityEngine;

public class Player : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    private Animator animator;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //MOVEMENTS
        float moveInput = Input.GetAxis("Horizontal");
        rb.linearVelocity = new Vector2(moveInput * speed, rb.linearVelocity.y);

        //FLIP SPRITE
        if (moveInput > 0.01f)
            transform.localScale = new Vector3(7,7,7);
        else if (moveInput < -0.01f)
            transform.localScale = new Vector3(-1,1,1) * 7;

        //SET ANIMATOR PARAMETERS
        animator.SetBool("isRunning", moveInput != 0);
    }
}
