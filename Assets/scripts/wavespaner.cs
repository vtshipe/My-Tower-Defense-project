
using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class wavespaner : MonoBehaviour
{
    // Start is called before the first frame update
    public Transform enemyprefab;
    public Transform spawnPoint;

    public float timebetweenwaves = 5f;
    private float countdown = 2f;
    public Text waveCountdownText;
    private int waveIndex = 0;

    private void Update()
    {
        if (countdown <= 0f)
        {
            StartCoroutine(SpawnWave());
            countdown = timebetweenwaves;
            
        }
        countdown -= Time.deltaTime;
        waveCountdownText.text = Mathf.Round(countdown).ToString();
    }

    IEnumerator SpawnWave()
    {
        waveIndex++;
        for (int i = 0; i < waveIndex; i++)
        {
         
            SpawnEnemy();
            yield return new WaitForSeconds(0.5f);
        }
        
    }

    void SpawnEnemy()
    {
        Instantiate(enemyprefab,spawnPoint.position,spawnPoint.rotation);
    }
}