using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PacManLife : MonoBehaviour
{
    [SerializeField] private int life = 3;
    private GameOverMenu Overmenu;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            life--;
        }

        ActiveGameOverMenu();
    }

    private void ActiveGameOverMenu()
    {
        if (life <= 0)
        {
            Overmenu = GameObject.FindObjectOfType(typeof(GameOverMenu)) as GameOverMenu;

            Overmenu.OnPlayerDeath();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            life--;
        }
    }

}
