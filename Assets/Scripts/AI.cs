using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UIElements;
using System.IO;
using Pathfinding;

public class AI : MonoBehaviour
{

    public GameObject Target;


    private void Start()
    {
        Target = GameObject.Find("Player");
    }
    private void Update()
    {
        AIDestinationSetter.istance.target.transform.position = Target.transform.position;   
    }

}
