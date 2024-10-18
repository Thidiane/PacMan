using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EmptyVisualizer : MonoBehaviour
{
    public Color gizmoColor = Color.yellow;

    public float radius = 0.5f;

    void OnDrawGizmos()
    {
        Gizmos.color = gizmoColor;

        Gizmos.DrawWireSphere(transform.position, radius);
    }
}
