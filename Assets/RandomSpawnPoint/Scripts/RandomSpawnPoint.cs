using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class RandomSpawnPoint : MonoBehaviour
{
    public int dotsCount;
    public GameObject dotPrefab;
    void Start()
    {
        for (int i = 0; i < dotsCount; i++)
        {
            Vector2 screenSize = new Vector2(Camera.main.pixelWidth, Camera.main.pixelHeight);
            float randPointX = Random.Range(0, screenSize.x);
            float randPointY = Random.Range(0, screenSize.y);
            Vector2 randPoint = new Vector2(randPointX, randPointY);
            randPoint = Camera.main.ScreenToWorldPoint(randPoint);
            Instantiate(dotPrefab, randPoint, Quaternion.identity);
        }
    }

}
