using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    private Vector3 movement;
    public float speed;
    private int heartCount = 3;
    private float invincibleTimer = 0;
    public List<GameObject> heartCanvas = new List<GameObject>();
    public GameObject logic;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxis("Horizontal") * speed * Time.deltaTime;
        movement.z = Input.GetAxis("Vertical") * speed * Time.deltaTime;

        transform.Translate(movement, Space.Self);

        if(invincibleTimer > 0) 
        {
            invincibleTimer -= Time.deltaTime;
        }


    }

    private void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.tag == "Enemy" && invincibleTimer <= 0 && heartCount > 0)
        {
            heartCanvas[heartCount-1].SetActive(false);
            heartCount -= 1;
            invincibleTimer = 3;

            if(heartCount == 0)
            {
                logic.GetComponent<LogicManagerScript>().isAlive = false;
            }
        }
    }

}
