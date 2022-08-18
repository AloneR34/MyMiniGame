
    using System.Collections;
    using System.Collections.Generic;
    using UnityEngine;
    using UnityEngine.SceneManagement;
    using UnityEngine.AI;

public class DangerWalking : MonoBehaviour
{
    public Transform[] points;
    private int destPoint = 0;
    private NavMeshAgent agent;
    private int RandoMs=0;
    public Rigidbody dangerrridg;
    private float speed = 1000;


    private void Update()
    {


        RandoMs = Random.Range(1, 5);

        if (RandoMs == 1)
        {
            dangerrridg.AddForce(0, 0, speed * Time.deltaTime);
            //player.transform.position += (new Vector3(0, 1)*Time.deltaTime);

        }
        if (RandoMs == 2)
        {
            dangerrridg.AddForce(0, 0, -speed * Time.deltaTime);
            //player.transform.position += (new Vector3(0, -1) * Time.deltaTime);

        }
        if (RandoMs == 3)
        {
            dangerrridg.AddForce(-speed * Time.deltaTime, 0, 0);
            //player.transform.position += (new Vector3(-1, 0) * Time.deltaTime);

        }
        if (RandoMs == 4)
        {
            dangerrridg.AddForce(speed * Time.deltaTime, 0, 0);
            //player.transform.position += (new Vector3(1, 0) * Time.deltaTime);

        }

        RandoMs = 0;
    }
}
   

    

   /* void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        // Disabling auto-braking allows for continuous movement
        // between points (ie, the agent doesn't slow down as it
        // approaches a destination point).
        agent.autoBraking = false;

        GotoNextPoint();
    }


    void GotoNextPoint()
    {
        // Returns if no points have been set up
        if (points.Length == 0)
            return;

        // Set the agent to go to the currently selected destination.
        agent.destination = points[destPoint].position;

        // Choose the next point in the array as the destination,
        // cycling to the start if necessary.
        destPoint = (destPoint + 1) % points.Length;
    }


    void Update()
    {
        // Choose the next destination point when the agent gets
        // close to the current one.
        if (!agent.pathPending && agent.remainingDistance < 0.5f)
            GotoNextPoint();
    }
}
    /*public int RandoMs;
    public Rigidbody dangerrridg;
    public bool running;
    public float speed = 5f; //unit per second
    public Transform[] moveSpots;
    private float waitTime;
    public float startWaitTime;
    private int randomSpot;
    public GameObject cub;

    public void Start()
    {
        waitTime = startWaitTime;
        randomSpot = Random.Range(0, 3);
    }

    //public int k = 0;
    void Update()
    {

        //cub[k] = GameObject.FindGameObjectsWithTag("GameController");
        //cub.transform.position = 
        transform.position = Vector3.MoveTowards(transform.position, moveSpots[randomSpot].position, speed * Time.deltaTime);

        if (Vector3.Distance(transform.position, moveSpots[randomSpot].position) < 0.2f)
        {
            if (waitTime <= 0)
            {
                randomSpot = Random.Range(0, 3);
                waitTime = startWaitTime;
            }
        }
        else
        {
            startWaitTime -= Time.deltaTime;
        }
    }
}*/








