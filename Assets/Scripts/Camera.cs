using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera : MonoBehaviour
{
    float timer = 0;
    public float timerLimit = 3.0f;
    public GameObject[] planets;
    int currentPlanet = 0;
    public Vector3 offset;
    // Start is called before the first frame update
    void Start()
    {
        offset.x = 4.0f;
        offset.y = 0.0f;
        offset.z = 0.0f;
    }

    // Update is called once per frame
    void Update()
    {

        timer += Time.deltaTime;
        if (timer > timerLimit)
        {
            timer = 0;
            currentPlanet++;
            if (currentPlanet >= planets.Length)
            {
                currentPlanet = 0;
                timer = 0;
            }
        }
        Vector3 CurrentPos = transform.position;
        Vector3 NewPos = planets[currentPlanet].transform.position + offset;
        
        transform.position = Vector3.Lerp(CurrentPos, NewPos, 0.10f);
        
    }
}
