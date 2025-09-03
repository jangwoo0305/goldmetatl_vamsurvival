using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    public Vector2 inputVec;
    public float speed;
    Rigidbody2D rigid;
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        rigid =  GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        // rigid.linearVelocity = inputVec;
        // // 1. 힘을 준다
        // rigid.AddForce(inputVec);
        // // 2. 속도 제어
        // rigid.linearVelocity = inputVec;
        Vector2 newVec = inputVec * (speed * Time.fixedDeltaTime);
        // 3. 위치 이동
        rigid.MovePosition(rigid.position + newVec);
    }

    void OnMove(InputValue value)
    {
        inputVec = value.Get<Vector2>();
    }
}
