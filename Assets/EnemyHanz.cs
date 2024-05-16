// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Enemy : MonoBehaviour
// {
//     // Start is called before the first frame update
//     void Start()
//     {
//         SetupRagdoll();
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     public void SetupRagdoll()
//     {
//         foreach (var item in GetComponentsInChildren<Rigidbody>()) {
//             item.isKinematic = true;
//         }
//         // Set up ragdoll
//     }

//     public void Dead(Vector3 hitPosition) 
//     {
//         foreach (var item in GetComponentsInChildren<Rigidbody>()) {
//             item.isKinematic = false;
//         }

//         foreach (var item in Physics.OverlapSphere(hitPosition, 0.3f)) {
//             Rigidbody rb = item.GetComponent<Rigidbody>();
//             if(rb) {
//                 rb.AddExplosionForce(1000f, hitPosition, 0.3f);

//             }
//         }
//     }
// }


using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI; // Include this to reference NavMeshAgent

public class EnemyHanz : MonoBehaviour
{
    private NavMeshAgent navMeshAgent;

    void Start()
    {
        SetupRagdoll();
        navMeshAgent = GetComponent<NavMeshAgent>();
    }

    void Update()
    {
        // Any additional logic if needed
    }

    public void SetupRagdoll()
    {
        foreach (var item in GetComponentsInChildren<Rigidbody>())
        {
            item.isKinematic = true;
        }
    }

    public void Dead(Vector3 hitPosition)
    {
        foreach (var item in GetComponentsInChildren<Rigidbody>())
        {
            item.isKinematic = false;
        }

        foreach (var item in Physics.OverlapSphere(hitPosition, 0.3f))
        {
            Rigidbody rb = item.GetComponent<Rigidbody>();
            if (rb)
            {
                rb.AddExplosionForce(1000f, hitPosition, 0.3f);
            }
        }

        if (navMeshAgent != null)
        {
            navMeshAgent.enabled = false; // Disable the NavMeshAgent
        }

        // Optionally, you can also disable this script to stop further logic
        this.enabled = false;
    }
}
