using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class SantaScript : MonoBehaviour
{
    public float speed;
    private float rotateSpeed = 1;
    public Text scoreText;
    public int score;

    int maxRotation = 90;
    int minRotation = -90;

    void Update()
    {
        Move();
    }

    void Move()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rotateSpeed *= -1;
        }

        transform.Translate(Vector2.down * speed * Time.deltaTime);

        transform.Rotate(0, -rotateSpeed, rotateSpeed);
        transform.position = new Vector3(transform.position.x, transform.position.y, 0);
    }

    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("Present"))
        {
            Destroy(collision.gameObject);
            score += 1;
        }
        if (collision.gameObject.CompareTag("Obstacle"))
        {
            SceneManager.LoadScene("GameOver");
        }
    }

    private void OnGUI()
    {
        scoreText.text = "Score: " + score;
    }
}
