using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CogerArmas : MonoBehaviour
{
    public GameObject[] armas;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       if(Input.GetKeyDown(KeyCode.E))
       {
           DesactivarArma(0);
       }
    }

    public void ActivarArma(int numero)
    {
        for(int i=0; i<armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
        armas[numero].SetActive(true);
    }

    public void DesactivarArma(int numero)
    {
        for(int i=0; i<armas.Length; i++)
        {
            armas[i].SetActive(false);
        }
    }

}
