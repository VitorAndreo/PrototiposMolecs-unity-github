using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SetCore : MonoBehaviour
{
    // Start is called before the first frame update
    public Vector3 posicao, rotacao;
    public GameObject prefab;
    GameObject core;
    Mesh coreMesh;
    MeshFilter coreMF;
    MeshRenderer coreMR;
    void OnEnable()
    {
        if (core == null || coreMesh == null)
        {
            setUpCore();
        }
    }

    void OnValidate()
    {
        if (core == null || coreMesh == null) 
        {
            setUpCore();
        }
    }
    void setUpCore()
    {
        if (core == null && transform.childCount == 0)
        {
            GameObject core = (GameObject)Instantiate(prefab, transform.position, transform.rotation);
            core.AddComponent(typeof(Rigidbody));
            core.GetComponent<Rigidbody>().isKinematic = true;
        }
    }

}
