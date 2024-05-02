using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jetpackgunnz : MonoBehaviour
{
    private float Xspeed;
    private float Yspeed;

    private void Awake()
    {
        Yspeed = Random.Range(-0.01f, -0.01f);
        Xspeed = Random.Range(-0.01f, 0.01f);
    }

    void Update()
    {
        transform.position = new Vector3(transform.position.x + Xspeed, transform.position.y + Yspeed, transform.position.z);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Destroy(gameObject);
    }

}
  