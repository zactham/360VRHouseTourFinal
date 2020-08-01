using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Logo : MonoBehaviour
{
    public GameObject maincam;

    // Update is called once per frame
    void Update()
    {
        float speed = 50f;
        //transform.Rotate(Vector3.up * Time.deltaTime * speed);
        //transform.rotation = Quaternion.RotateTowards(maincam.transform.rotation, Quaternion.Euler(0, 180, 0), speed * Time.deltaTime);
        //this.transform.Rotate(0, maincam.transform.position.y, 0, Space.Self);
    }
}
