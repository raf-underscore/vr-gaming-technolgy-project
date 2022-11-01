using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnParticle : MonoBehaviour
{
    public GameObject particleSystem;

    public void SpawnParticles()
    {
        Instantiate(particleSystem, transform.position, Quaternion.identity);
    }
}
