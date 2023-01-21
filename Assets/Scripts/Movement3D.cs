using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement3D : MonoBehaviour
{
    [SerializeField]
    private float moveSpeed;
    private Rigidbody rigidbody3D;

    private void Awake()
    {
        rigidbody3D = GetComponent<Rigidbody>();        
    }

    public void MoveTo(Vector3 direction, float force = 0)   // 외부에서 이동방향을 매개변수로 지정
    {
        Vector3 moveForce = Vector3.zero;

        if(force == 0)
        {
            direction.y = 0;    // y축으로 이동하지 않게 0으로 지정
            moveForce = direction.normalized * moveSpeed;   // 이동방향을 정규화하고 속도를 곱한다
        }
        else
        {
            moveForce = direction * force;
        }

        rigidbody3D.AddForce(moveForce);    // moveForce의 힘으로 오브젝트를 민다.
    }
}
