using UnityEngine;

public class PlayerManager : MonoBehaviour 
{
    private PlayerInput input;
    private PlayerMovement movement;

    private void Awake()
    {
        input = GetComponent<PlayerInput>();
        movement = GetComponent<PlayerMovement>();
    }

    private void FixedUpdate()
    {
        Move();
    }

    private void Move()
    {
        movement.Move(input.GetKeyInput());
    }
}
