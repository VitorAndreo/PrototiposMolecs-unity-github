using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class menuInicial : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
    public void chamaCenaLista()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("Cenas");
    }
    public void chamaCenaO2()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("O2");
    }
    public void chamaCenaH2O()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("H2O");
    }
    public void chamaCenaFluor()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("F");
    }
    public void chamaCenaCarbono()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("C");
    }
}
