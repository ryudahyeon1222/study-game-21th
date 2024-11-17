using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAI : MonoBehaviour
{
    public Transform player; // 플레이어 위치
    public float speed = 5f; // 적 이동 속도
    

    void Update()
    {
        if (player != null)
        {
            // 플레이어를 향해 이동
            Vector2 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * speed * Time.deltaTime);
        }
    }
 
}


