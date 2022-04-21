using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetFogRadius : MonoBehaviour
{
    private float _firstCircleRadius = 8;
    private float _SecondCircleRadius = 5;
    
    // Start is called before the first frame update
    void Start()
    {
        Shader.SetGlobalFloat("_FirstCircleRadius", _firstCircleRadius);
        Shader.SetGlobalFloat("_SecondCircleRadius", _SecondCircleRadius);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
