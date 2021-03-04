using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class GetSettings : MonoBehaviour
{
   [SerializeField] List<Settings> Set = new List<Settings>();
public GameObject PrefabPulya;
public void Sett(int number)
{
GetComponent<NavMeshAgent>().speed = Set[number].DoctorSpeed;

GetComponent<Shooting>().ChangePauseOfShoot = Set[number].PulyaSpeed;

PrefabPulya.GetComponent<Rigidbody>().mass = Set[number].PuliyMass;

}

}
