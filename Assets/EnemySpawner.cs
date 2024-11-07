using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // �� ������
    public Transform player; // �÷��̾��� Transform�� �����ϱ� ���� �ʵ�
    public float spawnInterval = 5f; // �� ���� ����
    private bool isSpawning = true; // ���� ���θ� Ȯ���ϴ� �÷���

    void Start()
    {
        StartCoroutine(SpawnEnemies()); // �ڷ�ƾ�� �����Ͽ� ���� ����
    }

    // �ڷ�ƾ�� ����Ͽ� while��ó�� �������� ���� ����
    IEnumerator SpawnEnemies()
    {
        while (isSpawning)
        {
            SpawnEnemy(); // �� ����
            yield return new WaitForSeconds(spawnInterval); // spawnInterval �ð���ŭ ��� �� �ٽ� ����
        }
    }

    void SpawnEnemy()
    {
        // ���� ����
        GameObject enemy = Instantiate(enemyPrefab, GetRandomPosition(), Quaternion.identity);
        enemy.GetComponent<EnemyAI>().player = player; // ������ ���� �÷��̾� ���� ����
    }

    Vector2 GetRandomPosition()
    {
        // ȭ�� �� ���� ��ġ ���� (���簢�� ����)
        return new Vector2(Random.Range(-20f, 20f), Random.Range(-20f, 20f));
    }
}




