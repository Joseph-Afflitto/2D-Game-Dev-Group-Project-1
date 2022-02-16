using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 5;
    public float JumpForce = 5;
    private Rigidbody2D _rigidbody;
    public bool gameOver;
    public GameObject GameOverMenu;
    private Animator PlayerAnim;
    public float horizontalInput;
    public bool isOnGround = true;

    // Start is called before the first frame update
    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
        PlayerAnim = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        transform.Translate(Vector2.right * horizontalInput * Time.deltaTime * MovementSpeed);
        PlayerAnim.SetFloat("Moving", Mathf.Abs(horizontalInput));
        if (horizontalInput > 0)
        {
            transform.localScale = new Vector3((float)0.2, (float)0.2, (float)0.2);
        }
        else if (horizontalInput < 0)
        {
            transform.localScale = new Vector3((float)-0.2, (float)0.2, (float)0.2);
        }
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround)
        {
            _rigidbody.AddForce(Vector2.up * JumpForce, ForceMode2D.Impulse);
            isOnGround = false;
        }

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
            {
                _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
            }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Enemy"))
        {
            Debug.Log("Player touched monster. GAME OVER.");
            gameOver = true;
            GameOverMenu.SetActive(true);
            Time.timeScale = 0f;
        }

        if (collision.gameObject.CompareTag("Ground"))
        {
            isOnGround = true;
        }
    }
}
