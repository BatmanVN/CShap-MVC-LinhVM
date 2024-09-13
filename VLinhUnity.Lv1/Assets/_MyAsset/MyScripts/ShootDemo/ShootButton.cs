using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ShootButton : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Rigidbody bulletRB;
    [SerializeField] private Transform spawn;
    [SerializeField] private AudioSource shotAudio;
    [SerializeField] private float rpm;
    //[SerializeField] private Pooling56 pool;
    public List<GameObject> bulletList;
    public UnityEvent onLook;
     private float interval;
    private float lastShot;
    private bool isShoot;
    private float timeShot;

    private void Start()
    {
        interval = 60f / rpm;
        bulletList = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            GameObject bulletObj = Instantiate(bullet);
            bulletObj.SetActive(false);
            bulletObj.transform.parent = this.transform;
            bulletList.Add(bulletObj);
        }
    }
    private void UpdateFiring()
    {
        if (Time.time - lastShot > interval)
        {
            Fire();
            lastShot = Time.time;
        }
    }
    private void Fire()
    {
        for (int i = 0; i < bulletList.Count; i++)
        {
            if (!bulletList[i].activeInHierarchy)
            {
                bulletList[i].transform.position = spawn.position;
                bulletList[i].transform.rotation = spawn.rotation;
                bulletList[i].SetActive(true);
                bulletRB = bulletList[i].GetComponent<Rigidbody>();
                bulletRB.AddForce(bulletRB.transform.forward * speed);
                break;
            }
        }
    }
    //private void Fire()
    //{
    //    GameObject tempBullet = pool.Spawn(spawn.position,spawn.rotation);
    //    bulletRB = tempBullet.GetComponent<Rigidbody>();
    //    bulletRB.AddForce(bulletRB.transform.forward * speed);
    //    timeShot = Time.time;
    //    shotAudio.Play();
    //    onLook?.Invoke();
    //}
    //private void DeSpawnBulelt()
    //{
    //    if (timeShot == 5f)
    //    {
    //        pool.Despawn();
    //    }
    //}
    public void StartFire()
    {
        isShoot = true;
    }
    public void StopFire()
    {
        isShoot = false;
    }
    // Update is called once per frame
    void Update()
    {
        if (isShoot)
            UpdateFiring();
    }
}
