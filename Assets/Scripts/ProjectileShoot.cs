using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileShoot : MonoBehaviour
{
    public GameObject projectilePrefab;
    AudioSource m_shootingSound;
    private float time;
    private float nextTimeToFire;
    [SerializeField] private float fireRate;
    // Start is called before the first frame update
    void Start()
    {
        m_shootingSound = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;
        nextTimeToFire = 1 / fireRate;
        if(Input.GetKey(KeyCode.Space))
        {
            
            if (time >= nextTimeToFire)
            {
                m_shootingSound.Play();
                Instantiate(projectilePrefab, transform.position, Quaternion.identity);
                time = 0f;
            }
            
        }
    }
}