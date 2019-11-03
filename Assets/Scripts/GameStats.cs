using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class GameStat : ScriptableObject
{
    public int score;
    public int initialScore = 0;

    void Awake()
    {
        score = initialScore;
    }

}
