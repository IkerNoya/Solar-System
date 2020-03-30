using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planets : MonoBehaviour
{
    public Transform Sun;
    public Orbit pos;
    public Vector3 radius;
    public float angle = 90.0f;
    public float traslationSpeed; // velocidad a la que crece el angulo
    public float rotationSpeed = 0.5f;

    void Start()
    {
        radius = this.transform.position - pos.pos;
    }

    void Update()
    {

        angle += Time.deltaTime * traslationSpeed;

        Vector3 NewPos = Vector3.zero;
     
        NewPos.x = Sun.position.x + radius.z * Mathf.Cos(angle * Mathf.Deg2Rad);
        NewPos.z = Sun.position.z + radius.z * Mathf.Sin(angle * Mathf.Deg2Rad);

        transform.position = NewPos;
        
        transform.Rotate(0, rotationSpeed, 0);
        
        
    }
}
