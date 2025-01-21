using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlowZones : MonoBehaviour
{
    public int velocidad = -3;
    void OnTriggerStay2D(Collider2D other)
    {

        PlayerController controller = other.GetComponent<PlayerController>();


        /*if (controller != null)
        {
            controller.ChangeSpeed(velocidad);
            Destroy(gameObject);
        }*/
    }
}
