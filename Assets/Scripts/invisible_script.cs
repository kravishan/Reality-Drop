using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisible_script : MonoBehaviour
{
    Renderer test;
    // Start is called before the first frame update
    void Start()
    {
        test = GetComponent<MeshRenderer>();
        test.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
