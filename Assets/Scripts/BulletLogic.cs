using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    Rigidbody rigidBody;
    public float bulletSpeed;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        if(rigidBody)
        {
            rigidBody.velocity = transform.forward * bulletSpeed;
        }
    }
    private void Update()
    {
        
    }
}
