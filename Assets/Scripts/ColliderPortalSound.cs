using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColliderPortalSound : MonoBehaviour
{
    public AudioSource transitionPortal;
    // Start is called before the first frame update
    void Start()
    {
        transitionPortal = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Player")
        {
            transitionPortal.Play();
        }        
    }
}
