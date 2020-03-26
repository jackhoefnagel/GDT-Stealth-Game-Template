using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyMovement : MonoBehaviour
{
    public List<Transform> patrolPositions;
    public NavMeshAgent navMeshAgent;
    public int currentPatrolIndex = 0;

    private void Start()
    {
        StartCoroutine(DoPatrol());
    }

    private IEnumerator DoPatrol()
    {
        while (true)
        {
            navMeshAgent.destination = patrolPositions[currentPatrolIndex].position;
            yield return new WaitUntil(IsEnemyNearDestination);
            currentPatrolIndex++;
            if(currentPatrolIndex > (patrolPositions.Count-1))
            {
                currentPatrolIndex = 0;
            }
        }
    }

    private bool IsEnemyNearDestination()
    {
        return navMeshAgent.remainingDistance < 0.2f;
    }
}
