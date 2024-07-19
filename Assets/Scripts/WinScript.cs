using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScript : MonoBehaviour
{


    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("level", 1);
        SceneManager.LoadScene("Win");
    }

    public void playAgain()
    {
        SceneManager.LoadScene("Game");
    }

    public void menu()
    {
        SceneManager.LoadScene("Start Screen");
    }
}
