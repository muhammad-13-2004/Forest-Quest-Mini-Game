using UnityEngine;

public class KnightWander : MonoBehaviour
{
    public float speed = 2.5f;
    Rigidbody2D rb;
    float timer;

    void Start() => rb = GetComponent<Rigidbody2D>();

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > 2f)
        {
            rb.velocity = Random.insideUnitCircle.normalized * speed;
            timer = 0f;
        }
    }
}