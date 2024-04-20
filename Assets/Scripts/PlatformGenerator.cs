using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformGenerator : MonoBehaviour
{
    // attributes
    public GameObject[] platforms;
    public int numberOfPlatforms;
    public float distanceY;
    public float MinX; // -4        // scale : 0.4575203, 0.8808282, 1
    public float MaxX; // 3.71

    // iniisip pa kung idadagdag random spawn in y axis
    // public float MinY;
    // public float MaxY;

    [HideInInspector] public Vector3 lastPlatformPosition; 

    // Start is called before the first frame update
    void Start()
    { 
        platforms[0].GetComponent<PlatformBehavior>().chance = 10;
        platforms[1].GetComponent<PlatformBehavior>().chance = 0;
        platforms[2].GetComponent<PlatformBehavior>().chance = 0;
        platforms[3].GetComponent<PlatformBehavior>().chance = 0;
        platforms[4].GetComponent<PlatformBehavior>().chance = 0;
        // creates first platform in fixed y position
        Instantiate(platforms[0], new Vector3(Random.Range(MinX, MaxX), -0.78f, 10f), Quaternion.identity);
        // save position of first platform
        lastPlatformPosition = platforms[0].transform.position;
        // platforms[0].GetComponent<PlatformBehavior>().chance = 10;
        
        // create clones of platform
        createPlatform(numberOfPlatforms-1);
    }

    // Update is called once per frame
    void Update()
    {
        // checks number of platforms in scene < numberOfPlatforms needed in scene
        GameObject[] platformsOnScene = GameObject.FindGameObjectsWithTag("Platform");

        if (platformsOnScene.Length < numberOfPlatforms) {
            createPlatform(1);
        }

        updatePlatformChance();
    }

    // instantiates platforms randomly in x axis given the number of platforms
    public void createPlatform(int numberOfPlatforms) 
    {
        // storage for what platform will be instantiated
        GameObject platform;
        int i = 0;

        do {
            
            platform = platforms[Random.Range(0, platforms.Length)];
        
            
            if (Random.Range(0, 10-platform.GetComponent<PlatformBehavior>().chance) == 0 && platform.GetComponent<PlatformBehavior>().chance != 0) {
                GameObject platform_clone = Instantiate(platform, new Vector3(Random.Range(MinX, MaxX), lastPlatformPosition.y+distanceY, 10f), Quaternion.identity);

                // if platform to be generated is a vertically moving platform 
                if (platform.GetComponent<PlatformBehavior>().behavior.ToString() == "Moving") {
                    if (platform.GetComponent<MovingBehavior>().isVertical) {
                        // generate a regular platform beside a vertically moving platform
                        platform_clone.GetComponent<MovingBehavior>().MinPos = platform_clone.transform.position.y;
                        platform_clone.GetComponent<MovingBehavior>().MaxPos = platform_clone.transform.position.y + distanceY;

                        if (platform_clone.transform.position.x <= ((MinX+MaxX)/2)) {
                            Instantiate(platforms[0], new Vector3(Random.Range(platform_clone.transform.position.x+3, MaxX), lastPlatformPosition.y+distanceY, 10f), Quaternion.identity);
                        } else {
                            Instantiate(platforms[0], new Vector3(Random.Range(MinX, platform_clone.transform.position.x-3), lastPlatformPosition.y+distanceY, 10f), Quaternion.identity);
                        }

                        lastPlatformPosition = new Vector3(platform_clone.transform.position.x, platform_clone.GetComponent<MovingBehavior>().MaxPos, 10f);
                    } else {
                        lastPlatformPosition = platform_clone.transform.position;
                    }
                } else {
                    lastPlatformPosition = platform_clone.transform.position;
                }

                i++;
            }
        } while (platform.GetComponent<PlatformBehavior>().chance == 0 || i < numberOfPlatforms);
    }

    private void updatePlatformChance()
    {
        float score = GameObject.FindGameObjectWithTag("Player").transform.position.y * 10;
        
        if (score > 1000 && score < 1500) {
            platforms[0].GetComponent<PlatformBehavior>().chance = 8;
            platforms[1].GetComponent<PlatformBehavior>().chance = 5;
            platforms[2].GetComponent<PlatformBehavior>().chance = 0;
            platforms[3].GetComponent<PlatformBehavior>().chance = 0;
            platforms[4].GetComponent<PlatformBehavior>().chance = 0;
        } else if (score > 1500 && score < 2000) {
            platforms[0].GetComponent<PlatformBehavior>().chance = 7;
            platforms[1].GetComponent<PlatformBehavior>().chance = 7;
            platforms[2].GetComponent<PlatformBehavior>().chance = 0;
            platforms[3].GetComponent<PlatformBehavior>().chance = 5;
            platforms[4].GetComponent<PlatformBehavior>().chance = 0;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>().moveSpeed = 2f;
        } else if (score > 2000 && score < 3000) {
            platforms[0].GetComponent<PlatformBehavior>().chance = 6;
            platforms[1].GetComponent<PlatformBehavior>().chance = 7;
            platforms[2].GetComponent<PlatformBehavior>().chance = 6;
            platforms[3].GetComponent<PlatformBehavior>().chance = 7;
            platforms[4].GetComponent<PlatformBehavior>().chance = 6;
        } else if (score > 3000 && score < 5000) {
            platforms[0].GetComponent<PlatformBehavior>().chance = 6;
            platforms[1].GetComponent<PlatformBehavior>().chance = 8;
            platforms[2].GetComponent<PlatformBehavior>().chance = 7;
            platforms[3].GetComponent<PlatformBehavior>().chance = 6;
            platforms[4].GetComponent<PlatformBehavior>().chance = 5;
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>().moveSpeed = 3f;
        } else if (score > 5000 && score < 7000) {
            platforms[0].GetComponent<PlatformBehavior>().chance = 4;
            platforms[1].GetComponent<PlatformBehavior>().chance = 8;
            platforms[2].GetComponent<PlatformBehavior>().chance = 8;
            platforms[3].GetComponent<PlatformBehavior>().chance = 8;
            platforms[4].GetComponent<PlatformBehavior>().chance = 5;
            platforms[1].GetComponent<MovingBehavior>().moveSpeed = 3f;
            platforms[2].GetComponent<MovingBehavior>().moveSpeed = 3f;
        } else if (score > 7000 && score < 10000) {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<CameraScript>().moveSpeed = 3.5f;
        } else if (score > 10000) {
            platforms[0].GetComponent<PlatformBehavior>().chance = 4;
            platforms[1].GetComponent<PlatformBehavior>().chance = 9;
            platforms[2].GetComponent<PlatformBehavior>().chance = 9;
            platforms[3].GetComponent<PlatformBehavior>().chance = 9;
            platforms[4].GetComponent<PlatformBehavior>().chance = 9;
            platforms[1].GetComponent<MovingBehavior>().moveSpeed = 4f;
            platforms[2].GetComponent<MovingBehavior>().moveSpeed = 4f;
        } 
    }
}
