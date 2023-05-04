using UnityEngine;

public class SnakeSimpleMovement : MonoBehaviour
{
    public float Speed = 2;

    private Rigidbody2D _rig;
    private SnakeTail componentSnakeTail;

    private void Start()
    {
        _rig = GetComponent<Rigidbody2D>();
        componentSnakeTail = GetComponent<SnakeTail>();

        componentSnakeTail.AddCircle();
        componentSnakeTail.AddCircle();
        componentSnakeTail.AddCircle();
        componentSnakeTail.AddCircle();
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rig.velocity = Vector2.up * Speed;
        }

        if (Input.GetKey(KeyCode.DownArrow))
        {
            _rig.velocity = Vector2.down * Speed;
        }

        if (Input.GetKey(KeyCode.LeftArrow))
        {
            _rig.velocity = Vector2.left * Speed;
        }

        if (Input.GetKey(KeyCode.RightArrow))
        {
            _rig.velocity = Vector2.right * Speed;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            componentSnakeTail.AddCircle();
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            componentSnakeTail.RemoveCircle();
        }
    }
}
