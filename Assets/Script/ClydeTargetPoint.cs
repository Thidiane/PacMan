using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClydeTargetPoint : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform RefugePoint;
    

    private void Start()
    {
        transform.position = player.position;
    }

    private void FixedUpdate()
    {
        if (IsCloseToPlayer())
        {
            Debug.Log("IsCloseToPlayer");
            transform.position = RefugePoint.position;
        } else
        {
            transform.position = player.position;
        }
        Debug.Log(transform.position);
    }

    private bool IsCloseToPlayer()
    {
        float distance = Vector2.Distance(transform.position, player.position);
        return distance <= 8f;
    }
}
