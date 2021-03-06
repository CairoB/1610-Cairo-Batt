using UnityEngine;

public class UserInput : MonoBehaviour
{
    public float speed = 3f;
    public float jumpForce = 5f;
    public Rigidbody2D rigidbodyObj;

    private Vector2 direction;

    private void Update()
    {
        direction.x = speed * Input.GetAxis("Horizontal");

        if (Input.GetButtonDown("Jump"))
        {
            direction.y = jumpForce;
        }

        rigidbodyObj.AddForce(direction, ForceMode2D.Impulse);
    }
}