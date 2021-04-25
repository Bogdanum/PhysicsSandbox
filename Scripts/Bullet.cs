using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private bool isActive = true;

    public GameObject markPrefab;

    private void OnCollisionEnter(Collision collision)
    {
        if (!isActive) return;
        isActive = false;

        GetComponent<Rigidbody>().useGravity = true;

        Enemy enemy = collision.gameObject.GetComponent<Enemy>();
        if (enemy)
        {
            enemy.OnHit();
        }

        if (collision.gameObject.CompareTag("BulletMarkReceiver"))
        {
            Vector3 position = collision.contacts[0].point;
            Quaternion rotation = Quaternion.LookRotation(collision.contacts[0].normal);
            Instantiate(markPrefab, position, rotation);
        }

        if (collision.gameObject.CompareTag("remy"))
        {
            RagdollControl.instance.MakePhisical();
        }
    }

}
