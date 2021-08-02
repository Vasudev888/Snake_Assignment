using UnityEngine;

public class FoodSpawner : MonoBehaviour
{
    public BoxCollider2D greidAread;

    private void RandomizePosition()
    {
        Bounds bounds = this.greidAread.bounds;
        float x = Random.Range(bounds.min.x, bounds.max.x);
        float y = Random.Range(bounds.min.y, bounds.max.y);

        this.transform.position = new Vector3
    }
}
