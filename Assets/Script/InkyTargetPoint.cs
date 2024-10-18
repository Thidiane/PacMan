using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InkyTargetPoint : MonoBehaviour
{
    [SerializeField] Transform player;
    [SerializeField] Transform blinky;
    [SerializeField] float playerOffset = 0.2f;

    private Vector2 targetPoint;

    void Update()
    {
        Vector2 playerDirection = new Vector2(Mathf.Cos(player.eulerAngles.z * Mathf.Deg2Rad), Mathf.Sin(player.eulerAngles.z * Mathf.Deg2Rad)).normalized;

        // Calcule un point devant Pac-Man en utilisant sa position et sa direction
        Vector2 pointInFrontOfPacman = (Vector2)player.position + playerDirection * playerOffset;

        // Calcule la différence entre Blinky et le point devant Pac-Man
        Vector2 blinkyToPoint = pointInFrontOfPacman - (Vector2)blinky.position;

        // Double cette distance et ajoute-la à la position de Blinky pour trouver le point cible
        targetPoint = (Vector2)blinky.position + blinkyToPoint * 2;

        // Affiche le point cible dans l'éditeur pour vérification
        Debug.DrawLine(blinky.position, targetPoint, Color.blue);
        Debug.DrawLine(player.position, pointInFrontOfPacman, Color.red);
        
        transform.position = targetPoint;
    }
}
