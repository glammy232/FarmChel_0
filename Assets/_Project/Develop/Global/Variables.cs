using System;
using UnityEngine;

public class Variables
{
    public const int ACHIEVEMENTS_AMMOUNT = 9;

    public const int TREASURES_AMMOUNT = 15;

    public const int IMPROVEMENTS_AMMOUNT = 4;

    public static int Music { get => PlayerPrefs.GetInt(nameof(Music), 1); set => PlayerPrefs.SetInt(nameof(Music), value); }

    public static int Sound { get => PlayerPrefs.GetInt(nameof(Sound), 1); set => PlayerPrefs.SetInt(nameof(Sound), value); }

    public static int Vibration { get => PlayerPrefs.GetInt(nameof(Vibration), 1); set => PlayerPrefs.SetInt(nameof(Vibration), value); }

    public static int Coins { get => PlayerPrefs.GetInt(nameof(Coins), 0); set => PlayerPrefs.SetInt(nameof(Coins), value); }

    public static int Gems { get => PlayerPrefs.GetInt(nameof(Gems), 0); set => PlayerPrefs.SetInt(nameof(Gems), value); }

    public static int OpenedLevels { get => PlayerPrefs.GetInt(nameof(OpenedLevels), 1); set => PlayerPrefs.SetInt(nameof(OpenedLevels), value); }

    public static int[] Improvements
    {
        get => JsonUtility.FromJson<ImprovementsData>(
            PlayerPrefs.GetString(
                nameof(Achievements),
                JsonUtility.ToJson(new ImprovementsData())
                )
            ).ImprovementsAmmount;

        set
        {
            Debug.Log("Set Improvements");

            PlayerPrefs.SetString(nameof(Improvements), JsonUtility.ToJson(new ImprovementsData(value)));
        }
    }

    public static int[] Achievements
    {
        get => JsonUtility.FromJson<AchievementsData>(
            PlayerPrefs.GetString(
                nameof(Achievements), 
                JsonUtility.ToJson(new AchievementsData())
                )
            ).AchievemementsState;

        set
        {
            Debug.Log("Set Achievements");

            PlayerPrefs.SetString(nameof(Achievements), JsonUtility.ToJson(new AchievementsData(value)));
        }
    }

    public static int[] Treasures
    {
        get => JsonUtility.FromJson<TreasuresData>(
            PlayerPrefs.GetString(
                nameof(Treasures),
                JsonUtility.ToJson(new TreasuresData())
                )
            ).TreasuresState;

        set
        {
            Debug.Log("Set Treasures");

            PlayerPrefs.SetString(nameof(Treasures), JsonUtility.ToJson(new TreasuresData(value)));
        }
    }
}

[Serializable]
public class AchievementsData
{
    public int[] AchievemementsState;
    
    public AchievementsData(int[] achievementsState)
    {
        AchievemementsState = achievementsState;
    }

    public AchievementsData()
    {
        AchievemementsState = new int[Variables.ACHIEVEMENTS_AMMOUNT];
    }
}

[Serializable]
public class TreasuresData
{
    public int[] TreasuresState;

    public TreasuresData(int[] treasuresState)
    {
        TreasuresState = treasuresState;
    }

    public TreasuresData()
    {
        TreasuresState = new int[Variables.TREASURES_AMMOUNT];
    }
}

[Serializable]
public class ImprovementsData
{
    public int[] ImprovementsAmmount;

    public ImprovementsData(int[] improvementsAmmount)
    {
        ImprovementsAmmount = improvementsAmmount;
    }

    public ImprovementsData()
    {
        ImprovementsAmmount = new int[Variables.IMPROVEMENTS_AMMOUNT];
    }
}