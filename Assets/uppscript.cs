using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class uppscript : MonoBehaviour
{
    public float power;
    private Rigidbody2D Rigidibody1;
    public GameObject bullet;
    private Vector3 bulletSpawn;
    public float firerate;
    // Start is called before the first frame update
    void Start()
    {
        Rigidibody1 = GetComponent<Rigidbody2D>();
        firerate = 0.5f;
    }

    // Update is called once per frame
    void Update()
    {
        firerate -= Time.deltaTime;
        bulletSpawn = new Vector3(transform.position.x, transform.position.y - 4f);
        if (Input.GetKey(KeyCode.Space))
        {
            Rigidibody1.velocity = Vector2.up * power;
            if(firerate <= 0)
            {
                Instantiate(bullet, bulletSpawn, Quaternion.identity);
                firerate = 0.9f;
            }
            
        }

    }
     private void FixedUpdate()
    {
        if(Input.GetKey(KeyCode.Space))
        Instantiate(bullet, bulletSpawn, Quaternion.identity);
    }

}
