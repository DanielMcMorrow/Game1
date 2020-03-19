using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerCollision : MonoBehaviour
{
    public Transform Player;

    public void OnCollisionEnter(Collision other) 
    {
        if (other.collider.name == "Goal"){
             SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

        if (other.collider.name == "Goal1"){
            Debug.Log("Restart game");
            SceneManager.LoadScene(0);
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


        if (other.collider.name == "DeathFloor"){
            Debug.Log("Restart level");
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }

    /*void Update()
    {
        transform.position = Player.position + offset;

        if (Player.transform.position.y < -6)
        {
            Debug.Log("Game Over");
            SceneManager.LoadScene(SceneManager.GetActiveScene() .name);
        }
    }  */
    } 
}
