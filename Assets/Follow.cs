using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Follow : MonoBehaviour
{
    // public Transform eyes;
    // public float spawnDistance = 3;
    public GameObject menu;
    public InputActionProperty showButton;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(showButton.action.WasPerformedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);

           // menu.transform.position = eyes.position + new Vector3(eyes.forward.x, 0, eyes.forward.z).normalized * spawnDistance;
        }

        // menu.transform.LookAt(new Vector3(eyes.position.x, menu.transform.position.y, eyes.position.z));
        // menu.transform.forward *= -1;
    }
}
