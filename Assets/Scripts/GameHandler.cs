using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject snakeheadGameObject = new GameObject();
        SpriteRenderer snakeSpriteRenderer = snakeheadGameObject.AddComponent<SpriteRenderer>();
        snakeSpriteRenderer.sprite = GameAssets.i.snakeHeadSrite;

    }
}
