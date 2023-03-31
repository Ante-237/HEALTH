using UnityEngine;

[CreateAssetMenu(fileName = "bodyFunctions", menuName="anatomy/bodyFunctions")]
public class bodyFunctions: ScriptableObject
{

    [Header("Organ Names")]
    public string[] organNames = new string[4];


    [Header("Organ Functions")]
    public string[] functions = new string[4];

    [Header("Descriptions")]
    public string[] description = new string[4];

    [Header("Location")]
    public string[] location = new string[4];

    [Header("Size")]
    public string[] size = new string[4];

    [Header("Diseases")]
    public string[] diseases = new string[4];

    [Header("Treatment")]
    public string[] treatment = new string[4];

    [Header("Importance")]
    public string[] importance = new string[4];

    [Header("Blood Supply")]
    public string[] BloodSupply = new string[4];

    [Header("Present Content")]
    public string[] pContent = new string[9];


    [Header("Heading Names")]
    public string[] headingNames = new string[8]
    {
        "ORGAN NAMES",
        "DESCRIPTION",
        "FUNCTIONS",
        "LOCATION",
        "SIZE",
        "DISEASES",
        "IMPORTANCE",
        "TREATMENT",
    };

}
