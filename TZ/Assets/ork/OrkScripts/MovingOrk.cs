using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MovingOrk : MonoBehaviour
{
     public Transform purpose;
     private NavMeshAgent ork;
   
    void Start()
    {
      
      ork = GetComponent<NavMeshAgent>();
     InvokeRepeating("ChangePurpose", 2f, 10f);
     
    }

   private void ChangePurpose()
    {
        float x = Random.Range(-45f, 45f);
        float z = Random.Range(-45f, 45f);
      purpose.position = new Vector3(x, transform.position.y, z);  
      ork.SetDestination(purpose.position);
    }
      
    }

