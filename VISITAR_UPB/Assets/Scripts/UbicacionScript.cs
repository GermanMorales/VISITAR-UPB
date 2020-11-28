using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UbicacionScript : MonoBehaviour
{
    public GameObject Arrow;
    [SerializeField]
    private List<Nodes> m_Nodes = new List<Nodes> ();
    protected Node nextnode;
    private int listLength;
    public TextMeshPro Indicacion;

    public virtual List<Nodes> nodes
    {
        get
        {
            return m_Nodes;
        }
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

    public void DoChanges(Node next)
    {
        nextnode = next;
        listLength = m_Nodes.Count;
        for (int i = 0; i < listLength ; i++)
        {
            if (nextnode.name == m_Nodes[i].nombre)
            {
                if (m_Nodes[i].apodo == null)
                {
                    m_Nodes[i].apodo = m_Nodes[i].nombre;
                }
            Arrow.transform.rotation = m_Nodes[i].quaternion;
            Indicacion.text = "Siguiente Punto: \n" + m_Nodes[i].apodo + "\n" + m_Nodes[i].direccion;
            }
        }            
    }
}
