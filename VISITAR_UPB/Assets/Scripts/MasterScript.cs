using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class MasterScript : MonoBehaviour
{
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
