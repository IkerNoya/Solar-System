using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace solarSystem
{
    public class Movement : MonoBehaviour
    {

        public float speed = 1;
        public float rotationSpeed = 1;

        void Update()
        {
            float vertical = Input.GetAxis("Vertical");
            float horizontal = Input.GetAxis("Horizontal");
            Vector3 movement = new Vector3(horizontal, 0, vertical) * speed;
            transform.position += movement * Time.deltaTime;

            Vector3 currentPos = transform.position;
            Vector3 wantedPos = transform.position + movement * Time.deltaTime;

            float realAngle = RealAngle(currentPos, wantedPos);

            Quaternion currentRotation = transform.rotation;
            Quaternion newRotation = Quaternion.Euler(0, realAngle, 0);
            Quaternion result = Quaternion.Slerp(currentRotation, newRotation, rotationSpeed * Time.deltaTime);

            if (Mathf.Abs(horizontal) > 0.001f || Mathf.Abs(vertical) > 0.001f)
            {
                transform.rotation = result;
            }
        }
        public float RealAngle(Vector3 from, Vector3 to)
        {
            Vector3 x = Vector3.right; // se llama x porque solo tiene valores en la x, el cual es 1
            Vector3 direction = to - from;

            float angle = Vector3.Angle(x, direction);
            Vector3 cross = Vector3.Cross(x, direction);

            if (cross.y < 0)
            {
                angle = 360 - angle;
            }
            return angle;
        }
    }

}