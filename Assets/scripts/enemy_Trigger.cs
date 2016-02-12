using UnityEngine;
using System.Collections;

public class enemy_Trigger : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }
    void OnTriggerEnter(Collider2D Collider2D)
    {

        

        if (Collider2D.name == "Enemy")
        {

            Destroy(gameObject);

        }
    }
}

   