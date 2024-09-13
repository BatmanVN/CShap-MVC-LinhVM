using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LookAt50 : MonoBehaviour
{
    [SerializeField] private GameObject target;
    

    public void LookAt()
    {
        Vector3 targetRotaion = new Vector3(target.transform.position.x,
                                                transform.position.y,target.transform.position.z);
        transform.LookAt(targetRotaion);
    }
}
