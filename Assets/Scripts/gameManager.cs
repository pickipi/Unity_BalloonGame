using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class gameManager : MonoBehaviour
{
    public GameObject enemy;
    public GameObject gameOverText;

    public static gameManager I;

    public Text timeText;
    float run = 0.0f;

    public Animator anime;
    public GameObject balloon;


    // Start is called before the first frame update
    void Awake()
    {
        I = this;
    }

    void Start()
    {
        InvokeRepeating("makeEnemy", 0.0f, 0.5f);
    }

    void makeEnemy()
    {
        Instantiate(enemy);
    }


    // Update is called once per frame
    void Update()
    {
        run += Time.deltaTime;
        timeText.text = run.ToString("N2");
    }

    public void gameOver()
    {
        anime.SetBool("isDie", true);
        gameOverText.SetActive(true);
        Invoke("dead", 0.5f);
        
    }

    void dead()
    {
        Time.timeScale = 0.0f;
        Destroy(balloon);
    }
}
