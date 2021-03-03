using UnityEngine;

public class CharacterMover : MonoBehaviour
{
    public CharacterController controller;
    public Vector3 movement;
    public float speed = 3f, gravity = -8f;

    void Update()
    {
        movement.y = gravity;
        movement.x = speed * IInput.GetAxis("Horizontal");
        controller.Move(motion:movement * Time.deltaTime);
    }
}