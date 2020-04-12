using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    float timer = 0;
    public float timerLimit = 3.0f;
    public List<GameObject> planets = new List<GameObject>();
    int currentPlanet = 0;
    public Vector3 offset;
    public float camSpeed = 1;

    private Vector3 lastCamPos;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        if (planets.Count<=0)
        {
            return;
        }

        timer += Time.deltaTime;

        if (timer > timerLimit)
        {
            timer = 0;
            currentPlanet++;
            currentPlanet = currentPlanet % planets.Count;
            timer = 0;
            lastCamPos = transform.position;
        }
        Vector3 NewPos = planets[currentPlanet].transform.position + offset;

        transform.position = Vector3.Lerp(transform.position, NewPos, camSpeed * Time.deltaTime);
        
    }
}
