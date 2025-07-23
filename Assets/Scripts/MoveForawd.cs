using UnityEngine;

/**
 * 移动脚本，单一的往一条线上移动
 */
public class MoveForawd : MonoBehaviour
{
    public float speed = 40f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }
}
