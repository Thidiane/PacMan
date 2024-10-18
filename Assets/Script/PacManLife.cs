using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PacManLife : MonoBehaviour
{
    [SerializeField] private int life = 3; 
    [SerializeField] private List<GameObject> lifeIcons; 
    private GameOverMenu Overmenu;

    void Start()
    {
        
        if (lifeIcons.Count != life)
        {
            Debug.LogWarning("Le nombre d'icônes de vie ne correspond pas au nombre de vies.");
        }
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.H))
        {
            LoseLife();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("enemy"))
        {
            LoseLife();
        }
    }

    private void LoseLife()
    {
        life--;

        if (life >= 0 && life < lifeIcons.Count)
        {
            lifeIcons[life].SetActive(false);
        }

        if (life <= 0)
        {
            Overmenu = GameObject.FindObjectOfType(typeof(GameOverMenu)) as GameOverMenu;
            Overmenu.OnPlayerDeath();
        }
    }
}

