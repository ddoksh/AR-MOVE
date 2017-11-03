using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class ARAgent : MonoBehaviour
{
    public NavMeshAgent agent;

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray camToTouchPos = Camera.main.ScreenPointToRay(Input.mousePosition);

            RaycastHit hit;
            if (Physics.Raycast(camToTouchPos, out hit, 50f))
            {
                agent.destination = hit.point;
            }
        }
    }
}