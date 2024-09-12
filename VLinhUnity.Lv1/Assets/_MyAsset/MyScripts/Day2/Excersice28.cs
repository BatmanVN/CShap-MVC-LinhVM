using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Excersice28 : MonoBehaviour
{
    //[SerializeField] private List<Material> mater;
    //[SerializeField] private List<GameObject> pearls;
    [SerializeField] private Material matRed;
    [SerializeField] private Material matYellow;


    private void Start()
    {
        InvokeRepeating(nameof(m1), 0, 2);
    }
    private void m2()
    {
        GetComponent<Renderer>().material = matYellow;
    }

    private void m1()
    {
        GetComponent<Renderer>().material = matRed;
        Invoke("m2", 2);
    }
}


//    public void ChangeMaterial()
//    {
//        int random = Random.Range(0, mater.Count);
//        pearls[0].GetComponentInChildren<Renderer>().materials[0] = matRed;
//        pearls[1].GetComponentInChildren<Renderer>().materials[0] = matYellow;
//    }
//    private void Start()
//    {
//        InvokeRepeating(nameof(ChangeMaterial), 0, 2);
//    }
//    private void Update()
//    {
//        ChangeMaterial();
//    }
//}
