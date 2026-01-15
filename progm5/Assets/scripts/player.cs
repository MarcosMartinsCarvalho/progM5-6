using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class player : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float jumpForce = 10f;

    public Transform groundCheck;
    public float groundCheckRadius = 0.2f;
    public LayerMask groundLayer;

    public int extraJumpsValue = 1;
    private int extraJumps;

    public int health = 100;
    public Image healthImage;

    private Rigidbody2D RB;
    private Animator animator;
    private SpriteRenderer spriteRenderer;
    private bool isGrounded;

    void Start()
    {
        RB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        extraJumps = extraJumpsValue;
    }

    void Update()
    {
        float moveInput = Input.GetAxis("Horizontal");

        RB.linearVelocity = new Vector2(moveInput * moveSpeed, RB.linearVelocity.y);

        if (isGrounded)
        {
            extraJumps = extraJumpsValue;
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isGrounded)
            {
                RB.linearVelocity = new Vector2(RB.linearVelocity.x, jumpForce);
            }
            else if (extraJumps > 0)
            {
                RB.linearVelocity = new Vector2(RB.linearVelocity.x, jumpForce);
                extraJumps--;
            }
        }

        SetAnimation(moveInput);

        healthImage.fillAmount = health / 100f;
    }

    void FixedUpdate()
    {
        isGrounded = Physics2D.OverlapCircle(
            groundCheck.position,
            groundCheckRadius,
            groundLayer
        );
    }

    void SetAnimation(float moveInput)
    {
        if (isGrounded)
        {
            if (moveInput == 0)
            {
                animator.Play("player_idle");
            }
            else
            {
                animator.Play("player_run");
            }
        }
        else
        {
            if (RB.linearVelocity.y > 0)
            {
                animator.Play("player_jump");
            }
            else
            {
                animator.Play("player_fall");
            }
        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "damage")
        {
            health -= 25;
            RB.linearVelocity = new Vector2(RB.linearVelocity.x, jumpForce);
            StartCoroutine(BlinkRed());

            if (health <= 0)
            {
                Die();
            }
        }
    }

    System.Collections.IEnumerator BlinkRed()
    {
        spriteRenderer.color = Color.red;
        yield return new WaitForSeconds(0.1f);
        spriteRenderer.color = Color.white;
    }

    void Die()
    {
        SceneManager.LoadScene("game scene");
    }
}
