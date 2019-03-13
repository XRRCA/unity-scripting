using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PublicPrivateExample : MonoBehaviour
{
    public Transform target;
    public float x;
    public float y;
    private float z;

    // Use this for initialization
    void Start()
    {
        x = target.position.x;
        y = target.position.y;
        z = target.position.z;
    }

    // Update is called once per frame
    void Update()
    {
        target.position = new Vector3(x, y, z);
    }
}