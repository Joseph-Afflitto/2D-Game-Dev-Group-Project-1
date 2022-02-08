using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float MovementSpeed = 5;
    public float JumpForce = 5;
    private Rigidbody2D _rigidbody;

    // Start is called before the first frame update
   private void Start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
   private void Update()
    {
        var movement = Input.GetAxis("Horizontal");
        transform.position += new Vector3(movement, 0, 0) * Time.deltaTime * MovementSpeed;

        if (Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f)
        {
            _rigidbody.AddForce(new Vector2(0, JumpForce), ForceMode2D.Impulse);
        }




    }
}
