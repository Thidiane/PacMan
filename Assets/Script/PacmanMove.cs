using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PacmanMove : MonoBehaviour
{
    public float speed = 5f;
    private Rigidbody2D rb;
    [SerializeField] InputActionReference PlayerMove;

    enum Direction
    {
        up,
        down,
        left,
        right
    }


    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update() 
    {
        Move();    
    }

    private void Move()
    {
        if (PlayerMove.action.IsPressed())
        {
            Vector2 input = PlayerMove.action.ReadValue<Vector2>();

            transform.Translate(input * Time.deltaTime * speed);

        }
    }
}
