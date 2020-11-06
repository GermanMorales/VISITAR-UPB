using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EdificioAScript : MonoBehaviour
{
    public GameObject Arrow;
    Quaternion haciefruteria =  Quaternion.Euler(20,40,180);
    Quaternion haciaedificiob =  Quaternion.Euler(1,200,20);
    Quaternion haciatemplo =  Quaternion.Euler(50,120,80);

    // Start is called before the first frame update
    void Start()
    {

        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Found()
    {
        Debug.Log ("Found");
    }

    void changeArrowPosition()
    {
        Arrow.transform.rotation = haciefruteria;
    }
}
