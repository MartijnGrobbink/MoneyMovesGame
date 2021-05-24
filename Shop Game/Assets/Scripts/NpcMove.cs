using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class NpcMove : MonoBehaviour
{
    [SerializeField]
    GameObject Cashier;
    Collider collision;
    //Transform _destination;
    NavMeshAgent _navMeshAgent;
    void Start()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        Cashier = GameObject.FindWithTag("WayPoint1");
        if (_navMeshAgent == null)
        {
            Debug.Log("Not Attached" + gameObject.name);
        }
        else
        {
            SetDestiantion();
            
        }
        //Debug.Log(_destination);
    }

     void SetDestiantion()
    {/*
        if(_destination != null)
        {
            Vector3 targetVector = _destination.transform.position;
            _navMeshAgent.SetDestination(targetVector);
        }*/
       if(Cashier != null)
       {
            Vector3 test = Cashier.transform.position;
            _navMeshAgent.SetDestination(test);
            Debug.Log(test);
       }
               if (collision.gameObject.CompareTag("Exit"))
        {
            exitt();
        }
    }
    void exitt()
    {
        _navMeshAgent = this.GetComponent<NavMeshAgent>();
        if (_navMeshAgent == null)
        {
            Debug.Log("Not Attached" + gameObject.name);
        }
        else
        {
            SetDestiantion();
        }


    }

    
}
    
