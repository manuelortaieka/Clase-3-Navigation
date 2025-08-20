using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class agenteCapsula : MonoBehaviour
{
    [SerializeField] NavMeshAgent tobigerman;
    public Transform bege;
    // Start is called before the first frame update
    void Awake()
    {
        tobigerman = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {
        tobigerman.destination = bege.position;
    }
}
