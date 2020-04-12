using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instantiate : MonoBehaviour
{
    public CameraScript cam;

    public Planets PlanetPrefab;

    public List<Material> PlanetMaterial;
    public Material[] planetMaterialsAsArray;

    public List<Planets> createPlanets = new List<Planets>();

    public float MovemetSpeed = 1;

     
    void Start()
    {
        for (int i = 0; i < 10; i++)
        {
            GameObject obj = Instantiate(PlanetPrefab, new Vector3(i * 2.0f, 0, 0), Quaternion.identity).gameObject;
            Planets planets = obj.GetComponent<Planets>();
            int indexLimit = i % PlanetMaterial.Count;
            obj.GetComponent<MeshRenderer>().material = PlanetMaterial[indexLimit];

            planets.radius = i * 3;
            planets.Sun = gameObject.transform;
            planets.traslationSpeed = MovemetSpeed;
            

            createPlanets.Add(planets);
            cam.planets.Add(obj);
        }
    }

    public Vector3 from;
    public Vector3 to;

    void Update()
    {

    }

}
