using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBalloons : MonoBehaviour
{
    public GameObject whiteBalloon;
    public GameObject pinkBalloon;
    public GameObject goldBalloon;
    public GameObject greenBalloon;
    //public GameObject billoon;
    public GameObject blueBalloon;
    public GameObject purpleBalloon;
    public GameObject orangeBalloon;
    public GameObject lightBlueBalloon;
    public GameObject redBalloon;
    public GameObject yellowBalloon;


    public static float spawnSpeed;

    public Transform balloonSpawn;
    public Transform balloonSpawnR;
    public Transform purpleBalloonSpawn;

    Vector2 randomSpawnPosition;

    public static bool isSpawning;
    int pinkCount;
    int goldCount;
    int greenCount;
    int blueCount;
    int purpleCount;
    int orangeCount;
    int lightBlueCount;
    int redCount;
    int yellowCount;

    bool levelUp_01;
    bool levelUp_02;
    bool levelUp_03;
    bool levelUp_04;
    bool levelUp_05;

    bool whiteSpawning;
    bool redSpawning;
    bool goldSpawning;
    bool greenSpawning;
    bool blueSpawning;
    bool purpleSpawning;
    bool orangeSpawning;
    bool lightBlueSpawning;
    bool pinkSpawning;
    bool yellowSpawning;

    bool blueTime;
    bool purpleTime;
    bool orangeTime;
    bool lightBlueTime;
    bool redTime;
    bool yellowTime;

    GameObject chosenBalloon;

    Rigidbody2D whiteRB;
    Rigidbody2D blueRB;
    Rigidbody2D orangeRB;
    
    private void Update()
    {
        isSpawning = !GameControl.lost;

        if (ScoreController.score > 99 && ScoreController.score < 200)
        {
            whiteRB.mass = 3.0f;
            spawnSpeed = 1.42f;
            blueTime = true;
            levelUp_01 = true;
        }
        if(ScoreController.score > 199 && ScoreController.score < 300)
        {
            whiteRB.mass = 3.03f;
            spawnSpeed = 1.37f;
            levelUp_01 = false;
            levelUp_02 = true;
        }
        if (ScoreController.score > 299 && ScoreController.score < 400)
        {
            whiteRB.mass = 3.06f;
            lightBlueTime = true;
            spawnSpeed = 1.33f;
            levelUp_02 = true;
        }
        if (ScoreController.score > 399 && ScoreController.score < 500)
        {
            //whiteBalloon = blueBalloon;
            spawnSpeed = 1.3f;
            levelUp_04 = true;
            orangeTime = true;
            levelUp_02 = true;
        }
        if (ScoreController.score > 499 && ScoreController.score < 600)
        {
            //whiteBalloon = blueBalloon;
            //blueRB.mass = 2.7f;
            spawnSpeed = 1.27f;
            yellowTime = true;
            orangeTime = true;
            levelUp_02 = true;

        }
        if (ScoreController.score > 599 && ScoreController.score < 700)
        {
            whiteBalloon = blueBalloon;
            blueRB.mass = 2.75f;
            spawnSpeed = 1.5f;
            yellowTime = true;
            redTime = true;
            levelUp_02 = true;
            orangeTime = true;
        }
        if (ScoreController.score > 699 && ScoreController.score < 800)
        {
            whiteBalloon = blueBalloon;
            blueRB.mass = 2.8f;
            orangeRB.mass = 2.75f;
            spawnSpeed = 1.4f;
            yellowTime = true;
            purpleTime = true;
            redTime = true;
            levelUp_02 = true;
        }
        if (ScoreController.score > 799 && ScoreController.score < 900)
        {
            whiteBalloon = blueBalloon;
            blueRB.mass = 2.85f;
            orangeRB.mass = 2.8f;
            spawnSpeed = 1.35f;
            yellowTime = true;
            purpleTime = true;
            redTime = true;
            levelUp_04 = false;
            levelUp_05 = true;
        }
        if (ScoreController.score > 899 && ScoreController.score < 1000)
        {
            whiteBalloon = blueBalloon;
            blueRB.mass = 2.9f;
            orangeRB.mass = 2.85f;
            spawnSpeed = 1.3f;
            yellowTime = true;
            purpleTime = true;
            redTime = true;
            levelUp_04 = false;
            levelUp_05 = true;
        }
        if (ScoreController.score > 999 && ScoreController.score < 1100)
        {
            whiteBalloon = orangeBalloon;
            spawnSpeed = 1.5f;
            yellowTime = true;
            purpleTime = true;
            redTime = true;
            levelUp_04 = false;
            levelUp_05 = true;
        }
        if (ScoreController.score > 1099 && ScoreController.score < 1200)
        {
            whiteBalloon = orangeBalloon;
            spawnSpeed = 1.45f;
            blueRB.mass = 2.95f;
            orangeRB.mass = 2.9f;
            purpleTime = true;
            redTime = true;
            levelUp_04 = false;
            levelUp_05 = true;
        }
        if (ScoreController.score > 1199 && ScoreController.score < 1300)
        {
            whiteBalloon = orangeBalloon;
            spawnSpeed = 1.4f;
            blueRB.mass = 3f;
            orangeRB.mass = 2.95f;
        }
        if (ScoreController.score > 1299 && ScoreController.score < 1400)
        {
            whiteBalloon = orangeBalloon;
            spawnSpeed = 1.35f;
            blueRB.mass = 3.3f;
            orangeRB.mass = 3f;
        }
        if (ScoreController.score > 1399 && ScoreController.score < 1500)
        {
            whiteBalloon = orangeBalloon;
            spawnSpeed = 1.3f;
            blueRB.mass = 3.6f;
            orangeRB.mass = 3.3f;
        }
    }

    private void Awake()
    {
        whiteRB = whiteBalloon.GetComponent<Rigidbody2D>();
        whiteRB.mass = 2.9f;
        blueRB = blueBalloon.GetComponent<Rigidbody2D>();
        blueRB.mass = 2.7f;
        orangeRB = orangeBalloon.GetComponent<Rigidbody2D>();
        orangeRB.mass = 2.7f;
        isSpawning = true;
        spawnSpeed = 1.5f;
        StartCoroutine("StartSpawning");

        purpleCount = 28;
    }

    IEnumerator StartSpawning()
    {
        while (isSpawning == true)
        {
            if(purpleSpawning != true || lightBlueSpawning != true || yellowSpawning != true)
            {
                randomSpawnPosition = new Vector2(Random.Range(balloonSpawn.position.x, balloonSpawnR.position.x), balloonSpawn.position.y);
            }
            if (pinkCount < 17)
            {
                whiteSpawning = true;
                if (!pinkSpawning || !goldSpawning || !greenSpawning || !blueSpawning || !purpleSpawning || !orangeSpawning || !lightBlueSpawning || !redSpawning || !yellowSpawning)
                {
                    chosenBalloon = whiteBalloon;
                    whiteSpawning = false;
                    pinkCount++;
                    goldCount++;
                    greenCount++;
                    if(blueTime != false)
                    {
                        blueCount++;
                    }
                    if(purpleTime != false)
                    {
                        purpleCount++;
                    }
                    if(orangeTime != false)
                    {
                        orangeCount++;
                    }
                    if (lightBlueTime != false)
                    {
                        lightBlueCount++;
                    }
                    if (redTime != false)
                    {
                        redCount++;
                    }
                    if (yellowTime != false)
                    {
                        yellowCount++;
                    }
                }
            }

            if(pinkCount > 16)
            {
                pinkSpawning = true;
                if (!goldSpawning || !greenSpawning || !blueSpawning || !purpleSpawning || !orangeSpawning || !lightBlueSpawning || !redSpawning || !yellowSpawning)
                {
                    chosenBalloon = pinkBalloon;
                    pinkSpawning = false;
                    pinkCount = 0;
                }
                    
            }

            if(goldCount > 21)
            {
                goldSpawning = true;
                if(!pinkSpawning || !greenSpawning || !blueSpawning || !purpleSpawning || !orangeSpawning || !lightBlueSpawning || !redSpawning || !yellowSpawning)
                {
                    chosenBalloon = goldBalloon;
                    goldSpawning = false;
                    goldCount = 0;
                }
                
            }

            if(greenCount > 26)
            {
                greenSpawning = true;
                if(!goldSpawning || !pinkSpawning || !blueSpawning || !purpleSpawning || !orangeSpawning || !lightBlueSpawning || !redSpawning || !yellowSpawning)
                {
                    chosenBalloon = greenBalloon;
                    greenSpawning = false;
                    greenCount = 0;

                }
            }
            if(blueTime != false)
            {
                if (levelUp_01)
                {
                    if (blueCount > 7)
                    {
                        blueSpawning = true;
                        if (!goldSpawning || !pinkSpawning || !greenSpawning || !purpleSpawning || !orangeSpawning || !lightBlueSpawning || !redSpawning || !yellowSpawning)
                        {
                            chosenBalloon = blueBalloon;
                            blueSpawning = false;
                            blueCount = 0;
                        }
                    }
                }
                if (levelUp_02)
                {
                    if (blueCount > 3)
                    {
                        blueSpawning = true;
                        if (!goldSpawning || !pinkSpawning || !greenSpawning || !purpleSpawning || !orangeSpawning || !lightBlueSpawning || !redSpawning || !yellowSpawning)
                        {
                            chosenBalloon = blueBalloon;
                            blueSpawning = false;
                            blueCount = 0;
                        }
                    }
                }
            }
            
            if(purpleTime != false)
            {
                    if (purpleCount > 29)
                    {
                        purpleSpawning = true;
                        if (!goldSpawning || !pinkSpawning || !greenSpawning || !blueSpawning || !orangeSpawning || !lightBlueSpawning || !redSpawning || !yellowSpawning)
                        {
                            chosenBalloon = purpleBalloon;
                            randomSpawnPosition = purpleBalloonSpawn.position;
                            purpleSpawning = false;
                            purpleCount = 0;
                        }


                    }
            }

            if(orangeTime != false)
            {
                if (levelUp_04)
                {
                    if (orangeCount > 7)
                    {
                        orangeSpawning = true;
                        if (!goldSpawning || !pinkSpawning || !greenSpawning || !blueSpawning || !purpleSpawning || !lightBlueSpawning || !redSpawning || !yellowSpawning)
                        {
                            chosenBalloon = orangeBalloon;
                            orangeSpawning = false;
                            orangeCount = 0;
                        }
                    }
                }
                if (levelUp_05)
                {
                    if (orangeCount > 3)
                    {
                        orangeSpawning = true;
                        if (!goldSpawning || !pinkSpawning || !greenSpawning || !blueSpawning || !purpleSpawning || !lightBlueSpawning || !redSpawning || !yellowSpawning)
                        {
                            chosenBalloon = orangeBalloon;
                            orangeSpawning = false;
                            orangeCount = 0;
                        }
                    }
                }
                
            }
            if (lightBlueCount > 15)
            {
                lightBlueSpawning = true;
                if (!goldSpawning || !pinkSpawning || !greenSpawning || !blueSpawning || !orangeSpawning || !purpleSpawning || !redSpawning || !yellowSpawning)
                {
                    chosenBalloon = lightBlueBalloon;
                    randomSpawnPosition = purpleBalloonSpawn.position;
                    lightBlueSpawning = false;
                    lightBlueCount = 0;
                }
            }
            if (redCount > 20)
            {
                redSpawning = true;
                if (!goldSpawning || !pinkSpawning || !greenSpawning || !blueSpawning || !orangeSpawning || !purpleSpawning || !lightBlueSpawning || !yellowSpawning)
                {
                    chosenBalloon = redBalloon;
                    redSpawning = false;
                    redCount = 0;
                }
            }
            if (yellowCount > 13)
            {
                yellowSpawning = true;
                if (!goldSpawning || !pinkSpawning || !greenSpawning || !blueSpawning || !orangeSpawning || !purpleSpawning || !lightBlueSpawning || !redSpawning)
                {
                    chosenBalloon = yellowBalloon;
                    randomSpawnPosition = purpleBalloonSpawn.position;
                    yellowSpawning = false;
                    yellowCount = 0;
                }
            }

            SpawnNewBalloon(chosenBalloon);


            yield return new WaitForSeconds(spawnSpeed);
        }
    }

    void SpawnNewBalloon(GameObject balloon)
    {
        Instantiate(balloon, randomSpawnPosition, Quaternion.identity, null);
    }

    /*IEnumerator StartSpawning()
    {
        //whitespawning count < 17
        //redspawning count > 17
        //goldspawning ammocount = 25
        //greenspawning (leveup01) pucount == 43
        // blue spawning (level02) blue = 8

        while (isSpawning == true)
        {
            randomSpawnPosition = new Vector2(Random.Range(balloonSpawn.position.x, balloonSpawnR.position.x), balloonSpawn.position.y);
            if (count < 17)
            {
                Instantiate(whiteBalloon, randomSpawnPosition, Quaternion.identity, null);
                count++;
                ammoCount++;
                if (levelUp_01 == true)
                {
                    puCount++;
                }
                if (levelUp_02 == true)
                {
                    blue++;
                }
                if (greenSpawning != true && goldSpawning != true && redSpawning != true && blueSpawning != true)
                {
                    
                }
                
                
            }
            if (count > 16)
            {
                redSpawning = true;

                if (goldSpawning != true && greenSpawning != true && blueSpawning != true)
                {
                    Instantiate(redBalloon, randomSpawnPosition, Quaternion.identity, null);
                    count = 0;
                    redSpawning = false;
                    if (greenSpawning != true && goldSpawning != true && redSpawning != true)
                    {
                        ammoCount++;
                        if (levelUp_01 == true)
                        {
                            puCount++;
                        }
                        if(blueSpawning == true)
                        {
                            blue++;
                        }
                    //}
                        
                }
            }
            if (ammoCount == 25)
            {
                goldSpawning = true;
                if  (redSpawning != true && greenSpawning != true && blueSpawning)
                {
                    Instantiate(goldBalloon, randomSpawnPosition, Quaternion.identity, null);
                    ammoCount = 0;
                    goldSpawning = false;
                    /*if (levelUp_01 == true)
                    {
                        puCount++;
                    }
                    if(blueSpawning == true)
                    {
                        blue++;
                    }
                }
            }
            if (puCount == 43)
                greenSpawning = true;
            {
                if  (redSpawning != true && goldSpawning != true && blueSpawning != true)
                {
                    Instantiate(greenBalloon, randomSpawnPosition, Quaternion.identity, null);
                    puCount = 0;
                    greenSpawning = false;
                }
            }

            if(redSpawning != true && goldSpawning != true && greenSpawning != true)
            {
                if(levelUp_04 != true)
                {
                    if (levelUp_03 != true)
                    {
                        if (blue == 8)
                        {
                            Instantiate(blueBalloon, randomSpawnPosition, Quaternion.identity, null);
                            blueSpawning = true;
                            blue = 0;
                        }
                    }
                    if (levelUp_03 == true)
                    {
                        if (blue == 4)
                        {
                            Instantiate(blueBalloon, randomSpawnPosition, Quaternion.identity, null);
                            blueSpawning = true;
                            blue = 0;
                        }
                    }
                }       
            }
            //redSpawning = false;
            //goldSpawning = false;
            //greenSpawning = false;
            //blueSpawning = false;
            yield return new WaitForSeconds(spawnSpeed);
        }
        
    }*/
}
