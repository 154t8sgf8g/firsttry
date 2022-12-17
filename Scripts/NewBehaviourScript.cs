using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NewBehaviourScript : MonoBehaviour
{
    private float item = 0;
    public TMP_Text itemsText;

    private void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "item")
        {
            item++;
            itemsText.text = item.ToString();
            Destroy(coll.gameObject);
        }
    }
}
