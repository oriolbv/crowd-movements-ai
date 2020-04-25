using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class PedestrianLeftBehaviour : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject goal;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = Random.Range(1f, 10.0f);
    }

    void Update()
    {
        agent.destination = goal.transform.position;
    }
}
