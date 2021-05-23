using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Exit : MonoBehaviour
{
    [SerializeField]
    Transform _destination2;
    NavMeshAgent _navMeshAgent2;
    void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Exit"))
        {
            exitt();
        }
    }
    void exitt()
    {
        _navMeshAgent2 = this.GetComponent<NavMeshAgent>();
        if (_navMeshAgent2 == null)
        {
            Debug.Log("Not Attached" + gameObject.name);
        }
        else
        {
            SetDestiantion();

        }
    }
    void SetDestiantion()
    {
        if (_destination2 != null)
        {
            Vector3 targetVector = _destination2.transform.position;
            _navMeshAgent2.SetDestination(targetVector);


        }
    }
}