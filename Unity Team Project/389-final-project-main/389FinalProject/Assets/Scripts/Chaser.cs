using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Chaser : MonoBehaviour
{
    //Agent will walk/run to this GameObject
    public GameObject player;

    NavMeshAgent agent;

    Transform goal;

    void Start()
    {
        goal = player.transform;
        agent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        agent.SetDestination(goal.position);
    }
}
