using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ClydeMovement : MonoBehaviour
{
    public Transform player; 
    public Transform escapePoint; 

    private NavMeshAgent agent;

    void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
    }

    private void FixedUpdate()
    {
        float distanceToPlayer = Vector2.Distance(transform.position, player.position);
        if (distanceToPlayer > 8)
        {
            agent.SetDestination(escapePoint.position);
        } else
        {
            agent.SetDestination(player.position);
        }
    }

    /*void Update()
    {
        float distanceToPlayer = Vector3.Distance(transform.position, player.position);

        if (distanceToPlayer > 8f)
        {
            agent.SetDestination(player.position);
            Debug.Log("Clyde se dirige vers Pac-Man.");
        }
        else
        {
            Vector3 fleeDirection = (transform.position - player.position).normalized;
            Vector3 fleePosition = transform.position + fleeDirection * 8f;

            NavMeshHit hit;
            if (NavMesh.SamplePosition(fleePosition, out hit, 1.0f, NavMesh.AllAreas))
            {
                agent.SetDestination(hit.position);
                Debug.Log("Clyde fuit vers : " + hit.position);
            }
            else
            {
                Debug.LogWarning("Le point de fuite n'est pas accessible sur le NavMesh.");
            }
        }
    }*/
}
