using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scale : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        this.transform.localScale = this.transform.localScale - new Vector3(0.1f, 0.1f, 0.1f) * Time.deltaTime;       
    }  
}
