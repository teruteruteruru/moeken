using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class DailyData
{
    public DateTime Date => date;
    public List<Meal> DailyMealList => dailyMealList;
    public List<Exercise> DailyExerciseList => dailyExerciseList;
    public float DailyWeight => dailyWeight;
    public float IntakenCalorie => intakenCalorie;
    public float BurntCalorie => burntCalorie;

    private DateTime date;
    private List<Meal> dailyMealList;
    private List<Exercise> dailyExerciseList;
    private float dailyWeight;
    private float intakenCalorie;
    private float burntCalorie;

    public DailyData()
    {
        date = DateTime.Today;
        dailyWeight = 0f;
        intakenCalorie = 0f;
        burntCalorie = 0f;
    }

    public void RecoderDate(DateTime date)
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
        intakenCalorie = 0f;
        recaluculateIntakenCalorie();
    }

    public void RemoveDailymeal(Meal removedMeal)
    {
        dailyMealList.Remove(removedMeal);
        removedMeal = null;
        recaluculateIntakenCalorie();
    }

    private void recaluculateIntakenCalorie()
    {
        intakenCalorie = 0f;
        foreach (Meal meal in dailyMealList)
        {
            intakenCalorie += meal.TotalCalorie;
        }
    }
}
