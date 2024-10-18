using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Blinky : MonoBehaviour
{
    [SerializeField] Transform target;
    [SerializeField] Transform escapePoint;

    [SerializeField] PlayerSuperMode playerMode;

    NavMeshAgent agent;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
        agent.updateUpAxis = false;
        agent.SetDestination(target.position);
    }

    private void FixedUpdate()
    {
        if (playerMode.playerType == PlayerSuperMode.playerTypes.hunter)
        {
            agent.SetDestination(escapePoint.position);
        }
        else
        {
            agent.SetDestination(target.position);
        }
    }
}
