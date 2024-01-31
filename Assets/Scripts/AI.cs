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

    public Transform Target;


    private void Start()
    {
    }
    private void Update()
    {
        AIDestinationSetter.istance.target.transform.position = Target.position;   
    }

}
