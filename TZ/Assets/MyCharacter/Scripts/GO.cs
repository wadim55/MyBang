using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.AI;

public class GO : MonoBehaviour
{
  public GameObject plane, VirtCam1, VirtCam2, VirtCam3, ButtonRestart, blood, textFire;
    int cubeLayerIndex;
   private NavMeshAgent agent;
    public Camera camera;
    public Vector3 touchWayBegin;
    Vector3 touchWayEnd;


     
   

    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        VirtCam1.SetActive(true);
        VirtCam2.SetActive(false);
        VirtCam3.SetActive(false);
        cubeLayerIndex = LayerMask.NameToLayer("goblin");
         touchWayEnd = transform.position;
         ButtonRestart.SetActive(false);
    }

  private void OnTriggerEnter(Collider col)  //вход на башню
    {
     
 if(col.name == "trigger")
 {
        plane.layer = cubeLayerIndex;
        agent.updateRotation = false;
        VirtCam1.SetActive(false);
        VirtCam2.SetActive(true);
        GetComponent<Shooting>().enabled = true;
        textFire.SetActive(true);

 }
    }

      private void OnTriggerExit(Collider col)  //выход с башни
    {
        plane.layer = 0;
        agent.updateRotation = true;
        VirtCam1.SetActive(true);
        VirtCam2.SetActive(false);
         GetComponent<Shooting>().enabled = false;
         textFire.SetActive(false);
    }

    public void KillBill() //попадание по орку
{
        VirtCam3.SetActive(true);
        VirtCam1.SetActive(false);
        VirtCam2.SetActive(false);
        blood.SetActive(true);
        Invoke("Button", 3f);
}

void Button()
{ 
  ButtonRestart.SetActive(true);  
}

 
    void Update()
    {
        if(Input.GetMouseButtonDown(0) && !EventSystem.current.IsPointerOverGameObject()) // если мышка нажата и нажатие произошло по игровому объекту
        {
          RaycastHit hit;
            int layerMask = (1 << cubeLayerIndex);  // объявляем слой, который будет игнорироваться райкастом
            layerMask = ~layerMask;
            if (Physics.Raycast(camera.ScreenPointToRay(Input.mousePosition), out hit, Mathf.Infinity, layerMask))
            {
                agent.SetDestination(hit.point);
                 touchWayEnd = hit.point; 
            }
          
        }
         touchWayBegin = transform.position - touchWayEnd;
    }
  
}