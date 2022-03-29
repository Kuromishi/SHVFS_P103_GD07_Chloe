using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestComponentTwo : MonoBehaviour
{
    private void Awake()
    {
        Debug.Log($"Awake:{this.name}");
    }
}
