using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdificioAScript : MonoBehaviour
{
    public GameObject Arrow;
    // Start is called before the first frame update
    void Start()
    {
        Arrow.transform.rotation = Quaternion.Euler(20,40,180);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
