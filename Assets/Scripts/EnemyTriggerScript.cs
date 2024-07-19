using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTriggerScript : MonoBehaviour
{
    public GameObject enemyObject;

    private void OnTriggerEnter(Collider other)
    {
        enemyObject.SetActive(true);
    }
}
