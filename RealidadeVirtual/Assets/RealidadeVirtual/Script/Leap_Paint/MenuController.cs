using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuController : MonoBehaviour
{

    public GameObject cubeMenu;
    public GameObject cubeCores;
    public bool control = true;

    public TrailRenderer trailPrefab;

    // Start is called before the first frame update
    void Start()
    {
        trailPrefab.startColor = Color.white;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SetActive()
    {
        cubeMenu.SetActive(control);
        cubeCores.SetActive(false);
        control = !control;
    }

    public void ActivateColor()
    {
        cubeMenu.SetActive(false);
        cubeCores.SetActive(true);
    }

    public void SetRedColor()
    {
        print("Vermelho");
        trailPrefab.startColor = Color.red;
        trailPrefab.endColor = Color.red;
    }

    public void SetGreenColor()
    {
        print("Verde");
        trailPrefab.startColor = Color.green;
        trailPrefab.endColor = Color.green;
    }

    public void SetBlueColor()
    {
        print("Azul");
        trailPrefab.startColor = Color.blue;
        trailPrefab.endColor = Color.blue;
    }

    public void SetTrailWidth()
    {
        trailPrefab.widthMultiplier = 1;
    }
}
