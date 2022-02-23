using System.Collections;
using System.Collections.Generic;
using UnityEngine;


//Script execution order is NOT guaranteed
//Unity will search the tree, and try its best, but it's never a sure thing
public class TestComponentOne : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"Awake:{this.name}");
    }

}
