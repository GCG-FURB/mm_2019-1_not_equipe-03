using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class Drawaline : MonoBehaviour
{
    public GameObject trail;

    public GameObject Finger;

    public GameObject CurrentTrail;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void StopDraw()
    {
        StopAllCoroutines();
    }

    public void instatiateTrail()
    {
        CurrentTrail = Instantiate(trail, Finger.transform.position, Quaternion.identity);
        StartCoroutine(Draw());
    }

    IEnumerator Draw()
    {
        while (true)
        {
            CurrentTrail.transform.position = new Vector3(Finger.transform.position.x, Finger.transform.position.y, Finger.transform.position.z);
            yield return null;
        }
        
    }

}
