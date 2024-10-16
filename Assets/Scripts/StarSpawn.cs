using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StarSpawn : MonoBehaviour
{
    public GameObject GameObject;
    GameObject star;

    void Start()
    {
        star = Instantiate(GameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
