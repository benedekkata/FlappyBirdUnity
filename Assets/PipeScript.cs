using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeScript : MonoBehaviour
{
    public float moveSpeed = 1;
    public float deleteZone = -15;

    public bool isGameOver = false;

    // Update is called once per frame
    void Update()
    {
        if (!isGameOver)
        {
            transform.position += (Vector3.left * moveSpeed) * Time.deltaTime;
        }

        if (transform.position.x < deleteZone)
        {
            Destroy(gameObject);
        }
    }
}
