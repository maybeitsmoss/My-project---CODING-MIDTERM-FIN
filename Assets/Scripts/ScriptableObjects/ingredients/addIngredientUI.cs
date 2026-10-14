using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class addIngredientUI : MonoBehaviour
{
    public GameObject layoutContainer;
    
    public List <ingredients_so> ingredients;

    public void Start()
    {
        HorizontalLayoutGroup layout = layoutContainer.GetComponent<HorizontalLayoutGroup>();
        Debug.Log(ingredients[1].ingredientName);
    }

    
    public void GotIngredient(string name)
    {
        for (int i = 0; i < ingredients.Count; i++)
        {
            if (ingredients[i].ingredientName == name)
            {
                AddIngredient(ingredients[i]);
                break;
            }
        }
    }

    public void AddIngredient(ingredients_so ingredient)
    {
        GameObject newIngredient = new GameObject();
        Image img = newIngredient.AddComponent<Image>();
        img.sprite = ingredient.icon;

        newIngredient.transform.SetParent(layoutContainer.transform, false);
    }
}
