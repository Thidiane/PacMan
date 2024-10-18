using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSuperMode : MonoBehaviour
{
    private SpriteRenderer spriteRenderer;
    public Sprite newSprite;
    public Sprite normalSprite;
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
        spriteRenderer = GetComponent<SpriteRenderer>();
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
            spriteRenderer.sprite = newSprite;
        }

        if (timer > timerDuration)
        {
            StopTimer();
            playerType = playerTypes.hunted;
            spriteRenderer.sprite = normalSprite;
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
