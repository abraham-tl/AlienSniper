using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooting : MonoBehaviour
{
    RaycastHit hit;
    public AudioSource audioShooting;
    public AudioClip ShootinSniper;
    public ParticleSystem particle;
    public void Start()
    {
        particle.Pause(true);
        particle.Play(false);
    }
    public void ActiveShooting()
    {
        Physics.Raycast(FindObjectOfType<Camera>().transform.position, transform.TransformDirection(new Vector3(0, 0, 1)), out hit, 500);
        Debug.DrawRay(FindObjectOfType<Camera>().transform.position, transform.TransformDirection(new Vector3(0, 0, 1)) * 500, Color.red);
        audioShooting.PlayOneShot(ShootinSniper);
        particle.Play(true);
        if (hit.collider.gameObject.tag == "Enemy")
        {
            Destroy(hit.collider.gameObject);
        }
    }
}
