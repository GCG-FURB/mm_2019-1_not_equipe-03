using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveCamera : MonoBehaviour
{
    public GameObject CameraView;
    private static int[] cameraPositions = new int[10];
    private static List<string> cameraScenes = new List<string>();
    public int contadorCenas = 0;

    // Start is called before the first frame update
    void Start()
    {
        int valorInicial = 460;
        for(int i = 0; i < 10; i++)
        {
            cameraPositions[i] = valorInicial;
            valorInicial += 750;
        }

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void MoveCameraRigth()
    {
        if (contadorCenas < 9) {
            contadorCenas++;
            CameraView.transform.position = new Vector3(cameraPositions[contadorCenas], CameraView.transform.position.y, CameraView.transform.position.z);
        }
        TransferObject.Instance.trails.ForEach(p => Debug.Log(p));
    }

    public void MoveCameraLeft()
    {
        if (contadorCenas > 0)
        {
            contadorCenas--;
            CameraView.transform.position = new Vector3(cameraPositions[contadorCenas], CameraView.transform.position.y, CameraView.transform.position.z);
        }

        
    }
}
