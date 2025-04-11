using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Explosion : MonoBehaviour
{
        [SerializeField] private GameObject particle;
        [SerializeField] private GameObject explosion;
        [SerializeField] private string tag;
        public GameObject player;

    void OnCollisionEnter(Collision collision)
    {
        if (collision.collider.tag == tag)
        {
            explosion = Instantiate(particle,transform.position, transform.rotation);
        }
    }
}