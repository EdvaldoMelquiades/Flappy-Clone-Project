using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner : MonoBehaviour
{
    public GameObject pipe;
    public float height = 0.8f;
    public float spawnInterval = 1.5f;

    private float timer = 0;

    // Start is called before the first frame update
    // Redundant?
    /*void Start()
    {
        // Create a prefab pipe
        GameObject newPipe = Instantiate(pipe);
        newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
    }*/

    // Update is called once per frame
    void Update()
    {
        // Spawn pipes based on interval
        if(timer > spawnInterval)
        {
            GameObject newPipe = Instantiate(pipe);
            newPipe.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(newPipe, 20);
            timer = 0;
        }
        timer += Time.deltaTime;
    }
}
