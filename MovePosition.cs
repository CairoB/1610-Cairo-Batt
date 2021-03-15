using UnityEngine;

public class MovePosition : MonoBehaviour
{
    public float horizontalInput;
    public float speed = 3;
    private Vector3 direction = Vector3.zero;

    // private void Start()
    // {
    //     direction.Set(horizontalInput, 0, 0);
    // }

    void Update()
    {
        // horizontalInput = Input.GetAxis("Horizontal");
        // transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        direction.Set(horizontalInput * speed, 0, 0);
        transform.Translate(direction * Time.deltaTime);
    }
}