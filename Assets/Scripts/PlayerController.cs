using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    [SerializeField]
    private float minHeight;
    private Movement3D movement3D;

    private void Awake()
    {
        movement3D = GetComponent<Movement3D>();
    }

    private void Update()
    {
        // ����Ű�� ���� �̵�
        float x = Input.GetAxis("Horizontal");
        float z = Input.GetAxis("Vertical");

        if(x != 0 || z != 0)    // �� �� �� �� Ű�� ��������
        {
            // (x, 0 ,z) �������� �̵�
            movement3D.MoveTo(new Vector3(x, 0, z));    // MoveTo �Լ��� ȣ���ؼ� ������
        }
        // �ٴ����� �÷��̾ ���������� üũ
        ChangeSceneFallDown();
    }
    
    private void ChangeSceneFallDown()
    {
        if(transform.position.y < minHeight)
        {
            // ���� ���� �ε�(���� �� �����)
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}
