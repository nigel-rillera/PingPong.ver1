using UnityEngine;

public class Paddle : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public Rigidbody2D rigidBody2D;
    public float id;
    public float moveSpeed = 2f;


    private void Update()
    {
        float movement = ProcessInput();
        Move(movement);
    }

    private float ProcessInput()
    {
        float movement = 0f;
        switch (id)
        {
            case 1:
                movement = Input.GetAxisRaw("MovePlayer1");
                break;
            case 2:
                movement = Input.GetAxisRaw("MovePlayer2");
                break;
        }

        return movement;
    }

    private void Move(float movement)
    {
       Vector2 velocity = rigidBody2D.linearVelocity;
       velocity.y = movement * moveSpeed;
       rigidBody2D.linearVelocity = velocity;
    }
}
