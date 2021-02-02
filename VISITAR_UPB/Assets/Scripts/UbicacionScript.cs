using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class UbicacionScript : MonoBehaviour
{
    public GameObject Arrow;
    /*[SerializeField]
    private List<Nodes> m_Nodes = new List<Nodes> ();*/
    [SerializeField]
    private List<Ubicacion> m_Ubicaciones = new List<Ubicacion> ();
    protected Node nextnode;
    private int listLength;
    public TextMeshPro Indicacion;

    private float smooth = 5f;
    
    



    public virtual List<Ubicacion> ubicacion
    {
        get
        {
            return m_Ubicaciones;
        }
    }
    

    void changeArrowPosition()
    {
        //apunta hacia el primer nodo de la lista
       // Arrow.transform.rotation = m_Ubicaciones[0].quaternion;
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
        listLength = m_Ubicaciones.Count;
        for (int i = 0; i < listLength ; i++)
        {
            if (nextnode.name == m_Ubicaciones[i].nombre)
            {
                if (m_Ubicaciones[i].apodo == null)
                {
                    m_Ubicaciones[i].apodo = m_Ubicaciones[i].nombre;
                }
            Arrow.SetActive(true);
            //Arrow.transform.rotation = m_Ubicaciones[i].quaternion;
            Arrow.transform.rotation = Quaternion.Euler(m_Ubicaciones[i].rotacion[0],m_Ubicaciones[i].rotacion[1], m_Ubicaciones[i].rotacion[2]);
            /*
            Quaternion target = Quaternion.Euler(m_Ubicaciones[i].rotacion[0],m_Ubicaciones[i].rotacion[1], m_Ubicaciones[i].rotacion[2]);
            Arrow.transform.rotation = Quaternion.Slerp(Arrow.transform.rotation, target, Time.fixedDeltaTime* smooth);
            */
            //Arrow.transform.eulerAngles = new Vector3(m_Ubicaciones[i].rotacion[0],m_Ubicaciones[i].rotacion[1], m_Ubicaciones[i].rotacion[2]));

           
            
            Indicacion.text = "Siguiente Punto: \n" + m_Ubicaciones[i].apodo + "\n" + m_Ubicaciones[i].direccion;
            
            }
        }            
    }

    public void DeleteIndications()
    {
        Arrow.SetActive(false);
        Indicacion.text = "";

    }
}
