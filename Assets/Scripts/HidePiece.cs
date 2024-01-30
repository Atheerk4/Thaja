// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class HidePiece : MonoBehaviour
// {
//      private float timer = 0f;

//     public void StartTimer()
//     {
//         timer = Time.time;
//     }

//     private void Update()
//     {
//         // If the item has been visible for 5 seconds, hide it
//         if (timer >= 5f)
//         {
//             transform.parent.gameObject.SetActive(false);  // إخفاء الأيتم وليس الكائن بأكمله
//         }
//     }
// }