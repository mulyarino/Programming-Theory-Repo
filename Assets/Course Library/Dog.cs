using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Animal
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Move();
    }
    public override void Move()
    {
        transform.Translate(Vector3.forward * moveSpeed * 2 * Time.deltaTime);
    }
}
