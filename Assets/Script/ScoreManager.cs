using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public GameObject VictoryMenu;
    public Text myscore;
    [SerializeField]public int score;
    [SerializeField]private int addscore;

    void Start()
    {
        score = 0;
        myscore.text = "Score: " + score;
    }
    private void Update()
    {
        VictoryScreen();

    }
    private void VictoryScreen()
    {
        if (score >= addscore)
        {
            VictoryMenu.SetActive(true);
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    { 
        if (collision.CompareTag("blood"))
        {
            score += 1;
            Destroy(collision.gameObject);
            myscore.text = "Score : " + score;
        }

    }
    
}
