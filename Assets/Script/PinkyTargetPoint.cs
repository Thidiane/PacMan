using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PinkyTargetPoint : MonoBehaviour
{
    [SerializeField] Transform Player;

    private void FixedUpdate()
    {
        transform.position = Player.position + Player.up * 2;
    }
}
