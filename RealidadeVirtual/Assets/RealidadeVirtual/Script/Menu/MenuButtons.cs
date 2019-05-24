using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtons : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void NovaHistoria()
    {
        SceneManager.LoadScene("Pc_Write");
    }

    public void LerHistoria()
    {
        SceneManager.LoadScene("Pc_Reed");
    }

    public void DesenhoLivre()
    {
        SceneManager.LoadScene("Paint");
    }
}
