using UnityEngine;
using UnityEngine.Events;

public class GameManager : MonoBehaviour
{

    public UnityEvent gameStart;
    public UnityEvent gameEnd;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        GameObject enemy = GameObject.FindWithTag("Enemy");
        gameEnd.AddListener(enemy.GetComponent<Enemy>().CleanUp);
        gameStart.AddListener(enemy.GetComponent<Enemy>().StartGame);
        gameStart.Invoke();

        Playa.onPlayerDeath += EndGame;

        //Invoke(nameof(EndGame), 5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void EndGame()
    {
        gameEnd.Invoke();
    }
}
