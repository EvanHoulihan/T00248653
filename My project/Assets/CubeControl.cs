using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
            transform.position += transform.forward * Time.deltaTime ;

        if (Input.GetKey(KeyCode.S))
            transform.position += (new Vector3(0, -1, 0)) * Time.deltaTime;

        if (Input.GetKey(KeyCode.A))
            transform.position += (new Vector3(-1, 0, 0)) * Time.deltaTime;

        if (Input.GetKey(KeyCode.D))
            transform.position += (new Vector3(1, 0, 0)) * Time.deltaTime;
                
        if (Input.GetKey(KeyCode.LeftArrow))
            transform.Rotate(Vector3.up, 50 * Time.deltaTime);

        if (Input.GetKey(KeyCode.RightArrow))
            transform.Rotate(Vector3.down, 50 * Time.deltaTime);
    }
}
