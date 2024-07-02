using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SalirAuto : MonoBehaviour
{
    public EntrarAuto entrarAuto;
    public GameObject player;
    public GameObject camaraVehiculo;
    public CarController vehicleControl;
    // Start is called before the first frame update
    void Start()
    {
        player = entrarAuto.player;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.C))
        {
            salirVehiculo();
        }
    }
    public void salirVehiculo()
    {
        player.SetActive(true);
        player.transform.position = gameObject.transform.position;
        camaraVehiculo.SetActive(false);
        vehicleControl.enabled = false;
        entrarAuto.gameObject.SetActive(true);
        gameObject.SetActive(false);
    }
}
