using System.Collections.Generic;
using UnityEngine;

public class SnakeMovement : MonoBehaviour
{
    private Vector2 direction = Vector2.right;
    private float speed = 1f;
    private List<Transform> segments;

    private void Start()
    {
        segments = new List<Transform>();
        segments.Add(this.transform);
    }

    private void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        this.transform.position = new Vector3(
            Mathf.Round(this.transform.position.x) + direction.x * speed,
            Mathf.Round(this.transform.position.y) + direction.y * speed,
            0.0f
            );

    }

    private void Move()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            direction = Vector2.up;
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            direction = Vector2.down;
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            direction = Vector2.left;
        }
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            direction = Vector2.right;
        }
    }
}
