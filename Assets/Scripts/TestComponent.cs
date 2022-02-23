using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TsetComponent : MonoBehaviour
{
    private GameObject testGameObject;
   //Game object...The load method, is a generic method. That's able to accept/return parameters of ANY Type
    private void onEnable()
    {
        var prefab = Resources.Load<GameObject>("ResourcesTestPrefabs");
        testGameObject = Instantiate(prefab);
    }

    // Update is called once per frame
    private void OnDisable()
    {
        Destroy(testGameObject);
    }
}
