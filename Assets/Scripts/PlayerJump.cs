using UnityEngine;

public class PlayerJump : MonoBehaviour
{
    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("player Jump");
            rb.AddForce(200 * Vector2.up);
            GameAction.onPlayerJump?.Invoke();
        }
    }
}
