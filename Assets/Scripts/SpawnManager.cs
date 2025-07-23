using UnityEngine;

public class SpawnManaer : MonoBehaviour
{
    public GameObject[] animalPrefabs;// 数组，存储动物预制件
    private float spawnRangeX = 24.0f; // X轴范围
    private float spawnRangeZ = 20.0f; // Z轴范围
    private float spawnInterval = 2.0f; // 动物首次生成的时间间隔
    private float spawnDelay = 1f; // 延迟时间
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //在指定的时间间隔内重复调用SpawnRandomAnimal方法
        InvokeRepeating(nameof(SpawnRandomAnimal), spawnInterval, spawnDelay);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.S))
        {
            SpawnRandomAnimal();
        }
    }

    void SpawnRandomAnimal()
    {
        int animalIndex = Random.Range(0, animalPrefabs.Length); // 随机选择一个动物预制件的索引
        Vector3 spawnZ = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnRangeZ);// X轴在这个范围随机位置
        //固定z轴位置，x轴在范围内随机位置生成随机的动物预制件
        Instantiate(animalPrefabs[animalIndex], spawnZ, animalPrefabs[animalIndex].transform.rotation);
    }
}
