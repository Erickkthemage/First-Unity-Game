using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    private GameManager manager;

    bool gameHasEnded = false;
    
    public static int finalScore;
    public float restartDelay = 1f;

    public GameObject completeLevelUI;

    public void CompleteLevel (int score)
    {
        finalScore = finalScore + score;
        completeLevelUI.SetActive(true);
    }
   public void EndGame ()
    {
        if (gameHasEnded == false)
        {
            gameHasEnded = true;
            Invoke("Restart", restartDelay);
        }
    }

    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        gameHasEnded = false;
    }

    private void Awake()
    {
        if (manager == null)
        {
            manager = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }    
    }
}
