using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace solarSystem
{
    public class Camera : MonoBehaviour
    {
        private float timer = 0;
        public float timerLimit = 3.0f;
        public List<GameObject> planets = new List<GameObject>();
        int currentPlanet = 0;
        public Vector3 offset;
        public float camSpeed = 1;

        private Vector3 lastCamPos;

        void LateUpdate()
        {
            if (planets.Count <= 0)
            {
                return;
            }

            timer += Time.deltaTime;

            if (timer > timerLimit)
            {
                timer = 0;
                currentPlanet++;
                currentPlanet = currentPlanet % planets.Count;
                lastCamPos = transform.position;
            }
            Vector3 NewPos = planets[currentPlanet].transform.position + offset;

            transform.position = Vector3.Lerp(transform.position, NewPos, camSpeed * Time.deltaTime);

        }
    }

}
