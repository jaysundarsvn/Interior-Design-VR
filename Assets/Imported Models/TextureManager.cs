using System.Collections; // Imports System.Collections namespace
using System.Collections.Generic; // Imports System.Collections.Generic namespace
using UnityEngine; // Imports UnityEngine namespace
using TechXR.Core.Sense; // Imports TechXR.Core.Sense namespace

public class TextureManager : MonoBehaviour // Defines a public class named TextureManager that inherits from MonoBehaviour
{

    // Declares a public Animator variable named menuCanvas
    public Animator menuCanvas;

    // Declares a public Transform variable named menuContainer
    public Transform menuContainer, playerHead;

    // Declares a public MeshRenderer variable named startGobj
    public MeshRenderer startGobj;

    // Declares a private MeshRenderer variable named currentGobj
    private MeshRenderer currentGobj;

    // Use this for initialization
    void Start()
    {
        // Assigns the value of startGobj to currentGobj
        currentGobj = startGobj;
    }

    // Update is called once per frame
    void Update()
    {
        // Checks if the C button is pressed
        if (SenseInput.GetButtonDown(ButtonName.C))
        {
            // Triggers the "openclose" animation of the menuCanvas
            menuCanvas.SetTrigger("openclose");
        }

        // Sets the y rotation of the menuContainer to the y rotation of the playerHead
        menuContainer.eulerAngles = new Vector3(menuContainer.eulerAngles.x, playerHead.eulerAngles.y, menuContainer.eulerAngles.z);
    }

    // Defines a method named SetGameObjectType that takes a MeshRenderer object as a parameter
    public void SetGameObjectType(MeshRenderer gameObj)
    {
        // Assigns the value of the gameObj parameter to currentGobj
        currentGobj = gameObj;
    }

    // Defines a method named SetTextureOfGameObj that takes a Texture object as a parameter
    public void SetTextureOfGameObj(Texture texture)
    {
        // Sets the main texture of the currentGobj's material to the texture parameter
        currentGobj.material.mainTexture = texture;
    }
}