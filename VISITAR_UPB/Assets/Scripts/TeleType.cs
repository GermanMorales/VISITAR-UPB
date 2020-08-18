using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class TeleType : MonoBehaviour
{
    private TextMeshPro text;
    // Start is called before the first frame update
    IEnumerator Start()
    {
        text = gameObject.GetComponent<TextMeshPro>() ?? gameObject.AddComponent<TextMeshPro>();

        int totalVisibleCharacters = text.textInfo.characterCount;
        int counter = 0;
        
        int visibleCount = counter % (totalVisibleCharacters + 1);
        
        while (visibleCount < totalVisibleCharacters)
        {
            visibleCount = counter % (totalVisibleCharacters + 1);
            text.maxVisibleCharacters = visibleCount;
           
            counter++;
            
            yield return new WaitForSeconds(0.5f);

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
