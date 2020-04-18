using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace solarSystem
{
    public class Instantiate : MonoBehaviour
    {
        public Camera cam;
    
        public Camera1 cam1;

        public Planet PlanetPrefab;

        public List<Material> PlanetMaterial;
        public Material[] planetMaterialsAsArray;

        public List<Planet> createPlanets = new List<Planet>();

        public float MovemetSpeed = 1;


        void Start()
        {
            for (int i = 0; i < 10; i++)
            {
                GameObject obj = Instantiate(PlanetPrefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity).gameObject;
                Planet planets = obj.GetComponent<Planet>();
                int indexLimit = i % PlanetMaterial.Count;
                obj.GetComponent<MeshRenderer>().material = PlanetMaterial[indexLimit];

                planets.radius = i * 3;
                planets.Sun = gameObject.transform;
                planets.traslationSpeed = MovemetSpeed;


                createPlanets.Add(planets);
                cam.planets.Add(obj);
                cam1.planets.Add(obj);
            }
        }

        public Vector3 from;
        public Vector3 to;

        void Update()
        {

        }

    }

}
