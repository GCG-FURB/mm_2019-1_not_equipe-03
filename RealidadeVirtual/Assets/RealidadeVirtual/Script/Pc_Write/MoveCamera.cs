using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject CameraView;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCameraRigth()
    {
        if (CameraView.transform.position.x < 8000)
        {
            CameraView.transform.position = new Vector3(CameraView.transform.position.x + 900, CameraView.transform.position.y, CameraView.transform.position.z);
        }
    }

    public void MoveCameraLeft()
    {
        if (CameraView.transform.position.x > 800)
        {
            CameraView.transform.position = new Vector3(CameraView.transform.position.x - 900, CameraView.transform.position.y, CameraView.transform.position.z);
        }
    }
}
