using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
[RequireComponent(typeof(Collider2D))]
public class PlayerMovement : MonoBehaviour 
{
    public float speed;

    private Rigidbody2D rb;
    private Collider2D col;

    private void Awake()
    {
        rb = GetComponent<Rigidbody2D>();
        col = GetComponent<Collider2D>();
    }

    public void Move(Vector2 dir)
    {
        rb.MovePosition((Vector2)rb.transform.position + (dir * SpeedInUnitsPerSecond()));
    }

    private float SpeedInUnitsPerSecond()
    {
        return speed * Time.fixedDeltaTime;
    }
}
