using UnityEngine;
using System.Collections;

public class MoveEnemy : MonoBehaviour
{
    public float AGGRESSIVE_RANGE = 15.0f;

    float distToPlayer;
    Transform player;               
    Transform tree;
    //playerHealth;                   
    //EnemyHealth enemyHealth;       
    NavMeshAgent nav;               


    void Awake()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
        tree = GameObject.FindGameObjectWithTag("Tree").transform;
        //playerHealth = player.GetComponent<PlayerHealth>();
        //enemyHealth = GetComponent<EnemyHealth>();
        nav = GetComponent<NavMeshAgent>();
    }


    void Update()
    {
        distToPlayer = Vector3.Distance(player.position, transform.position);
        //Debug.Log(distToPlayer);
        //ENEMY MOVES TO ATTACK PLAYER IF WITHIN AGGRESSIVE RANGE
        if (distToPlayer >= AGGRESSIVE_RANGE)
        {
            nav.SetDestination(tree.position);
        }
        else
        {
            nav.SetDestination(player.position);
        }
    }
}