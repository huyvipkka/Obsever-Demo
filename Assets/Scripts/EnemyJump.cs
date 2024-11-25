using UnityEngine;

public class EnemyJump : MonoBehaviour
{

    Rigidbody2D rb;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        GameAction.onPlayerJump += JumpFollowPlayer;
    }

    private void OnDestroy()
    {
        GameAction.onPlayerJump -= JumpFollowPlayer;
    }

    void JumpFollowPlayer()
    {
        Debug.Log("Enemy Jump");
        rb.AddForce(200 * Vector2.up);
    }
}
