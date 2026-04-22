using UnityEngine;

public class Ball : MonoBehaviour
{
    public GameManager gameManager;
    public Rigidbody2D rb2d;
    public float maxInitialAngle = 0.50f;
    public float moveSpeed = 5f;
    private float startX = 0f;
    public float maxStartY = 4f;
    public float speedMultiplier = 1.01f;

    private void Start()
    {
        InitialPush();
    }

    // This handles the physics launch
    private void InitialPush()
    {
        Vector2 dir = Vector2.left;
        if (Random.value < 0.5f)
        {
            dir = Vector2.right;
        }

        dir.y = Random.Range(-maxInitialAngle, maxInitialAngle);
        rb2d.linearVelocity = dir.normalized * moveSpeed;
    }

    public void ResetBall()
    {
        // 1. Stop all movement immediately
        rb2d.linearVelocity = Vector2.zero;

        // 2. Teleport back to center
        float posY = Random.Range(-maxStartY, maxStartY);
        transform.position = new Vector2(startX, posY);

        // 3. Wait 0.25, then call InitialPush to launch the ball
        // nameof(InitialPush) is safer than typing "InitialPush" as a string
        Invoke(nameof(InitialPush), 0.25f);
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.GetComponent<ScoreZone>())
        {
            gameManager.OnScoreZoneReached(collision.GetComponent<ScoreZone>().id);
            Debug.Log("Scored!");
            ResetBall();
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Paddle paddle = collision.gameObject.GetComponent<Paddle>();
        if (paddle)
        {
            rb2d.linearVelocity *= speedMultiplier;
        }
    }
} 
