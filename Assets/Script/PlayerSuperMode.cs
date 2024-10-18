using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSuperMode : MonoBehaviour
{

    private float timer = 0f;
    private bool isTimerRunning = false;
    [SerializeField] float timerDuration;
    public enum playerTypes
    {
        hunter, 
        hunted
    }
    public playerTypes playerType;
    [SerializeField] playerTypes ancientPlayerType;

    
    private void Start()
    {
        playerType = playerTypes.hunted;
    }
    private void FixedUpdate()
    {
        if (isTimerRunning)
        {
            timer += Time.deltaTime;
        }
        if (playerType == playerTypes.hunter && ancientPlayerType == playerTypes.hunted)
        {
            StartTimer();
        }

        if (timer > timerDuration)
        {
            StopTimer();
            playerType = playerTypes.hunted;
        }

        ancientPlayerType = playerType;
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("SuperBlood"))
        {
            playerType = playerTypes.hunter;
        }
    }

    public void StartTimer()
    {
        isTimerRunning = true;
        timer = 0f;
        Debug.Log("Timer démarré !");
    }
    public void StopTimer()
    {
        isTimerRunning = false;
        Debug.Log("Timer arrêté à : " + timer.ToString("F2") + " secondes");
    }
    public bool IsTimerRunning()
    {
        return isTimerRunning;
    }
}
