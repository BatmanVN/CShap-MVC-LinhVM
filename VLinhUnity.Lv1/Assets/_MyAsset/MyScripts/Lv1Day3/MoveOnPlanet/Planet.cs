using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Planet : MonoBehaviour
{
    public float gravity;
    public float speed;
    public void Attract(Transform playerTransform)
    {
        Vector3 gravityUp = (playerTransform.position - transform.position).normalized;
        Vector3 localUp = playerTransform.up;

        playerTransform.GetComponent<Rigidbody>().AddForce(gravityUp * gravity);

        Quaternion tartgetRotation = Quaternion.FromToRotation(localUp, gravityUp) * playerTransform.rotation;
        playerTransform.rotation = Quaternion.Slerp(playerTransform.rotation, tartgetRotation, speed * Time.deltaTime);
    }
}
