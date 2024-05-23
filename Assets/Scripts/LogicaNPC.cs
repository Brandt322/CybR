using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class LogicaNPC : MonoBehaviour
{
    public GameObject simboloMision;
    public CharacterAnimations jugador;
    public GameObject panelNPC;
    public GameObject panelNPC2;
    public GameObject panelNPCMision;
    public TextMeshProUGUI textoMision;
    public bool jugadorCerca;
    public bool aceptarMision;
    public GameObject[] Objetivos;
    public int numeroObjetivos;
    public GameObject botonMision;

    void Start()
    {
        numeroObjetivos = Objetivos.Length;
        textoMision.text = "Destruye todos los portales " +
                             "\n Portales Restantes: " + numeroObjetivos;
        jugador = GameObject.FindGameObjectWithTag("Player").GetComponent<CharacterAnimations>();
        simboloMision.SetActive(false);
        panelNPC.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.X) && aceptarMision == false)
        {
            Vector3 posicionJugador = new Vector3(transform.position.x, jugador.gameObject.transform.position.y, transform.position.z);
            jugador.gameObject.transform.LookAt(posicionJugador);
            
            jugador.anim.SetFloat("VelX", 0);
            jugador.anim.SetFloat("VelY", 0);
            jugador.enabled = false;
            panelNPC.SetActive(false);
            panelNPC2.SetActive(true);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            jugadorCerca = true;
            if (aceptarMision == false)
            {
                panelNPC.SetActive(true);
            }  
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            jugadorCerca = false;
            panelNPC.SetActive(false);
            panelNPC2.SetActive(false);
        }
    }

    public void Salir(){
        jugador.enabled = true;
        panelNPC2.SetActive(false);
        panelNPC.SetActive(true);
    }

    public void Aceptar(){
        jugador.enabled = true;
        aceptarMision = true;
        for(int i=0; i< Objetivos.Length; i++)
        {
            Objetivos[i].SetActive(true);
        }
        jugadorCerca = false;
        simboloMision.SetActive(false);
        panelNPC.SetActive(false);
        panelNPC2.SetActive(false);
        panelNPCMision.SetActive(true);
    }
}

