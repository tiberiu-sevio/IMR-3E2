using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CactusActions : MonoBehaviour
{
    public GameObject Cactus;
    // Start is called before the first frame update
    void Start()
    {
        Cactus = GameObject.FindGameObjectWithTag("Cactus");
        Cactus.GetComponent<MeshRenderer>().enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
