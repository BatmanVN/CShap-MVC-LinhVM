using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Rigidbody bulletRB;
    [SerializeField] private Transform spawn;
    [SerializeField] private AudioSource shotAudio;

    private void Fire()
    {
        GameObject tempBullet = Instantiate(bullet, spawn.position, spawn.rotation);
        bulletRB = tempBullet.GetComponent<Rigidbody>();
        bulletRB.AddForce(bulletRB.transform.forward * speed);
        shotAudio.Play();
        Destroy(tempBullet, 1f);
    }
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Fire();
        }
    }
}
