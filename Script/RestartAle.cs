using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RestartAle : MonoBehaviour
{
    public void ClickRestart()
    {
        GameController.GameOver = false;
        SceneManager.LoadScene(1);
    }
}