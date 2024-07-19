using System.Collections;
using System.Collections.Generic;
using UnityEditor.Rendering;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAI : MonoBehaviour
{
    private NavMeshAgent agent;
    public GameObject player;
    public float enemySpeed;

    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.speed = enemySpeed;
    }

    // Update is called once per frame
    void Update()
    {
        agent.destination = player.transform.position;
    }
}
