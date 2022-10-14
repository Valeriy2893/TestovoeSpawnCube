using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject prefabEnemy;
    public GameObject prefabPoint;

    public float distanse;
    public float cooldown;


    private Vector3 vectorPoint;


    private GameObject point;

    public UI uI;
    private void Start()
    {
        uI = FindObjectOfType<UI>();

        cooldown = int.Parse(uI.textCooldown.text);
        distanse = float.Parse(uI.textDistanse.text);
    }



    private void Update()
    {
        ConvertDistanse();
        CreatePoint();

        Cooldown();
        CreateEnemy();

    }
    private void CreatePoint()
    {
        if (point == null)
        {
            point = Instantiate(prefabPoint, vectorPoint, Quaternion.identity);
        }
    }

    private void Cooldown()
    {
        if (cooldown > 0)
        {
            cooldown -= Time.deltaTime;
        }
    }
    private void CreateEnemy()
    {
        if (cooldown <= 0)
        {
            Instantiate(prefabEnemy, transform);
            cooldown = int.Parse(uI.textCooldown.text);
        }
    }

    private void ConvertDistanse()
    {
        vectorPoint = new Vector3(0f, 0f, distanse);
    }


}
