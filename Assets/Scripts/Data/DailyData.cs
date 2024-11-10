using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

[System.Serializable]
public class DailyData
{
    public DateTime Date => date;
    public List<Meal> DailyMealList => dailyMealList;
    public List<Exercise> DailyExerciseList => dailyExerciseList;
    public float DailyWeight => dailyWeight;
    public float IntakeCalorie => intakeCalorie;
    public float BurntCalorie => burntCalorie;

    private DateTime date;
    private List<Meal> dailyMealList;
    private List<Exercise> dailyExerciseList;
    private float dailyWeight;
    private float intakeCalorie;
    private float burntCalorie;

    public DailyData()
    {
        date = DateTime.Today;
        dailyWeight = 0f;
        intakeCalorie = 0f;
        burntCalorie = 0f;
    }

    public void RecodeDate(DateTime date)
    {
        this.date = date;
    }

    public void RecodeDailyWeight(float weight)
    {
        dailyWeight = weight;
    }

    public void AddDailyMeal(Meal additionalMeal)
    {
        dailyMealList.Add(additionalMeal);
        intakeCalorie = 0f;
        recaluculateIntakenCalorie();
    }

    public void RemoveDailyMeal(Meal removedMeal)
    {
        dailyMealList.Remove(removedMeal);
        removedMeal = null;
        recaluculateIntakenCalorie();
    }

    private void recaluculateIntakenCalorie()
    {
        intakeCalorie = 0f;
        foreach (Meal meal in dailyMealList)
        {
            intakeCalorie += meal.TotalCalorie;
        }
    }
}
