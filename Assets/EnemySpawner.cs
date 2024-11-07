using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemyPrefab; // 적 프리팹
    public Transform player; // 플레이어의 Transform을 참조하기 위한 필드
    public float spawnInterval = 5f; // 적 생성 간격
    private bool isSpawning = true; // 생성 여부를 확인하는 플래그

    void Start()
    {
        StartCoroutine(SpawnEnemies()); // 코루틴을 시작하여 무한 생성
    }

    // 코루틴을 사용하여 while문처럼 무한으로 적을 생성
    IEnumerator SpawnEnemies()
    {
        while (isSpawning)
        {
            SpawnEnemy(); // 적 생성
            yield return new WaitForSeconds(spawnInterval); // spawnInterval 시간만큼 대기 후 다시 생성
        }
    }

    void SpawnEnemy()
    {
        // 적을 생성
        GameObject enemy = Instantiate(enemyPrefab, GetRandomPosition(), Quaternion.identity);
        enemy.GetComponent<EnemyAI>().player = player; // 생성된 적에 플레이어 정보 전달
    }

    Vector2 GetRandomPosition()
    {
        // 화면 내 랜덤 위치 생성 (직사각형 범위)
        return new Vector2(Random.Range(-20f, 20f), Random.Range(-20f, 20f));
    }
}




