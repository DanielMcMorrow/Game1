using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    
    public void OnCollisionEnter(Collision other) 
    {
        if (other.collider.name == "Goal"){
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.collider.name == "Goal1"){
            Application.Quit();
            }
        if (other.collider.name == "Enemy"){
            Debug.Log("Restart level");
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.collider.name == "Enemy (1)"){
            Debug.Log("Restart level");
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        if (other.collider.name == "Enemy (2)"){
            Debug.Log("Restart level");
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
    }
}
