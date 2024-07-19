using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LogicManagerScript : MonoBehaviour
{
    public bool isAlive = true;
    public GameObject player;
    public GameObject deathScreen;
    public GameObject transition;
    public float transitionTime;
    public GameObject elevator;


    // Start is called before the first frame update
    void Start()
    {
       if(PlayerPrefs.GetInt("level") == 1)
        {
            player.transform.position = new Vector3(-7, 2, -10);
        }
       else if(PlayerPrefs.GetInt("level") == 2)
        {
            player.transform.position = new Vector3(35, 1, 35);
            elevator.transform.position = new Vector3(35, 0, 30);
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        if (!isAlive)
        {
            onDeath();
        }

        if (transitionTime > 0)
        {
            transitionTime -= Time.deltaTime;
        }

        if (transitionTime < 0)
        {
            SceneManager.LoadScene("Game");
        }
    }

    private void onDeath()
    {
        deathScreen.SetActive(true);
        player.SetActive(false);
        
    }

    public void onRevert()
    {
        transition.SetActive(true);
        transitionTime = 5;
    }

}
