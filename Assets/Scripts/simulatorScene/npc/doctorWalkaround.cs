using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class doctorWalkaround : MonoBehaviour
{

    public Transform[] targets;
    [SerializeField] private Animator animator;
    [SerializeField] private NavMeshAgent navMeshAgent;

    private int currentTargetIndex = 0;
    
    void Start()
    {
        navMeshAgent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        animator.SetBool("isWalking", true);
       // animator.SetBool("isIdle", true);
    }

    

    void Update()
    {
        if(navMeshAgent.remainingDistance < 0.1f && !navMeshAgent.pathPending)
        {
            MoveToNextTarget();
        }
    }

    void MoveToNextTarget()
    {
        if (currentTargetIndex >= targets.Length)  
        {
            return;
        }
        navMeshAgent.SetDestination(targets[currentTargetIndex].position);  
        currentTargetIndex++; 
    }

}
