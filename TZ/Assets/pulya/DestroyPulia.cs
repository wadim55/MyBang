using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyPulia : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("Dest", 2f);
    }

    // Update is called once per frame
    void Dest()
    {
        Destroy(gameObject);
    }
}
