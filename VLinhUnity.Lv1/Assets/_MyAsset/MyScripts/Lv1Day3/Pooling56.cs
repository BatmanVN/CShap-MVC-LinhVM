using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pooling56 : MonoBehaviour
{
    public float speed;
    public GameObject bullet;
    public List<GameObject> bulletList;
     void Start()
    {
        bulletList = new List<GameObject>();
        for (int i = 0; i < 10; i++)
        {
            GameObject bulletObj = Instantiate(bullet);
            bulletObj.SetActive(false);
            bulletObj.transform.parent = this.transform;
            bulletList.Add(bulletObj);
        }
    }

    public GameObject Spawn(Vector3 position, Quaternion rotation)
    {
        var clone = default(GameObject);
        foreach (GameObject objBullet in bulletList)
        {
            if (!objBullet.activeInHierarchy)
            {
                objBullet.transform.position = position;
                objBullet.transform.rotation = rotation;
                objBullet.SetActive(true);
            }
        }
        return clone;
    }

    public GameObject Despawn()
    {
        var clone = default(GameObject);
        for (int i = 0; i < bulletList.Count; i++)
        {
            if (i == 9)
            {
                bulletList[i].SetActive(false);
            }
        }
        return clone;
    }
}
