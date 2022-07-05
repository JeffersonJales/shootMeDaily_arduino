using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour
{
    public float speed = 1f;
    private Rigidbody2D rigid2d;
    // Start is called before the first frame update
    void Start()
    {
        rigid2d = GetComponent<Rigidbody2D>();
    }

    public void Movement(float vecx) {
        Vector2 inputVector = new Vector2(vecx, 0) * speed;
        transform.Translate(inputVector);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        
    }
}
