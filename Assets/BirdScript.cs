using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdScript : MonoBehaviour
{
    public Rigidbody2D mybirdBody;
    public float flapStrength;
    public LogicScript logic;
    public bool birdIsAlive = true;
    private Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        logic = GameObject.FindGameObjectWithTag("GameController").GetComponent<LogicScript>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) == true && birdIsAlive == true)
        {
            mybirdBody.velocity = Vector2.up * flapStrength;
            animator.SetFloat("Y", 1);
        }
        else if (Input.GetKeyUp(KeyCode.Space) == true && birdIsAlive == true)
        {
            animator.SetFloat("Y", 0);
        }


    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        logic.GameOver();
        birdIsAlive = false;
    }
}
