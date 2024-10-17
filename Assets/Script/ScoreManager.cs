using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public Text myscore;
    [SerializeField]private int score;
    [SerializeField]private int addscore;

    void Start()
    {
        score = 0;
        myscore.text = "Score: " + score;
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
