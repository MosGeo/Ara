using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Scan : MonoBehaviour
{

    public GameObject AudioSources;
    public float maxDistance = 10.0f;
    bool autoScan = true;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("f") || autoScan == true)
        {
            startScan();
        }
    }

    void startScan()
    {
        RaycastHit hit;

//        float[] anglesY = {0.0f, 22.5f, 45, -45, -22.5f };
        float[] anglesY = { 0.0f, 10f, 20f, 30f, 40f, -40, -30, -20f, -10};
        float[] anglesX = {-1, -30};


        for (int i = 0; i < anglesY.Length; i += 1)
        {
            Vector3 direction = createScanDirectionY(transform.TransformDirection(Vector3.forward), anglesY[i]);

            for (int j = 0; j < anglesX.Length; j += 1)
            {
                direction = createScanDirectionX(direction, anglesX[j]);
                if (Physics.Raycast(transform.position, direction, out hit, maxDistance))
                {
                    Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);
                    initializeAudioSource(hit);
                }
            }
        }

    }

    void initializeAudioSource(RaycastHit hit)
    {
        string audioFileName = "Audio/WhiteNoise";
        GameObject audioSourceGO = new GameObject();
        audioSourceGO.transform.parent = AudioSources.transform;
        AudioSource audioSource = audioSourceGO.AddComponent<AudioSource>();
        audioSourceGO.transform.Translate(hit.point);
        audioSource.clip = Resources.Load(audioFileName) as AudioClip;
        float startTime = Random.Range(0.0f, audioSource.clip.length);
        audioSource.time = startTime;
        audioSource.volume = (maxDistance -  hit.distance)/maxDistance;
        audioSource.volume = Mathf.Max(0, audioSource.volume);
        audioSource.dopplerLevel = 0;
        audioSource.spatialBlend = 1;
        audioSource.Play();
        Destroy(audioSourceGO, .1f);
    }

    Vector3 createScanDirectionY(Vector3 forward, float angle)
    {
        Vector3 vector = Quaternion.Euler(0, angle, 0) * forward;
        return vector;
    }

    Vector3 createScanDirectionX(Vector3 forward, float angle)
    {
        Vector3 vector = Quaternion.Euler(angle, 0, 0) * forward;
        return vector;
    }

}
