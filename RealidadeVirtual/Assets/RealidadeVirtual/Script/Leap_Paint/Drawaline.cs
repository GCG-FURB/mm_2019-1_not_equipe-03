using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Leap;

public class Drawaline : MonoBehaviour
{
    public TrailRenderer trail;

    public GameObject Finger;

    public TrailRenderer CurrentTrail;

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
        Vector3[] venctors = new Vector3[this.CurrentTrail.positionCount];
        this.CurrentTrail.GetPositions(venctors);
        
        
        Debug.Log(venctors);
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
