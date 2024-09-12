using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Exercise29NavMesh : MonoBehaviour
{
    NavMeshAgent nav;
    Animator anim;
    void Start()
    {
        nav = GetComponent<NavMeshAgent>();
        anim = GetComponent<Animator>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit,1000))
            {
                nav.SetDestination(hit.point);
            }
        }
        if (nav.velocity == Vector3.zero)
        {
            AnimStop();
        }
        else
        {
            AnimMove();
        }
    }
    void AnimMove() => anim.SetBool("Walk", true);
    void AnimStop() => anim.SetBool("Walk", false);
}
