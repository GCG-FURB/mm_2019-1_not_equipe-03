using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuController : MonoBehaviour
{

    public GameObject cubeMenu;
    public GameObject cubeCores;
    public GameObject cubeFinalizar;
    public bool control = true;

    private bool red, green, blue = false;

    public TrailRenderer trailPrefab;

    public Material redCube,greenCube,blueCube;

    // Start is called before the first frame update
    void Start()
    {
        trailPrefab.startColor = Color.white;
        redCube.color = new Color(255, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if (red && blue && green)
        {
            trailPrefab.startColor = Color.white;
            trailPrefab.endColor = Color.white;
        }
        else if (red && blue)
        {
            trailPrefab.startColor = Color.magenta;
            trailPrefab.endColor = Color.magenta;
        }
        else if (blue && green)
        {
            trailPrefab.startColor = Color.cyan;
            trailPrefab.endColor = Color.cyan;
        }
        else if (red && green)
        {
            trailPrefab.startColor = Color.yellow;
            trailPrefab.endColor = Color.yellow;
        }
        else if (red)
        {
            trailPrefab.startColor = Color.red;
            trailPrefab.endColor = Color.red;
        }
        else if (green)
        {
            trailPrefab.startColor = Color.green;
            trailPrefab.endColor = Color.green;
        }
        else if (blue)
        {
            trailPrefab.startColor = Color.blue;
            trailPrefab.endColor = Color.blue;
        }
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
        red = !red;
        print("red" + red);
        
    }

    public void SetGreenColor()
    {
        green = !green;
        print("green" + green);
    }

    public void SetBlueColor()
    {
        blue = !blue;
        print("blue" + blue);
    }

    public void SetYellowColor()
    {
        if (red && green)
        {
            print("Amarelo");
            trailPrefab.startColor = Color.yellow;
            trailPrefab.endColor = Color.yellow;
        }
    }

    public void SetCyanColor()
    {
        print("Ciano");
        trailPrefab.startColor = Color.cyan;
        trailPrefab.endColor = Color.cyan;
    }

    public void SetMagentaColor()
    {
        print("Magenta");
        trailPrefab.startColor = Color.magenta;
        trailPrefab.endColor = Color.magenta;
    }

    public void SetTrailWidth()
    {
        trailPrefab.widthMultiplier = 1;
    }

    public void ActivateFinish()
    {
        cubeMenu.SetActive(false);
        cubeFinalizar.SetActive(true);
    }

    public void changeToWriteScene()
    {
        SceneManager.LoadScene("Pc_Write");
    }
}
