using System.Collections;
using System.Collections.Generic;
using UnityEngine;




[CreateAssetMenu(fileName = "Profile Data", menuName = "ScriptableObjects/ProfileData Face Grupos ", order = 1)]
public class ProfileDataFaceGrupos : ScriptableObject
{
    public enum URLType
    {
        Normal,
        Phone,
        Email,

    }

    [Header("General")]
    public string URL;
    public URLType urlType = URLType.Normal;
    public Sprite profileSprite;
    [Space]
    public bool useProfileText;
    public string profileText;

    [Header("Type Email")]
    public string emailDirection;
    public string emailSubject;
    public string emailBody;


    public string GetURL()
    {
        switch (urlType)
        {
            case URLType.Normal:
                return URL;

            case URLType.Phone:
                return string.Format("tel://{0}", URL);

            case URLType.Email:
                return string.Format("mailto:{0}?subject={1}&body={2}", emailDirection, emailSubject, emailBody);

        }
        return "";
    }
}
