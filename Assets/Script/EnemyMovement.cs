using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
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
        Debug.Log(playerMode.playerType.ToString());
        if (playerMode.playerType == PlayerSuperMode.playerTypes.hunter)
        {
            agent.SetDestination(escapePoint.position);
            /*Vector3 fleeDirection = (transform.position - target.position).normalized;
            Vector3 fleePosition = transform.position + fleeDirection * 8f;

            // Vérifie si le point de fuite calculé est sur le NavMesh
            NavMeshHit hit;
            if (NavMesh.SamplePosition(fleePosition, out hit, 1.0f, NavMesh.AllAreas))
            {
                agent.SetDestination(hit.position);
                Debug.Log("Clyde fuit vers : " + hit.position);
            }
            else
            {
                Debug.LogWarning("Le point de fuite n'est pas accessible sur le NavMesh.");
            }*/
        } else if (playerMode.playerType == PlayerSuperMode.playerTypes.hunted)
        {
            agent.SetDestination(target.position);
            
        }
        
    }

    
}
