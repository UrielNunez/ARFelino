using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ProfileBCo : MonoBehaviour
{
    [Header("Profile")]
    [SerializeField] private ProfileDataComunidad profileData;


    [Header("Referencias")]
    [SerializeField] private TextMeshProUGUI profileTXT;
    [SerializeField] private Image profileImg;




    void Start()
    {
        profileImg.sprite = profileData.profileSprite;

        if (profileData.useProfileText && profileTXT != null)
        {
            profileTXT.text = profileData.profileText;
        }

    }

    public void Execute()
    {
        Application.OpenURL(profileData.GetURL());
    }
}
