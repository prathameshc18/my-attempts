using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gamemanager : MonoBehaviour
{
    bool gameHasEnded=false;
    public GameObject completeui;
    public void complete()
    {
        completeui.SetActive(true);
    }
    public void endgame()
    {
        if(gameHasEnded==false)
        {
            gameHasEnded = true;
            Debug.Log("Game over");
            Invoke("restart",2f);
        }
        
    }
    public void restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }
}
