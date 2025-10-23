using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Goad : MonoBehaviour
{
    public Goad()
    {
    }

    private void Start()
    {
        float x = Random.Range(-20, 20);
        float z = Random.Range(-20, 20);
        transform.position = new Vector3(x, 1, 0);
    }

    public void Myradom()
    {
        float x = Random.Range(-20, 20);
        float z = Random.Range(-20, 20);
        transform.position = new Vector3(x, 1, 0);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(0);
        }
    }
}
