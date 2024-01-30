using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tags {
    public const string Player = "Player";
    public const string Box = "Box";
}


public class HideCollider : MonoBehaviour{
     private GameObject box;

    // تعريف طريقة التشغيل
    void Start() {
        // البحث عن كائن الصندوق
        box = GameObject.FindGameObjectWithTag(Tags.Box);
    }

    // تعريف طريقة معالجة الاصطدام
    void OnCollisionEnter(Collision collision) {
        // التحقق من أن الكائن الذي اصطدم هو اللاعب
        if (collision.gameObject.tag == Tags.Player) {
            // إخفاء البوكس كولايدر للصندوق
            box.GetComponent<BoxCollider>().enabled = false;
        }
}
}

