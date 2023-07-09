using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Coin : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Debug.Log("Coin");

        gameObject.SetActive(false);
        //Destroy(gameObject);

        if (SceneManager.GetActiveScene().name == "LEVEL_1") {
            SceneManager.LoadScene("LEVEL_2");
        }
        else {
            SceneManager.LoadScene("LEVEL_2");
        }

    }
}
