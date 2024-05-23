using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LogicaObjetivosPortales : MonoBehaviour
{
    public LogicaNPC npc;
    // public int numeroObjetivos;
    // public TextMeshProUGUI textoMision;
    // public GameObject botonMision;
    // Start is called before the first frame update
    void Start()
    {
    //    numeroObjetivos = GameObject.FindGameObjectsWithTag("Objetivo").Length;
    //    textoMision.text = "Recolecta todos los portales " +
    //                         "\n Portales Restantes: " + numeroObjetivos; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider col)
    {
        // if(col.gameObject.tag == "Objetivo")
        // {
        //     Destroy(col.transform.parent.gameObject);
        //     numeroObjetivos--;
        //     textoMision.text = "Destruye todos los portales " +
        //                     "\n Portales Restantes: " + numeroObjetivos;
        //     if(numeroObjetivos <= 0)
        //     {
        //         textoMision.text = "Misión Completada";
        //         botonMision.SetActive(true);
        //     }
        // }
        if (col.tag == "Player")
        {
            npc.numeroObjetivos--;
            npc.textoMision.text = "Destruye todos los portales " +
                                "\n Portales Restantes: " + npc.numeroObjetivos;
            if(npc.numeroObjetivos <= 0){
                npc.textoMision.text = "Misión Completada";
                npc.botonMision.SetActive(true);
            }
            transform.parent.gameObject.SetActive(false);
        }
    }
}
