using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerLife : MonoBehaviour
{
    public NextLevelScreen nextlevelScreen;
    public GameOverScreen GameOverScreen;
    //int maxPlatform = 0;
    bool dead = false;
    public static int numberOfCoins;
    private void Start()
    {
        numberOfCoins = 0;
    }
    private void Update()
    {
        if (transform.position.y < -1f && !dead)
        {
            Die();
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemy body"))
        {
            GetComponent<MeshRenderer>().enabled = false;
            GetComponent<Rigidbody>().isKinematic = true;
            GetComponent<ForwardMovement>().enabled = false;
            Die();
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Wall"))
        {
            nextlevelScreen.Setup();
        }
    }
    void Die()
    {
        GameOverScreen.Setup();
    }
    void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

}
