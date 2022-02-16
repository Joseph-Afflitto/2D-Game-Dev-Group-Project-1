using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchOpensDoor : MonoBehaviour
{
    public AudioSource door2;
	[SerializeField]
    GameObject door;

    bool isOpened = false;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (!isOpened)
        {
            isOpened = true;
            door.transform.position += new Vector3(0, 4, 0);
			door2.Play();
        }
    }
}
