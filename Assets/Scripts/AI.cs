using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using System.IO;

public class AI : MonoBehaviour
{

    public GameObject target;

    NavMeshAgent agent;


    private void Start()
    {
        
        agent = GetComponent<NavMeshAgent>();
    }
    private void Update()
    {
        agent.SetDestination(target.transform.position);
    }

}
