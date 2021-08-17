using System.Collections.Generic;
using UnityEngine;


public class SnakeMovement : MonoBehaviour
{
    private Vector2 direction = Vector2.right;
    private float speed = 1f;
    private List<Transform> segments = new List<Transform>();
    
    public Transform segmentPrefab;
    public int initialSize = 3;


    private void Start()
    {
        ResetState();

    }

    private void Update()
    {
        Move();
    }

    private void FixedUpdate()
    {
        for(int i = segments.Count - 1; i > 0; i--)
        {
            segments[i].position = segments[i - 1].position;
        }

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

    private void Grow()
    {
        Transform seg = Instantiate(this.segmentPrefab);
        seg.position = segments[segments.Count - 1].position;
        segments.Add(seg);
    }

    private void ResetState()
    {
        for(int i = 1; i < segments.Count; i++)
        {
            Destroy(segments[i].gameObject);
        }

  
        segments.Clear();
        segments.Add(this.transform);

        for (int i = 1; i < this.initialSize; i++)
        {
            segments.Add(Instantiate(this.segmentPrefab));
        }

        this.transform.position = Vector3.zero;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Food")
        {
            Grow();
        }
        else if (other.tag == "Obstacle")
        {
            ResetState();
        }
    }
}
