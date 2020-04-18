using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace solarSystem
{
    public class Camera1 : MonoBehaviour
    {
        private float timer = 0;
        public float timerLimit = 3.0f;
        public GameObject ship;
        public Transform Ship;
        public List<GameObject> planets = new List<GameObject>();
        int currentPlanet = 0;
        public Vector3 offset;
        public float camSpeed = 1;
        bool shipCam = false;
        bool planetCam = false;

        private Vector3 lastCamPos;
        Vector3 NewPos;


        private void Update()
        {
            if (Input.GetKeyUp(KeyCode.Alpha0))
            {
                shipCam = true;
                planetCam = false;
            }
            if (Input.GetKeyUp(KeyCode.Alpha1) || Input.GetKeyUp(KeyCode.Alpha2)|| Input.GetKeyUp(KeyCode.Alpha3))
            {
                shipCam = false;
                planetCam = true;
            }
            if (shipCam == true && planetCam == false)
            {
                offset.y = 5;
                offset.z = -4;
                transform.LookAt(Ship);
                NewPos = ship.transform.position + offset;
                transform.position = Vector3.Lerp(transform.position, NewPos, camSpeed * Time.deltaTime);
            }

        }
        void LateUpdate()
        {

            if (planets.Count <= 0)
            {
                return;
            }
            timer += Time.deltaTime;
            if (timer > timerLimit && planetCam == false)
            {
                timer = 0;
            }
            if (planetCam == true && shipCam == false) 
            {
                offset.y = 0;
                offset.z = -4;
                GetComponent<Transform>().eulerAngles = new Vector3(0, 0, 0);
                NewPos = planets[currentPlanet].transform.position + offset;
                if (timer>timerLimit)
                {

                    timer = 0;
                    currentPlanet++;
                    currentPlanet = currentPlanet % planets.Count;
                    NewPos = planets[currentPlanet].transform.position + offset;

                }
                transform.position = Vector3.Lerp(transform.position, NewPos, camSpeed * Time.deltaTime);
            }
            Debug.Log(timer);

        }
    }

}
