using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Player : MonoBehaviour
{

    private Vector2 targetPos;

    public int health = 5;
    public float speed;
    public float Yincrement;
    public float maxHeight;
    public float minHeight;

    private void Update()
    {

        if(health <= 0)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        }
        transform.position = Vector2.MoveTowards(transform.position, targetPos, speed * Time.deltaTime);

        if(Input.GetKeyDown(KeyCode.W) && transform.position.y < maxHeight) {
            targetPos = new Vector2(transform.position.x, transform.position.y + Yincrement);
            transform.position = targetPos;
        } else if(Input.GetKeyDown(KeyCode.S) && transform.position.y > minHeight)
        {
            targetPos = new Vector2(transform.position.x, transform.position.y - Yincrement);
            transform.position = targetPos;
        }
    }
}
