using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveScript : MonoBehaviour
{
    // create an objects for all the 3d models as "GameObject"
    // to control the 3d models movments 
    GameObject Hydrogen;
    GameObject Oxygen;
    GameObject aluminum;
    GameObject water;
    GameObject aluminumSolid;

    // Start is called before the first frame update
    void Start()
    {
        // to find the 3d models by name 
        Hydrogen = GameObject.Find("hydrogen atom");
        Oxygen = GameObject.Find("oxygen atom");
        aluminum = GameObject.Find("aluminum atom");
        water = GameObject.Find("water atom");
        aluminumSolid= GameObject.Find("aluminumSolid");
    }

    // Update is called once per frame
    void Update()
    {
        movmentsAtoms();
    }

    void movmentsAtoms()
    {
        // calling transform.rotate to move the 3d model 
        // X= -left , +right 
        // Y= - down ,+up
        // Z= -back,+forword
        // number indectas the speed of the rotateion 
        Hydrogen.transform.Rotate(new Vector3(11,3,10) * Time.deltaTime);
        Oxygen.transform.Rotate(new Vector3(12, 3,14) * Time.deltaTime);
        aluminum.transform.Rotate(new Vector3(15, 1,12) * Time.deltaTime);
        water.transform.Rotate(new Vector3(13, 10, 5) * Time.deltaTime);
        aluminumSolid.transform.Rotate(new Vector3(3, 5, 5) * Time.deltaTime);
        /*
        // or we can wraite like this the code 
        in start:
        Public float x,y,z;
        Vector3d move= new Vector3d(x,y,z);

        in move :
        Hydrogen.transform.Rotate(move * Time.deltaTime);
        Oxygen.transform.Rotate(move * Time.deltaTime);
        aluminum.transform.Rotate(move* Time.deltaTime);
        water.transform.Rotate(move * Time.deltaTime);

        in update :
        //call move the same way;
        and form unity interface in the inspactor 
        of each model you can the value of x,y,z;
        */
    }
}
