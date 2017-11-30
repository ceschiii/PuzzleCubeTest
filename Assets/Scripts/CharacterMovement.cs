using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using System;

public class CharacterMovement : MonoBehaviour
{
	float yPosition;
	public bool IsMoving = false;

    NavMeshAgent agent;
    Animator animator;

    void Start()
    {
		yPosition = transform.position.y;
        agent = GetComponent<NavMeshAgent>();
        //animator = GetComponent<Animator>();
    }

    void Update()
    {
        Vector3 moving = agent.velocity;     
        //animator.SetFloat("Moving", moving.magnitude);
        if (IsMoving)
        {
            RaycastHit hit;

			Ray ray = Camera.main.ScreenPointToRay (Input.mousePosition);
			if (Physics.Raycast (ray, out hit)) {

				transform.position = new Vector3 (hit.point.x, yPosition, hit.point.z);
				//agent.destination = new Vector3 (hit.point.x, yPosition, hit.point.z);

				//transform.position = new Vector3 (hit.point.x, yPosition, hit.point.z);
			}



//            if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out hit, 100))
//            {
//                print(hit.transform.name);
//                if (hit.transform.name == "path")
//                {
//                    agent.destination = hit.point;
//                }

            }
        }
 
	void OnMouseDown(){
		IsMoving = !IsMoving;
	}
	
}

	
