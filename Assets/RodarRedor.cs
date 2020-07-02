using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RodarRedor : MonoBehaviour
{
    public Transform tagert;
    public int velocidade;
    // Start is called before the first frame update
    void Start()
    {
        if (tagert == null)
        {
            tagert = this.gameObject.transform;
            Debug.Log("Destino RodarRedor não especificado. Padronize o objeto pai");


        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(tagert.transform.position, tagert.transform.up, velocidade * Time.deltaTime);

    }
}
