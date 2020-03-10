using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RisingScript : MonoBehaviour
{
    
    public float RisingSpeed;
    public float TiltSpeed;

    private Vector3 PlatformStartPos;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.up * Time.deltaTime * RisingSpeed);
    }


}