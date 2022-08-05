using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpManager : MonoBehaviour
{
    public Transform spawnArea;
    public int maxPowerUpAmount;
    public Vector2 minSpawnArea, maxSpawnArea;
    private List<GameObject> PowerUpList;
    public List<GameObject> powerUpTemplateList;

    public int spawnInterval;

    private float timer;

    private void Start()
    {
        PowerUpList = new List<GameObject>();
        timer = 0;
    }

    private void Update()
    {
        timer += Time.deltaTime;

        if (timer > spawnInterval)
        {
            GenerateRandomPowerUp();
            timer -= spawnInterval;
        }
    }

    public void GenerateRandomPowerUp ()
    {
        GenerateRandomPowerUp(new Vector2(Random.Range(minSpawnArea.x, maxSpawnArea.x), Random.Range(minSpawnArea.y, maxSpawnArea.y)) );
    }

    public void GenerateRandomPowerUp (Vector2 position)
    {
        if (PowerUpList.Count >= maxPowerUpAmount)
        {
            return;
        }

        if (position.x < minSpawnArea.x || position.x > maxSpawnArea.x || position.y < minSpawnArea.y || position.y > maxSpawnArea.y )
        {
            return;
        }

        int randomIndex = Random.Range(0, powerUpTemplateList.Count);

        GameObject powerUp = Instantiate(powerUpTemplateList[randomIndex], new Vector3(position.x, position.y, powerUpTemplateList[randomIndex].transform.position.z), Quaternion.identity, spawnArea);
        powerUp.SetActive(true);

        
    }

    public void RemovePowerUp(GameObject powerUp)
    {
        PowerUpList.Remove(powerUp);
        Destroy(powerUp);
    }

    public void RemoveAllPowerUp()
    {
        while (PowerUpList.Count > 0)
        {
            RemovePowerUp(PowerUpList[0]);
        }
    }

}
