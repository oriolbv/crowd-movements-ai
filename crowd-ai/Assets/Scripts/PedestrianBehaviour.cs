using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PedestrianBehaviour : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Material newMat = Resources.Load("RedMaterial", typeof(Material)) as Material;
        this.GetComponent<Renderer>().material = newMat;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
