using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PacManLife : MonoBehaviour
{
    [SerializeField] private int life = 3;
    private GameOverMenu Overmenu;

    void Start()
    {

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            life--;
            if (life <= 0)
            {
                Overmenu = GameObject.FindObjectOfType(typeof(GameOverMenu)) as GameOverMenu;

                Overmenu.OnPlayerDeath();
            }
        }

    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            life--;

            if (life <= 0)
            {
                Overmenu = GameObject.FindObjectOfType(typeof(GameOverMenu)) as GameOverMenu;

                Overmenu.OnPlayerDeath();
            }
        }
    }

}
