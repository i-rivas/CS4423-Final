using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemCollector : MonoBehaviour
{
    private int crystals = 0;

    [SerializeField] private Text crytalsText;

    private void OnTriggerEnter2D(Collider2D collision) 
    {
        if (collision.gameObject.CompareTag("Crystal"))
        {
            Destroy(collision.gameObject);
            crystals++;
            crytalsText.text = "Crystals: " + crystals;
        }
    }
        
    
}
