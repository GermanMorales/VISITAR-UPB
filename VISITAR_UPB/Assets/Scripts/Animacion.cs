using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Animacion : MonoBehaviour
{
    Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        anim =  GetComponent<Animator>();
    }

    public void Detected()
    {
        anim.SetTrigger("Detected");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
