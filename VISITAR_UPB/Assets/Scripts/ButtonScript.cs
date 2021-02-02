using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public List<GameObject> helps = new List<GameObject>();

    [SerializeField]
    private GameObject nextbutton;

    [SerializeField]
    private GameObject backbutton;

    private int current = 0;

    public void showOptions(GameObject options)
    {
        options.SetActive(!options.activeSelf);
      
    }

    private void Update()
    {
        
    }


    public void nextbuttons()
    {   
        
        helps[current].SetActive(false);
        if (current == 5)
        {
            helps[0].SetActive(true);
            current = 0;
        }
        else{
            helps[current+1].SetActive(true);
            current++;
        }
    }

    public void backbuttons()
    {

        helps[current].SetActive(false);
        if (current == 0)
        {
            helps[5].SetActive(true);
            current = 5;
        }
        else{
            helps[current-1].SetActive(true);
            current--;
        }
    }

    public void CancelarDestino()
    {
        Graph graph = GameObject.Find("Graph").GetComponent<Graph>();
        
        graph.Nombredestinopantalla.text = "Destino: ";
        if (graph.m_From != null)
        {
            UbicacionScript uscript = graph.m_From.GetComponent<UbicacionScript>();
            uscript.DeleteIndications();
        }

	    
        graph.m_To = null;
    }

    
}