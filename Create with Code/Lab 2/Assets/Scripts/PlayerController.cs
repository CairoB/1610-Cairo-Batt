using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class PlayerController : MonoBehaviour
{

    public Vector3 north;
    public Vector3 east;
    public Vector3 south;
    public Vector3 west;
    public float speed = 5;
    public Vector3 direction;
    public bool isOnGround;
    public bool gameOver;
    public Rigidbody playerRb;
    public float jumpForce = 100;
    public float gravityModifier = 3;

    // Start is called before the first frame update
    void Start()
    {
        north.Set(0,0,1);
        east.Set(1,0,0);
        south.Set(0,0,-1);
        west.Set(-1,0,0);

        playerRb = GetComponent<Rigidbody>();
        Physics.gravity *= gravityModifier;
    }

    // Update is called once per frame
    void Update()
    {
        direction.Set(0,0,0);
        if (Input.GetKey(KeyCode.W) && !gameOver)
        {
            direction.z = 1;
        }
        if (Input.GetKey(KeyCode.D) && !gameOver)
        {
            direction.x = 1;
        }
        if (Input.GetKey(KeyCode.S) && !gameOver)
        {
            direction.z = -1;
        }
        if (Input.GetKey(KeyCode.A) && !gameOver)
        {
            direction.x = -1;
        }
        direction.Normalize();
        transform.Translate(direction * speed * Time.deltaTime);
        if (transform.position.y < 0)
        {
            transform.Translate(Vector3.up);
        }

        
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) {
            playerRb.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isOnGround = false;
        }
    }
    
    private void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.CompareTag("Ground") && !gameOver) {
            isOnGround = true;
        }
    }

    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Enemy") && !gameOver) {
            gameOver = true;
        }
    }
}
