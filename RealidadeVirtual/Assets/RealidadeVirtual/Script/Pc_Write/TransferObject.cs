using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferObject : MonoBehaviour
{
    public static TransferObject Instance = null;

    public List<GameObject> trails = new List<GameObject>();

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(this.gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
