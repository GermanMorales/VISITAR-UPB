using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UbicacionScript : MonoBehaviour
{
    public GameObject Arrow;
    [SerializeField]
    private List<Nodes> m_Nodes = new List<Nodes> ();

    public virtual List<Nodes> nodes
    {
        get
        {
            return m_Nodes;
        }
    }
    
    public void Found()
    {
        Debug.Log ("Found");
    }

    void changeArrowPosition()
    {
        //apunta hacia el primer nodo de la lista
        Arrow.transform.rotation = m_Nodes[0].quaternion;
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
