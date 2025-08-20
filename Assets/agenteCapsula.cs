using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agenteCapsula : MonoBehaviour
{
    [SerializeField] NavMeshAgent tobigerman;
    public Transform bege;
    [SerializeField] Animator anim;
    // Start is called before the first frame update
    void Awake()
    {
        tobigerman = GetComponent<NavMeshAgent>();
        anim = GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        tobigerman.destination = bege.position;
        anim.SetFloat("Speed", tobigerman.velocity.magnitude);
    }
}
