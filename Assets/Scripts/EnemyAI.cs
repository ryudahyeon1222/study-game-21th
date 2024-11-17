using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // �÷��̾� ��ġ
    public float speed = 5f; // �� �̵� �ӵ�
    

    void Update()
    {
        if (player != null)
        {
            // �÷��̾ ���� �̵�
            Vector2 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
 
}


