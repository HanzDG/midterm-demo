// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEngine.AI;
 
// public class AiLocomotion : MonoBehaviour 
// {
//     public Transform playerTransform;
//     NavMeshAgent agent;
    
     

//     void Start() {
//         agent = GetComponent<NavMeshAgent>();
//         agent.speed = 2f;
        
//     }

//     void Update() 
//     {
//         agent.SetDestination(playerTransform.position);
        
//     }
// }

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AiLocomotionHanz : MonoBehaviour 
{
    public Transform playerTransform;
    private NavMeshAgent agent;
    private EnemyHanz enemy;

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        enemy = GetComponent<EnemyHanz>();
        agent.speed = 2f;
    }

    void Update()
    {
        if (enemy != null && agent != null)
        {
            if (!agent.enabled)
                return; // If the agent is disabled, do nothing

            agent.SetDestination(playerTransform.position);
        }
    }
}

