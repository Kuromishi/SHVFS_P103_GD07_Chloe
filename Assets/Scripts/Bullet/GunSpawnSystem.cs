using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GunSpawnSystem : MonoBehaviour
{
    public GameObject GunSpawnPointPrefabs;
    public Transform[] GunSpawnPointTransform;
    public float tickRate;
    public float tickTimer = 0;


    public void Update()
    {
        tickTimer += Time.deltaTime;
        if (tickTimer < tickRate) return;
        var index= Random.Range(0, GunSpawnPointTransform.Length);
        var gun= Instantiate(GunSpawnPointPrefabs, GunSpawnPointTransform[index].position, Quaternion.identity);//销毁生成的这个，并不是prefab
        tickTimer = 0;

        Destroy(gun, 4);
    }
}
