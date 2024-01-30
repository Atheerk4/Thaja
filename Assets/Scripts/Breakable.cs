using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Breakable : MonoBehaviour
{
   public List<GameObject> breakablePieces;
void Awake()
    {
        foreach (var item in breakablePieces)
        {
            item.SetActive(false);
        }
    }

    
    void OnTriggerEnter(Collider other)
{
    if (other.gameObject.CompareTag("Player"))
    {
       int count = breakablePieces.Count;

       print(" "+ count);
        count = 0;
        foreach (var item in breakablePieces)
        {
            count++;
            print("new" + count);
            item.SetActive(true);
        }
       // gameObject.SetActive(false);
    

        Destroy(gameObject,5f);

    }
}

// void showSand()
// {

// }

    // IEnumerator startactive()
    // {
    //     int length = breakablePieces.count;

    //     while()
    // }
}
   
