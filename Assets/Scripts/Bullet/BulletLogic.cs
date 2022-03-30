using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletLogic : MonoBehaviour
{
    Rigidbody rigidBody;
    public float bulletSpeed;
    public int BulletID;

    private void Start()
    {
        rigidBody = GetComponent<Rigidbody>();
        gameObject.GetComponent<Rigidbody>().AddForce(transform.forward * bulletSpeed);
        gameObject.GetComponent<Rigidbody>().AddForce(transform.up * bulletSpeed);
        //if (rigidBody)
        //{
        //    rigidBody.velocity = transform.forward * bulletSpeed;
        //}
    }
    private void Update()
    {
        
    }
}
