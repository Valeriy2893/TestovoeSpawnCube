using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int speed;

    private UI uI;

    void Start()
    {
        uI = FindObjectOfType<UI>();
        speed = int.Parse(uI.textSpeed.text);

    }

    void Update()
    {
        transform.Translate(0, 0, speed * Time.deltaTime);
    }
    private void OnTriggerStay(Collider other)
    {
        Destroy(gameObject);
    }
}
