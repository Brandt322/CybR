using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntrarAuto : MonoBehaviour
{
    public GameObject player;
    public GameObject camaraVehiculo;
    public bool puedoEntrar;
    public CarController vehicleControl;
    public GameObject salirVehiculo;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            entrarVehiculo();
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            player = other.gameObject;
            puedoEntrar = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if(other.tag == "Player")
        {
            player = other.gameObject;
            puedoEntrar = false;
        }
    }

    public void entrarVehiculo()
    {
        if(puedoEntrar)
        {
            player.SetActive(false);
            camaraVehiculo.SetActive(true);
            vehicleControl.enabled = true;
            salirVehiculo.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
