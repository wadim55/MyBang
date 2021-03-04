using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationDoctor : MonoBehaviour
{
   
  public  Vector3 way;
    private Animator anim;
    public GameObject Doctor;
   

private void Start()
{
    anim = GetComponent<Animator>();
}
  

    private void Update()
    {
   
        way = Doctor.GetComponent<GO>().touchWayBegin;
        anim.SetFloat("perehod", way.magnitude);
    }
  
}
        

    
