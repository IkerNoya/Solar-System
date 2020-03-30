using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Orbit : MonoBehaviour
{

    public Vector3 pos;

    // Start is called before the first frame update
    void Start()
    {
        pos.z = this.transform.position.z;
        pos.x = this.transform.position.x;
        pos.y = this.transform.position.y;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0.05f, 0);
    }
}
