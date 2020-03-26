using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyAnimation : MonoBehaviour
{
    public NavMeshAgent enemyNavMeshAgent;
    public Animator enemyAnimator;

    private void Update()
    {
        enemyAnimator.SetFloat("enemySpeed", enemyNavMeshAgent.velocity.magnitude);
    }
}
