using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PorteriaScript : MonoBehaviour
{
    public GameObject Arrow;
    Quaternion haciatemplo =  Quaternion.Euler(20,40,180);
    Quaternion haciaedificiob =  Quaternion.Euler(1,200,20);
    Quaternion haciaedificioc =  Quaternion.Euler(1,200,20);
    Quaternion haciabiblioteca =  Quaternion.Euler(50,120,80);
    Quaternion haciaedificioj =  Quaternion.Euler(50,120,80);
    // Start is called before the first frame update
    void Start()
    {
        Arrow.transform.rotation = haciatemplo;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
