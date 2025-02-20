﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NavMeshScript : MonoBehaviour
{
	public Transform target;
	NavMeshAgent agent;

	void Start() {
		agent = GetComponent<NavMeshAgent>();
	}

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
    }
}
