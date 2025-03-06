using UnityEngine;
using UnityEngine.SceneManagement;

public class Fpoon : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            SceneManager.LoadScene("Main Menu"); // loads scene When player enter the trigger collider
        }
    }
}
