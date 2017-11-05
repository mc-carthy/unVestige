using UnityEngine;

public class PlayerInput : MonoBehaviour 
{
    private float h;
    private float v;

    private bool inputEnabled = true;
    public bool InputEnabled 
    { 
        get { return inputEnabled; } 
        set { inputEnabled = value; }
    }

    public Vector2 GetKeyInput()
    {
        if (inputEnabled)
        {
            h = Input.GetAxisRaw("Horizontal");
            v = Input.GetAxisRaw("Vertical");
            return new Vector2(h, v).normalized;
        }
        else
        {
            return Vector2.zero;
        }
    }
}