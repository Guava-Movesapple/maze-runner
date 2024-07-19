using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Elevator : MonoBehaviour
{

    private bool playerEntered = false;
    public GameObject plane;
    public float speed;
    public GameObject invisWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (playerEntered && plane.transform.position.z < 30)
        {
            plane.transform.Translate(Vector3.forward * speed * Time.deltaTime);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        PlayerPrefs.SetInt("level", 2);
        playerEntered = true;
        invisWall.SetActive(true);
        
    }
}
