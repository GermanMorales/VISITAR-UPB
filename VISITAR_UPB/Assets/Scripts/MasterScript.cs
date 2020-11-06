using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MasterScript : MonoBehaviour
{
    public GameObject EdificioA;
    public GameObject EdificioB;
    public GameObject EdificioC;
    public GameObject EdificioD;
    public GameObject EdificioE;
    public GameObject EdificioF;
    public GameObject EdificioG;
    public GameObject EdificioH;
    public GameObject EdificioI;
    public GameObject EdificioJ;
    public GameObject EdificioK;
    public GameObject EdificioL;
    public GameObject Porteria;
    public GameObject Templo;
    public GameObject Biblioteca;
    public GameObject Fruteria;
    public GameObject Hueco;
    public GameObject Carretera;
    public GameObject Plaza;
    public GameObject Teatro;
    public GameObject Parqueadero;
    public GameObject Escaleras1;
    public GameObject Escaleras2;
    public GameObject Escaleras3;
    public GameObject EscalerasFork;

    public string Current;

    DefaultTrackableEventHandler defaultTrackableHandler;

    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    

    public void GetNameofObject()
    {
        Debug.Log(this.tag);
    }

}
