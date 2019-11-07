using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameStat : ScriptableObject
{
    public int score;
    public int initialScore = 0;
    public float[] highscore = new float[4];

    void Awake()
    {
        for(int i = 0; i <= highscore.Length; i++)
        {
            highscore[i] = 9999999999;
        }
        score = initialScore;
    }

}
