using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour {

    public Transform rocket;
    public void SpawnObj(GameObject spawn)
    {
        Instantiate(spawn, rocket);
    }
}
