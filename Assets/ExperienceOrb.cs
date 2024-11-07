using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExperienceOrb : MonoBehaviour
{
    public float moveSpeed = 5f;
    public Transform player;

    void Update()
    {
        // ����ġ ������ �÷��̾�� �̵�
        if (player != null)
        {
            Vector2 direction = (player.position - transform.position).normalized;
            transform.Translate(direction * moveSpeed * Time.deltaTime);
        }
    }
}
