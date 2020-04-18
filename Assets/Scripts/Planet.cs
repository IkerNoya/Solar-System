using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace solarSystem
{
    public class Planet : MonoBehaviour
    {
        public Transform Sun;
        public Orbit pos;
        public float radius = 5;
        public float angle = 90.0f;
        public float traslationSpeed = 1; // velocidad a la que crece el angulo
        public float rotationSpeed = 0.5f;

        void Update()
        {

            angle += Time.deltaTime * traslationSpeed;

            Vector3 NewPos = Vector3.zero;

            NewPos.x = Sun.position.x + radius * Mathf.Cos(angle * Mathf.Deg2Rad);
            NewPos.z = Sun.position.z + radius * Mathf.Sin(angle * Mathf.Deg2Rad);

            transform.position = NewPos;

            transform.Rotate(0, rotationSpeed, 0);


        }
    }
}