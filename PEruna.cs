using UnityEngine;

public class Character2dController : MonoBehaviour
{
    public float MovementSpeed = 1;
    public float JumpForce = 1;

    private Rigidbody2D _rigidbody;

    private void start()
    {
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    private void Update()
    {
        var movement = input.GetAxis("Horizontal");
        transform.position += new Vector3(movement,0,0) * Time.delta * MovementSpeed;

        if (input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y)z0.001f)
        {
            _rigidbody.AddForce(new vector2(0, jumpForce)); ForceMode 2d.Impulse);
        }
    }
}