using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawnScript : MonoBehaviour
{
    public GameObject pipe;
    public float spawnRate = 2;
    public float heightOffset = 10;
    private float timer = 0;
    private List<GameObject> spawnList = new List<GameObject>();
    private bool isGameOver = false;

    // Start is called before the first frame update
    void Start()
    {
        SpawnPipe();
    }

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            if (timer < spawnRate)
            {
                timer += Time.deltaTime;
            }
            else
            {
                SpawnPipe();
                timer = 0;
            }
        }

    }

    void SpawnPipe()
    {
        float lowestPoint = transform.position.y - heightOffset;
        float highestPoint = transform.position.y + heightOffset;
        spawnList.Add(Instantiate(pipe, new Vector3(transform.position.x, Random.Range(lowestPoint, highestPoint), 0), transform.rotation));
    }

    public void StopPiepes()
    {
        isGameOver = true;
        spawnList.ForEach(pipe =>
        {
            if (pipe != null)
            {
                pipe.GetComponent<PipeScript>().isGameOver = true;
            }
            return;
        });
    }
}
