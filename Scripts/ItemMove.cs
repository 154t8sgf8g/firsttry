using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemMove : MonoBehaviour
{
   [SerializeField] GameObject item;
   [SerializeField] float speed;

   void FixedUpdate()
   {
    item.transform.Translate(speed * 0, -Time.deltaTime, 0);
   }
}
