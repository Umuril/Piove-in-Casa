using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float x = Mathf.Clamp(transform.parent.position.x, -16, 16);
        float y = Mathf.Clamp(transform.parent.position.y, -9, 9);

        transform.position = new Vector3(x, y, -10);
    }
}
