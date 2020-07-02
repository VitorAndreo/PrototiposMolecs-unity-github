using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circulo : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform target;
    public int velocidade;
    // Start is called before the first frame update
    void Start()
    {
        if (target == null)
        {
            target = this.gameObject.transform;
            Debug.Log("Destino RodarRedor não especificado. Padronize o objeto pai");


        }

    }

    // Update is called once per frame
    void Update()
    {
        transform.RotateAround(target.transform.position, target.transform.up, velocidade * Time.deltaTime);

    }
}
