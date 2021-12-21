using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public GameObject gameStartCanvas;
    public GameObject gameOverCanvas;
    
    public bool gameStart=false;
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        
        Time.timeScale = 0;
    }
    public void Replay()
    {
        SceneManager.LoadScene(0);
        Time.timeScale = 1;
        
    }
    public void GameStart()
    {
        gameStartCanvas.SetActive(false); 
        Time.timeScale = 1;
        gameStart = true;
    }
}
