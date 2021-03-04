using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Dead : MonoBehaviour
{
    public GameObject Doctor;
    public float force;
    public Transform cam;
    private Rigidbody[] rb_AR;
    private RaycastHit hit;
    private Animation anim;
   
void Start()
{
    anim = GetComponent<Animation>();
    rb_AR = GetComponentsInChildren<Rigidbody>();
    foreach(Rigidbody rb in rb_AR)
    {
        rb.tag = "ragdoll";
        rb.isKinematic = true;
    }


}

    void OnTriggerEnter(Collider col)     //попадание шаром
    {
       if(col.name == "pulya(Clone)")
       {
        anim.enabled = false;
      Debug.Log("ddd"); 
       foreach(Rigidbody rb in rb_AR)
    {
        rb.tag = "ragdoll";
        rb.isKinematic = false;
    }
     GetComponent<MovingOrk>().enabled = false;
    GetComponent<NavMeshAgent>().speed = 0;
    Doctor.GetComponent<GO>().KillBill();
       }
    }


}
