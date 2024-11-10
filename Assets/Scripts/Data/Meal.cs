using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Meal
{
    public List<Food> FoodList => FoodList;

    public float TotalCalorie => totalCalorie;

    private List<Food> foodList;
    private float totalCalorie;

    public void AddFoodToMeal(Food additionalFood)
    {
        foodList.Add(additionalFood);
        recaluculateTotalCalorie();
    }

    public void RemoveFoodFromMeal(Food removedFood)
    {
        foodList.Remove(removedFood);
        removedFood = null;
        recaluculateTotalCalorie();
        
    }

    private void recaluculateTotalCalorie()
    {
        totalCalorie = 0f;
        foreach (Food food in foodList)
        {
            totalCalorie += food.Calorie;
        }
    }
}
