using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class CameraMovemen : MonoBehaviour
{
    public GameObject player;
    private Vector3 newPosition;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        newPosition.x = player.transform.position.x ;
        newPosition.y = transform.position.y;
        newPosition.z = player.transform.position.z - 15;

        transform.position = newPosition;
    }
}
