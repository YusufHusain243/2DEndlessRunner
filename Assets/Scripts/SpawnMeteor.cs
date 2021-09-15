using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnMeteor : MonoBehaviour
{
    public Rigidbody2D meteor;
    public GameObject pos;

    private Vector2 posMeteor;
    public float waktuMaksimal, waktuMinimal;

    void Start()
    {
        StartCoroutine(MunculMeteor());
    }

    IEnumerator MunculMeteor()
    {
        posMeteor = pos.transform.position;
        transform.position = new Vector2(posMeteor.x, -3);

        Instantiate(meteor, transform.position, Quaternion.identity);

        yield return new WaitForSeconds(Random.Range(waktuMinimal, waktuMaksimal));
        StartCoroutine(MunculMeteor());
    }
}
