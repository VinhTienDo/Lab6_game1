using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Windows;

public class Player : MonoBehaviour
{
 

    public Rigidbody2D rigidbody2D;
    public GameObject panelEndGame;
    

    void Start()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    

    public void restartGame()
    {
        panelEndGame.SetActive(false);
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        Time.timeScale = 1f;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "obstacles")
        {
            panelEndGame.SetActive(true);
            Time.timeScale = 0;
        }
    }
    
    public void Jump()
    {
        rigidbody2D.AddForce(Vector2.up * 6, ForceMode2D.Impulse);

    }
    public void left()
    {
        rigidbody2D.AddForce(Vector2.left * 3, ForceMode2D.Impulse);
    }
    public void right()
    {
        rigidbody2D.AddForce(Vector2.right * 3, ForceMode2D.Impulse);
    }

}
