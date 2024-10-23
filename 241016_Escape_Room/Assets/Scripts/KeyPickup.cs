using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject wardrobes;
    public Vector3 moveDirection;
    public float moveDistance = 3f;
    public float moveSpeed = 2f;

    private bool hasKey = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            hasKey = true;
            Debug.Log("Å°¸¦ È¹µæÇß½À´Ï´Ù!");
            Destroy(gameObject);
            StartCoroutine(MoveWardrobes());
        }
    }

    private IEnumerator MoveWardrobes()
    {
        Vector3 startPos = wardrobes.transform.position;
        Vector3 targetPos = startPos + moveDirection * moveDistance;

        while (Vector3.Distance(wardrobes.transform.position, targetPos) > 0.01f)
        {
            wardrobes.transform.position = Vector3.MoveTowards(wardrobes.transform.position, targetPos, moveSpeed * Time.deltaTime);
            yield return null;
        }
    }

    public bool HasKey()
    {
        return hasKey;
    }
}
