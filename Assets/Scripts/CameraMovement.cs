using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour
{
    public float cameraSpeed;
    float timeLeft = 0f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position - new Vector3(0, cameraSpeed * Time.deltaTime-0.04f, 0);

        timeLeft += Time.deltaTime;
        if(timeLeft >10)
        {
            transform.position = transform.position - new Vector3(0,35,0);
            timeLeft=0;
        }
    }
}
