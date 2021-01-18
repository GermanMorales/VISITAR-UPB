using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void showOptions(GameObject options)
    {
        options.SetActive(!options.activeSelf);
      
    }

    
}