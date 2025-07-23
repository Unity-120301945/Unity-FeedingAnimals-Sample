using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float verticalInput;
    public float speed = 10.0f;
    private float xRange = 24.0f; // 玩家在屏幕上的水平移动范围
    public GameObject projectilePrefab;// 食物子弹预制体

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");


        //if (transform.position.x < -24)
        //{
        //    transform.position = new Vector3(-24, transform.position.y, transform.position.z);
        //}
        //else if (transform.position.x > 24)
        //{
        //    transform.position = new Vector3(24, transform.position.y, transform.position.z);
        //}
        //让玩家在屏幕边界内移动
        //比上面的代码更简洁
        transform.position = new Vector3(
            Mathf.Clamp(transform.position.x, -xRange, xRange),
            transform.position.y,
            transform.position.z
        );
        transform.Translate(Vector3.right * horizontalInput * speed * Time.deltaTime);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            //判断按下的是否是空格键
            //Launch a projectile from the player
            //发射一个子弹
            Instantiate(projectilePrefab, new Vector3(transform.position.x, transform.position.y + 2f, transform.position.z), projectilePrefab.transform.rotation);

        }
    }
}
