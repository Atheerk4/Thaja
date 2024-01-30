using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;

public class Drilling : MonoBehaviour
{
    public ParticleSystem particles;

    public LayerMask layerMask;
    public Transform digSource;
    public float distance = 10;

    private bool rayActivate = false;
    void Start()
    {
        XRGrabInteractable grabInteractable = GetComponent<XRGrabInteractable>();
        grabInteractable.activated.AddListener(x => StartDig());
        grabInteractable.activated.AddListener(x => StopDig());
        
    }

    public void StartDig()
    {
        particles.Play();
        rayActivate = true;
    }

    public void StopDig()
    {
        particles.Stop(true, ParticleSystemStopBehavior.StopEmittingAndClear);
        rayActivate = false;
    }

    
    void Update()
    {
        if(rayActivate)
        RaycastCheck();
    }

    void RaycastCheck()
    {
        RaycastHit hit;
        bool hasHit = Physics.Raycast(digSource.position, digSource.forward, out hit, distance, layerMask);

        if(hasHit)
        {
            hit.transform.gameObject.SendMessage("Break", SendMessageOptions.DontRequireReceiver);
        }
    }
}
