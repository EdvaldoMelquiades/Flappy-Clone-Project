using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pipes : MonoBehaviour
{
    public float speed;

    // Update is called once per frame
    void Update()
    {
        // Move pipes left based on speed variable
        transform.position += Vector3.left * speed * Time.deltaTime;
    }
}
