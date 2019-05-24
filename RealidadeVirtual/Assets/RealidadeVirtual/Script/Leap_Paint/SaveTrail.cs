using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaveTrail : MonoBehaviour
{
    [SerializeField]
    public Vector3[] Trails = new Vector3[90000];

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void SaveTrails()
    {
        TrailRenderer[] ListaTrails = FindObjectsOfType<TrailRenderer>();
        Debug.Log(ListaTrails[0]);

        for(int i = 0; i < ListaTrails.Length; i++)
        {
            ScenePaintLeap.Instance.AddTrailRenderer(ListaTrails[i]);
        }

        PersistController.Instance.PersistEverything();
    }
}













