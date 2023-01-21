using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Teleporter : MonoBehaviour
{
    [SerializeField]
    private Transform arrivePoint;
    private AudioSource audioSource;

    private void Awake()
    {
        audioSource = GetComponent<AudioSource>();
    }

    private void OnTriggerEnter(Collider other)
    {
        // other ������Ʈ�� �±װ� Player�̸�
        if(other.CompareTag("Player"))
        {
            // ����� ���
            audioSource.Play();
            // other(�÷��̾�)�� ��ġ�� arrivePoint�� ����
            other.transform.position = arrivePoint.position;
        }
    }
}
