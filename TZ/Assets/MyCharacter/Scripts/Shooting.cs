using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    public float speed;
    public GameObject pulia;
    public Transform Spawn;
    public Transform trans;
    float PauseOfShoot; //пауза междувыстрелами призажатой кнопке мыши

   public float ChangePauseOfShoot = 1f;
       
       
       void Update()
       {
           float h = speed*Input.GetAxis("Mouse X");
           transform.Rotate(0, h, 0);
         
         if(Input.GetMouseButtonDown(0))  //одиночные выстрелы
         {
             var tratata =  Instantiate(pulia, Spawn.position, transform.rotation);
          Vector3 vec = trans.position - Spawn.position;
          tratata.GetComponent<Rigidbody>().velocity = vec*8;
          PauseOfShoot = 0;
         }
         
         
          if(Input.GetMouseButton(0))  //стрельба очередью
          {
            PauseOfShoot +=Time.deltaTime;
            if(PauseOfShoot > ChangePauseOfShoot)
            {
            var tratata =  Instantiate(pulia, Spawn.position, transform.rotation);
          Vector3 vec = trans.position - Spawn.position;
          tratata.GetComponent<Rigidbody>().velocity = vec*8;
          PauseOfShoot = 0;
            }
          }

       }



      
}
