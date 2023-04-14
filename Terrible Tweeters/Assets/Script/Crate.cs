using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crate : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.magnitude > 2f)
        {
            GetComponent<AudioSource>().Play();
        }
        else
        {
            Debug.Log("Collision was too slow to make a sound " + collision.relativeVelocity.magnitude);
        }
    }
}
