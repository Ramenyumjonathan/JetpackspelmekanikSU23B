using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    
    

    public float speed = 5f;
    public Vector2 direction = Vector2.right;
    // Start is called before the first frame update
    void Start()
    {


        
    }

    // Update is called once per frame
    void Update()

    {
        transform.Translate(direction * speed * Time.deltaTime);


        
    }
}
