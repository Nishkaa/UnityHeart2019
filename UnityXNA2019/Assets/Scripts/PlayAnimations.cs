using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAnimations : MonoBehaviour
{
    

    public Animator ani;
    public AudioClip heartbeat;
    AudioSource audio;

    private float timestamp;
    public float timeCount;
    public Material portaMat;
    public Material GuiSlime;
    public Material Tesselation;

    float timer;

    void Start()
    {
        portaMat.SetFloat("Vector1_E5297329", 0f);
        portaMat.SetFloat("Texture_E66F41DB", 0f);
        portaMat.SetFloat("Vector1_B5E1F82D", 0f);
        ani.enabled = false;
        audio = GetComponent<AudioSource>();

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P)){
            portaMat.SetFloat("Vector1_FE13BD3A", 0f); //To Scale
            portaMat.SetFloat("Texture_E66F41DB", 0f); //Mask
            portaMat.SetFloat("Vector1_E5297329", 0f);  //Twirl Strength
            portaMat.SetFloat("Vector1_B5E1F82D", 0f); //Twirl

            GuiSlime.SetFloat("Vector1_969EFC78", 0f); //To Scale
            GuiSlime.SetFloat("Vector1_981C4E44", 0f); //Time

            Tesselation.SetFloat("Vector1_FA344515", 0f); //Time
            Tesselation.SetFloat("Vector1_36499CBD", 0f); //offset
        }
    }


    public void OnTriggerStay(Collider other)
    {
        if ( Input.GetKeyDown(KeyCode.Z))
        {
         //other.CompareTag("RightDef"); it was for another defibrilator
         other.CompareTag("LeftDef");

            portaMat.SetFloat("Vector1_FE13BD3A", Random.Range(1f,5f)); //To Scale
            portaMat.SetFloat("Texture_E66F41DB", Random.Range(1f, 5f)); //Mask
            portaMat.SetFloat("Vector1_E5297329", Random.Range(1f, 5f));  //Twirl Strength
            portaMat.SetFloat("Vector1_B5E1F82D", Random.Range(1f, 5f)); //Twirl

            GuiSlime.SetFloat("Vector1_969EFC78", 0f); //To Scale
            GuiSlime.SetFloat("Vector1_981C4E44", 0f); //Time

            //Tesselation
            Tesselation.SetFloat("Vector1_FA344515", 0f); //Time
            Tesselation.SetFloat("Vector1_36499CBD", 0f); //offset

            ani.enabled = true;
         audio.Play();
          
        }
        if (Input.GetKeyDown(KeyCode.X))
        {
            other.CompareTag("LeftDef");
            portaMat.SetFloat("Vector1_FE13BD3A",0f); //To Scale
            portaMat.SetFloat("Texture_E66F41DB",0f); //Mask
            portaMat.SetFloat("Vector1_E5297329",0f);  //Twirl Strength
            portaMat.SetFloat("Vector1_B5E1F82D",0f); //Twirl

            GuiSlime.SetFloat("Vector1_969EFC78", Random.Range(5f, 10f)); //To Scale
            GuiSlime.SetFloat("Vector1_981C4E44", Random.Range(5f, 10f)); //Time

            //Tesselation
            Tesselation.SetFloat("Vector1_FA344515", 0f); //Time
            Tesselation.SetFloat("Vector1_36499CBD", 0f); //offset

        }
        if (Input.GetKeyDown(KeyCode.C))
        {
            other.CompareTag("LeftDef");
            portaMat.SetFloat("Vector1_FE13BD3A", 0f); //To Scale
            portaMat.SetFloat("Texture_E66F41DB", 0f); //Mask
            portaMat.SetFloat("Vector1_E5297329", 0f);  //Twirl Strength
            portaMat.SetFloat("Vector1_B5E1F82D", 0f); //Twirl

            GuiSlime.SetFloat("Vector1_969EFC78",0f); //To Scale
            GuiSlime.SetFloat("Vector1_981C4E44", 0f); //Time

            //Tesselation
            Tesselation.SetFloat("Vector1_FA344515", Random.Range(2f, 10f)); //Time
            Tesselation.SetFloat("Vector1_36499CBD", 0f); //offset

        }
    }

}
