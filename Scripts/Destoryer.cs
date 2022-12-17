using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Destoryer : MonoBehaviour
{
void OnTriggerEnter2D(Collider2D other)
{
    if(other.gameObject.tag == "item")
    {
        Destroy(other.gameObject);
    }
}
}