using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Food
{
    public string FoodName => foodName;
    public float Calorie => calorie;

    private string foodName;
    private float calorie;

    public Food()
    {
        foodName = "";
        calorie = 0f;
    }
    public Food RecordFood(string foodName, float calorie)
    {
        Food food = new Food();
        food.foodName = foodName;
        food.calorie = calorie;
        return food;
    }
}
