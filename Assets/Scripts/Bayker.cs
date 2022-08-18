using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class Bayker : MonoBehaviour
{
    // Start is called before the first frame update
    public NavMeshSurface[] surface;
    //public Transform[] notbaykobj;
    private NavMeshAgent agent;
    //public Vector3 pos;
    //public Vector3 pos2;
    private GameObject[] cub;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();

        for (int i = 0; i < surface.Length; i++)
        {
            //cub = GameObject.FindGameObjectsWithTag("Player");
            //pos = cub[j].transform.position;

                    surface[i].BuildNavMesh();

        }

    }

}
