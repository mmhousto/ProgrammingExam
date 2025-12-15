using UnityEngine;

public class Playa : MonoBehaviour
{
    float vertInput;
    float horizInput;
    public float hp = 100;

    public delegate void OnPlayerDeath();
    public static event OnPlayerDeath onPlayerDeath;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        onPlayerDeath += PlayerDeath;
    }

    // Update is called once per frame
    void Update()
    {
        vertInput = Input.GetAxisRaw("Vertical");
        horizInput = Input.GetAxisRaw("Horizontal");

        transform.Translate(transform.forward * vertInput * 20f * Time.deltaTime);
        transform.Rotate(Vector3.up, horizInput * 20f * Time.deltaTime);

        if(hp <= 0)
        {
            onPlayerDeath.Invoke();
        }
    }

    public void PlayerDeath()
    {
        //Game Over
    }
}
