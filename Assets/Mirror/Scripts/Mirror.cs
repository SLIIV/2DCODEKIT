using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mirror : MonoBehaviour
{
    public Vector3 direction;
    public Vector3 resultDirection;
    public Vector3 normal;
    public float speed;
    private void Update()
    {
        transform.position += direction * speed * Time.deltaTime;
    }
    

    private void OnCollisionEnter2D(Collision2D collision)
    {
        resultDirection = Vector3.Reflect(direction, collision.transform.right);
        direction = Vector3.Normalize(resultDirection);
    }
}
