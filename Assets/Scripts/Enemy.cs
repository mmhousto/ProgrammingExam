using UnityEngine;
using UnityEngine.Events;

public class Enemy : MonoBehaviour
{

    public bool gameStarted;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Playa.onPlayerDeath += CleanUp;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGame()
    {
        gameStarted = true;
    }

    public void CleanUp()
    {
        gameStarted = false;
    }
}
