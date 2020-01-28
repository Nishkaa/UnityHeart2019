using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour
{
    public Material portaMat;
    public Material GuiSlime;
    public Material Tesselation;
    float timer;

    void Start()
    {

        portaMat.SetFloat("Vector1_E5297329", 0f);//To Scale
        portaMat.SetFloat("Texture_E66F41DB", 0f);//Mask
        GuiSlime.SetFloat("Vector1_969EFC78", 0f); //To Scale
        GuiSlime.SetFloat("Vector1_981C4E44", 0f); //Time
        //Tesselation
        Tesselation.SetFloat("Vector1_FA344515", 0f); //Time
        Tesselation.SetFloat("Vector1_36499CBD", 0f); //offset
    }

    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.P))
        {
            timer = Time.time -1;
            portaMat.SetFloat("Vector1_FE13BD3A", 0f); //To Scale
            portaMat.SetFloat("Texture_E66F41DB", 0f); //Mask
            portaMat.SetFloat("Vector1_E5297329", 0f);  //Twirl Strength
            portaMat.SetFloat("Vector1_B5E1F82D", 0f); //Twirl
            //Testing Shader
            GuiSlime.SetFloat("Vector1_969EFC78", 0f); //To Scale
            GuiSlime.SetFloat("Vector1_981C4E44", 0f); //Time
             //Tesselation
            Tesselation.SetFloat("Vector1_FA344515", 0f); //Time
            Tesselation.SetFloat("Vector1_36499CBD", 0f); //offset

        }
    }

}


