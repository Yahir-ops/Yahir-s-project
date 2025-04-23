using UnityEngine;
using UnityEngine.AI;
using System.Collections;
using System.Collections.Generic;

public class zombiemoving : MonoBehaviour
{  
public Transform player;
public float followDistance = 10f;
private UnityEngine.AI.NavMeshAgent agent;

void Start()
{
	agent = GetComponent<UnityEngine.AI.NavMeshAgent>();
}
void Update()
{
	float distance = Vector3.Distance(transform.position, player.position);
	if(distance <= followDistance)
	{
		agent.SetDestination(player.position);
	}
}


}

