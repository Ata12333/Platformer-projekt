using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillPlayer : MonoBehaviour
{
    Vector3 stratPos;
    // Start is called before the first frame update
    void Start()
    {
        stratPos = transform.position;
    }

    private void OnTriggerEnter(Collider Collision)
    {
        if (Collision.CompareTag("Car"))
        {
            Die();
        }
    }

    void Die ()
    {
        Respawn();
    }

    void Respawn()
    {
        transform.position = stratPos;
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
